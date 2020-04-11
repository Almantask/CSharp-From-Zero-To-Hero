using System;
using System.Runtime.InteropServices;

namespace BootCamp.Chapter.Examples.PremadeAttributes.OutsideNET
{
    public static class InteropWithUnamangedCode
    {
        // Use DllImport to import the Win32 MessageBox function.
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public static void Run()
        {
            // Call the MessageBox function using platform invoke.
            MessageBox(new IntPtr(0), "Live coding!", "Lesson 10", 0);
        }
    }
}
