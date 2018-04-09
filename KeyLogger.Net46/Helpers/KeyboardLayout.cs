using System;
using System.Globalization;

namespace KeyLogger.Helpers
{
    /// <summary>
    /// Gets keyboard layout of current active window
    /// </summary>
    internal class KeyboardLayout
    {
        /// <summary>
        /// Simulates the behaviour of the language panel on Windows.
        /// </summary>
        /// <seealso cref="https://yal.cc/csharp-get-current-keyboard-layout/"/>
        internal CultureInfo GetCurrentKeyboardLayout()
        {
            try
            {
                IntPtr foregroundWindow = Win32.GetForegroundWindow();
                uint foregroundProcess = Win32.GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
                int keyboardLayout = Win32.GetKeyboardLayout(foregroundProcess).ToInt32() & 0xFFFF;
                return new CultureInfo(keyboardLayout);
            }
            catch
            {
                return new CultureInfo(1033); // Assume English if something went wrong.
            }
        }
    }
}
