namespace KeyLogger
{
    /// <summary>
    /// Key code of all input keys
    /// </summary>
    public enum KeyCode
    {
        /// <summary>
        /// No key pressed
        /// </summary>
        None = 0,

        /// <summary>
        /// Left mouse button
        /// </summary>
        LButton = 1,
        /// <summary>
        /// Right mouse button
        /// </summary>
        RButton = 2,
        /// <summary>
        /// CANCEL key
        /// </summary>
        Cancel = 3,
        /// <summary>
        /// Middle mouse button
        /// </summary>
        MButton = 4,
        /// <summary>
        /// First x mouse button (five-button mouse)
        /// </summary>
        XButton1 = 5,
        /// <summary>
        /// Second x mouse button (five-button mouse)
        /// </summary>
        XButton2 = 6,

        /// <summary>
        /// BACKSPACE key
        /// </summary>
        Back = 8,
        /// <summary>
        /// TAB key
        /// </summary>
        Tab = 9,
        /// <summary>
        /// LINEFEED key
        /// </summary>
        LineFeed = 10,
        /// <summary>
        /// CLEAR key
        /// </summary>
        Clear = 12,
        /// <summary>
        /// RETURN key
        /// </summary>
        Return = 13,
        /// <summary>
        /// ENTER key
        /// </summary>
        Enter = 13,
        /// <summary>
        /// SHIFT key
        /// </summary>
        ShiftKey = 16,
        /// <summary>
        /// CTRL key
        /// </summary>
        ControlKey = 17,
        /// <summary>
        /// ALT key
        /// </summary>
        Menu = 18,
        /// <summary>
        /// PAUSE key
        /// </summary>
        Pause = 19,
        /// <summary>
        /// CAPS LOCK key
        /// </summary>
        Capital = 20,
        /// <summary>
        /// CAPS LOCK key
        /// </summary>
        CapsLock = 20,

        /// <summary>
        /// IME Kana mode key
        /// </summary>
        KanaMode = 21,
        /// <summary>
        /// IME Hanguel mode key (maintained for compatibility; use HangulMode)
        /// </summary>
        HanguelMode = 21,
        /// <summary>
        /// IME Hangul mode key
        /// </summary>
        HangulMode = 21,
        /// <summary>
        /// IME Junja mode key
        /// </summary>
        JunjaMode = 23,
        /// <summary>
        /// IME final mode key
        /// </summary>
        FinalMode = 24,
        /// <summary>
        /// IME Hanja mode key
        /// </summary>
        HanjaMode = 25,
        /// <summary>
        /// IME Kanji mode key
        /// </summary>
        KanjiMode = 25,

        /// <summary>
        /// ESC key
        /// </summary>
        Escape = 27,

        /// <summary>
        /// IME convert key
        /// </summary>
        IMEConvert = 28,
        /// <summary>
        /// IME nonconvert key
        /// </summary>
        IMENonconvert = 29,
        /// <summary>
        /// IME accept key, replaces SystemWindowsFormsKeysIMEAceept
        /// </summary>
        IMEAccept = 30,
        /// <summary>
        /// IME accept key Obsolete, use SystemWindowsFormsKeysIMEAccept instead
        /// </summary>
        IMEAceept = 30,
        /// <summary>
        /// IME mode change key
        /// </summary>
        IMEModeChange = 31,
        /// <summary>
        /// SPACEBAR key
        /// </summary>
        Space = 32,
        /// <summary>
        /// PAGE UP key
        /// </summary>
        Prior = 33,
        /// <summary>
        /// PAGE UP key
        /// </summary>
        PageUp = 33,
        /// <summary>
        /// PAGE DOWN key
        /// </summary>
        PageDown = 34,
        /// <summary>
        /// PAGE DOWN key
        /// </summary>
        Next = 34,
        /// <summary>
        /// END key
        /// </summary>
        End = 35,
        /// <summary>
        /// HOME key
        /// </summary>
        Home = 36,
        /// <summary>
        /// LEFT ARROW key
        /// </summary>
        Left = 37,
        /// <summary>
        /// UP ARROW key
        /// </summary>
        Up = 38,
        /// <summary>
        /// RIGHT ARROW key
        /// </summary>
        Right = 39,
        /// <summary>
        /// DOWN ARROW key
        /// </summary>
        Down = 40,
        /// <summary>
        /// SELECT key
        /// </summary>
        Select = 41,
        /// <summary>
        /// PRINT SCREEN key
        /// </summary>
        Print = 42,
        /// <summary>
        /// EXECUTE key
        /// </summary>
        Execute = 43,
        /// <summary>
        /// SNAPSHOT key
        /// </summary>
        Snapshot = 44,
        /// <summary>
        /// INS key
        /// </summary>
        PrintScreen = 44,
        /// <summary>
        /// INS key
        /// </summary>
        Insert = 45,
        /// <summary>
        /// DEL key
        /// </summary>
        Delete = 46,
        /// <summary>
        /// HELP key
        /// </summary>
        Help = 47,

        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D0 = 48,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D1 = 49,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D2 = 50,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D3 = 51,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D4 = 52,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D5 = 53,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D6 = 54,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D7 = 55,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D8 = 56,
        /// <summary>
        /// numeric keys across the top of the keyboard (D0-D9)
        /// </summary>
        D9 = 57,

        /// <summary>
        /// A key
        /// </summary>
        A = 65,
        /// <summary>
        /// B key
        /// </summary>
        B = 66,
        /// <summary>
        /// C key
        /// </summary>
        C = 67,
        /// <summary>
        /// D key
        /// </summary>
        D = 68,
        /// <summary>
        /// E key
        /// </summary>
        E = 69,
        /// <summary>
        /// F key
        /// </summary>
        F = 70,
        /// <summary>
        /// G key
        /// </summary>
        G = 71,
        /// <summary>
        /// H key
        /// </summary>
        H = 72,
        /// <summary>
        /// I key
        /// </summary>
        I = 73,
        /// <summary>
        /// J key
        /// </summary>
        J = 74,
        /// <summary>
        /// K key
        /// </summary>
        K = 75,
        /// <summary>
        /// L key
        /// </summary>
        L = 76,
        /// <summary>
        /// M key
        /// </summary>
        M = 77,
        /// <summary>
        /// N key
        /// </summary>
        N = 78,
        /// <summary>
        /// O key
        /// </summary>
        O = 79,
        /// <summary>
        /// P key
        /// </summary>
        P = 80,
        /// <summary>
        /// Q key
        /// </summary>
        Q = 81,
        /// <summary>
        /// R key
        /// </summary>
        R = 82,
        /// <summary>
        /// S key
        /// </summary>
        S = 83,
        /// <summary>
        /// T key
        /// </summary>
        T = 84,
        /// <summary>
        /// U key
        /// </summary>
        U = 85,
        /// <summary>
        /// V key
        /// </summary>
        V = 86,
        /// <summary>
        /// W key
        /// </summary>
        W = 87,
        /// <summary>
        /// X key
        /// </summary>
        X = 88,
        /// <summary>
        /// Y key
        /// </summary>
        Y = 89,
        /// <summary>
        /// Z key
        /// </summary>
        Z = 90,

        /// <summary>
        ///  left Windows logo key (Microsoft Natural Keyboard)
        /// </summary>
        LWin = 91,
        /// <summary>
        /// right Windows logo key (Microsoft Natural Keyboard)
        /// </summary>
        RWin = 92,
        /// <summary>
        /// application key (Microsoft Natural Keyboard)
        /// </summary>
        Apps = 93,
        /// <summary>
        /// computer sleep key
        /// </summary>
        Sleep = 95,

        /// <summary>
        /// 0 key (Keys on the numeric keypad)
        /// </summary>
        NumPad0 = 96,
        /// <summary>
        /// 1 key (Keys on the numeric keypad)
        /// </summary>
        NumPad1 = 97,
        /// <summary>
        /// 2 key (Keys on the numeric keypad)
        /// </summary>
        NumPad2 = 98,
        /// <summary>
        /// 3 key (Keys on the numeric keypad)
        /// </summary>
        NumPad3 = 99,
        /// <summary>
        /// 4 key (Keys on the numeric keypad)
        /// </summary>
        NumPad4 = 100,
        /// <summary>
        /// 5 key (Keys on the numeric keypad)
        /// </summary>
        NumPad5 = 101,
        /// <summary>
        /// 6 key (Keys on the numeric keypad)
        /// </summary>
        NumPad6 = 102,
        /// <summary>
        /// 7 key (Keys on the numeric keypad)
        /// </summary>
        NumPad7 = 103,
        /// <summary>
        /// 8 key (Keys on the numeric keypad)
        /// </summary>
        NumPad8 = 104,
        /// <summary>
        /// 9 key (Keys on the numeric keypad)
        /// </summary>
        NumPad9 = 105,
        /// <summary>
        /// MULTIPLICATION SIGN (*) key
        /// </summary>
        Multiply = 106,
        /// <summary>
        /// PLUS SIGN (+) key
        /// </summary>
        Add = 107,
        /// <summary>
        /// ENTER (keypad) key
        /// </summary>
        Separator = 108,
        /// <summary>
        /// MINUS SIGN (-) key
        /// </summary>
        Subtract = 109,
        /// <summary>
        /// DECIMAL POINT(.) key
        /// </summary>
        Decimal = 110,
        /// <summary>
        /// DIVISION SIGN (/) key
        /// </summary>
        Divide = 111,

        /// <summary>
        ///F1 key
        /// </summary>
        F1 = 112,
        /// <summary>
        ///F2 key
        /// </summary>
        F2 = 113,
        /// <summary>
        ///F3 key
        /// </summary>
        F3 = 114,
        /// <summary>
        ///F4 key
        /// </summary>
        F4 = 115,
        /// <summary>
        ///F5 key
        /// </summary>
        F5 = 116,
        /// <summary>
        ///F6 key
        /// </summary>
        F6 = 117,
        /// <summary>
        ///F7 key
        /// </summary>
        F7 = 118,
        /// <summary>
        ///F8 key
        /// </summary>
        F8 = 119,
        /// <summary>
        ///F9 key
        /// </summary>
        F9 = 120,
        /// <summary>
        /// F10 key
        /// </summary>
        F10 = 121,
        /// <summary>
        /// F11 key
        /// </summary>
        F11 = 122,
        /// <summary>
        /// F12 key
        /// </summary>
        F12 = 123,
        /// <summary>
        /// F13 key
        /// </summary>
        F13 = 124,
        /// <summary>
        /// F14 key
        /// </summary>
        F14 = 125,
        /// <summary>
        /// F15 key
        /// </summary>
        F15 = 126,
        /// <summary>
        /// F16 key
        /// </summary>
        F16 = 127,
        /// <summary>
        /// F17 key
        /// </summary>
        F17 = 128,
        /// <summary>
        /// F18 key
        /// </summary>
        F18 = 129,
        /// <summary>
        /// F19 key
        /// </summary>
        F19 = 130,
        /// <summary>
        /// F20 key
        /// </summary>
        F20 = 131,
        /// <summary>
        /// F21 key
        /// </summary>
        F21 = 132,
        /// <summary>
        /// F22 key
        /// </summary>
        F22 = 133,
        /// <summary>
        /// F23 key
        /// </summary>
        F23 = 134,
        /// <summary>
        /// F24 key
        /// </summary>
        F24 = 135,

        /// <summary>
        /// NUM LOCK key
        /// </summary>
        NumLock = 144,
        /// <summary>
        /// SCROLL LOCK key
        /// </summary>
        Scroll = 145,
        /// <summary>
        /// left SHIFT key
        /// </summary>
        LShiftKey = 160,
        /// <summary>
        /// right SHIFT key
        /// </summary>
        RShiftKey = 161,
        /// <summary>
        /// left CTRL key
        /// </summary>
        LControlKey = 162,
        /// <summary>
        /// right CTRL key
        /// </summary>
        RControlKey = 163,
        /// <summary>
        /// left ALT key
        /// </summary>
        LMenu = 164,
        /// <summary>
        /// right ALT key
        /// </summary>
        RMenu = 165,

        /// <summary>
        /// browser back key (Windows 2000 or later)
        /// </summary>
        BrowserBack = 166,
        /// <summary>
        /// browser forward key (Windows 2000 or later)
        /// </summary>
        BrowserForward = 167,
        /// <summary>
        /// browser refresh key (Windows 2000 or later)
        /// </summary>
        BrowserRefresh = 168,
        /// <summary>
        /// browser stop key (Windows 2000 or later)
        /// </summary>
        BrowserStop = 169,
        /// <summary>
        /// browser search key (Windows 2000 or later)
        /// </summary>
        BrowserSearch = 170,
        /// <summary>
        /// browser favorites key (Windows 2000 or later)
        /// </summary>
        BrowserFavorites = 171,
        /// <summary>
        /// browser home key (Windows 2000 or later)
        /// </summary>
        BrowserHome = 172,

        /// <summary>
        /// volume mute key (Windows 2000 or later)
        /// </summary>
        VolumeMute = 173,
        /// <summary>
        /// volume down key (Windows 2000 or later)
        /// </summary>
        VolumeDown = 174,
        /// <summary>
        /// volume up key (Windows 2000 or later)
        /// </summary>
        VolumeUp = 175,

        /// <summary>
        /// media next track key (Windows 2000 or later)
        /// </summary>
        MediaNextTrack = 176,
        /// <summary>
        /// media previous track key (Windows 2000 or later)
        /// </summary>
        MediaPreviousTrack = 177,
        /// <summary>
        /// media Stop key (Windows 2000 or later)
        /// </summary>
        MediaStop = 178,
        /// <summary>
        /// media play pause key (Windows 2000 or later)
        /// </summary>
        MediaPlayPause = 179,
        /// <summary>
        /// launch mail key (Windows 2000 or later)
        /// </summary>
        LaunchMail = 180,
        /// <summary>
        /// select media key (Windows 2000 or later)
        /// </summary>
        SelectMedia = 181,
        /// <summary>
        /// start application one key (Windows 2000 or later)
        /// </summary>
        LaunchApplication1 = 182,
        /// <summary>
        /// start application two key (Windows 2000 or later)
        /// </summary>
        LaunchApplication2 = 183,
        /// <summary>
        /// OEM 1 key
        /// </summary>
        OemSemicolon = 186,
        /// <summary>
        /// OEM Semicolon key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        Oem1 = 186,
        /// <summary>
        /// OEM plus key on any country/region keyboard (Windows 2000 or later)
        /// </summary>
        Oemplus = 187,
        /// <summary>
        /// OEM comma key on any country/region keyboard (Windows 2000 or later)
        /// </summary>
        Oemcomma = 188,
        /// <summary>
        /// OEM minus key on any country/region keyboard (Windows 2000 or later)
        /// </summary>
        OemMinus = 189,
        /// <summary>
        /// OEM period key on any country/region keyboard (Windows 2000 or later)
        /// </summary>
        OemPeriod = 190,
        /// <summary>
        /// OEM question mark key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        OemQuestion = 191,
        /// <summary>
        /// OEM 2 key
        /// </summary>
        Oem2 = 191,
        /// <summary>
        /// OEM tilde key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        Oemtilde = 192,
        /// <summary>
        /// OEM 3 key
        /// </summary>
        Oem3 = 192,
        /// <summary>
        ///
        /// </summary>
        LatinKeyboardBar = 193,
        /// <summary>
        ///
        /// </summary>
        NumPadDot = 194,
        /// <summary>
        /// OEM open bracket key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        OemOpenBrackets = 219,
        /// <summary>
        /// OEM 4 key
        /// </summary>
        Oem4 = 219,
        /// <summary>
        /// OEM pipe key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        OemPipe = 220,
        /// <summary>
        /// OEM 5 key
        /// </summary>
        Oem5 = 220,
        /// <summary>
        /// OEM close bracket key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        OemCloseBrackets = 221,
        /// <summary>
        /// OEM 6 key
        /// </summary>
        Oem6 = 221,
        /// <summary>
        /// OEM singled/double quote key on a US standard keyboard (Windows 2000 or later)
        /// </summary>
        OemQuotes = 222,
        /// <summary>
        /// OEM 7 key
        /// </summary>
        Oem7 = 222,
        /// <summary>
        /// OEM 8 key
        /// </summary>
        Oem8 = 223,
        /// <summary>
        /// OEM angle bracket or backslash key on the RT 102 key keyboard (Windows 2000 or later)
        /// </summary>
        OemBackslash = 226,
        /// <summary>
        /// OEM 102 key
        /// </summary>
        Oem102 = 226,
        /// <summary>
        /// PROCESS KEY key
        /// </summary>
        ProcessKey = 229,
        /// <summary>
        /// Used to pass Unicode characters as if they were keystrokes Packet key value is the low word of a 32-bit virtual-key value used for non-keyboard input methods
        /// </summary>
        Packet = 231,
        /// <summary>
        /// ATTN key
        /// </summary>
        Attn = 246,
        /// <summary>
        /// CRSEL key
        /// </summary>
        Crsel = 247,
        /// <summary>
        /// EXSEL key
        /// </summary>
        Exsel = 248,
        /// <summary>
        /// ERASE EOF key
        /// </summary>
        EraseEof = 249,
        /// <summary>
        /// PLAY key
        /// </summary>
        Play = 250,
        /// <summary>
        /// ZOOM key
        /// </summary>
        Zoom = 251,
        /// <summary>
        /// A constant reserved for future use
        /// </summary>
        NoName = 252,
        /// <summary>
        /// PA1 key
        /// </summary>
        Pa1 = 253,
        /// <summary>
        /// CLEAR key
        /// </summary>
        OemClear = 254,
        /// <summary>
        /// bitmask to extract a key code from a key value
        /// </summary>
        KeyCode = 65535,

        /// <summary>
        /// SHIFT modifier key
        /// </summary>
        Shift = 65536,
        /// <summary>
        /// CTRL modifier key
        /// </summary>
        Control = 131072,
        /// <summary>
        /// ALT modifier key
        /// </summary>
        Alt = 262144,
        /// <summary>
        ///
        /// </summary>
        Modifiers = -65536
    }
}
