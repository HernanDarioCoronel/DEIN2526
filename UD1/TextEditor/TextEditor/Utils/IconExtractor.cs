using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TextEditor.Utils
{
    public class IconExtractor
    {
        [DllImport("shell32.dll", EntryPoint = "ExtractIcon")]
        public static extern IntPtr ExtractIcon(IntPtr hInst, string lpszExeFileName, int nIconIndex);

        public static Icon GetShellIcon(int index)
        {
            IntPtr hIcon = ExtractIcon(IntPtr.Zero, @"C:\Windows\System32\shell32.dll", index);
            if (hIcon == IntPtr.Zero)
                return null;

            return Icon.FromHandle(hIcon);
        }
    }
}
