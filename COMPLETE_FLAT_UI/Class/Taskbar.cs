using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAMAVERICK.Class
{
    public class Taskbar
    {
        [DllImport("user32.dll")]
        public static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int command);

        public const int SW_HIDE = 0;
        public const int SW_SHOW = 1;

    }
}
