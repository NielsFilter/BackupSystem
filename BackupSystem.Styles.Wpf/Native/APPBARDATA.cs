﻿using System;
using System.Runtime.InteropServices;

namespace BackupSystem.Styles.Wpf.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct APPBARDATA
    {
        public int cbSize;
        public IntPtr hWnd;
        public int uCallbackMessage;
        public int uEdge;
        public RECT rc;
        public bool lParam;
    }
}
