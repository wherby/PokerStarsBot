using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;



namespace UIControl.Lib
{
    public class UIControl
    {
        public static int left = 0, right = 0, top = 0, bot = 0;
        public static int WIDTH = 800, HEIGHT = 600, widthReal=0, heightReal=0;
        private static Process procPoker = null;

        public static void CaptureApplication(string procName)
        {
            var proc = Process.GetProcessesByName(procName)[0];

            var rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);
            left = rect.left;
            right = rect.right;
            top = rect.top;
            bot = rect.bottom;
            widthReal = right - left;
            heightReal = bot - top;
            System.Windows.MessageBox.Show("left:" + rect.left.ToString()+ "  right: "+ rect.right.ToString()+
                 " top "+rect.top+ " bot " +rect.bottom, "Cards in Hand");
            //clickRaise();

        }

        private static Process getProcess() {
            procPoker = Process.GetProcessesByName("PokerStars")[0];
            return procPoker;
        }

        public static void clickFold() {
            if (procPoker == null) {
                procPoker = getProcess();
            }
            if (left == 0) {
                CaptureApplication("PokerStars");
            }
            int width = 432, height = 520;
            var point = new System.Drawing.Point(width *widthReal /WIDTH, height * heightReal /HEIGHT);
            ClickOnPointTool.ClickOnPoint(procPoker.MainWindowHandle, point);
        }

        public static void clickCheck()
        {
            if (procPoker == null)
            {
                procPoker = getProcess();
            }
            if (left == 0)
            {
                CaptureApplication("PokerStars");
            }
            int width = 597, height = 520;
            var point = new System.Drawing.Point(width * widthReal / WIDTH, height * heightReal / HEIGHT);
            ClickOnPointTool.ClickOnPoint(procPoker.MainWindowHandle, point);
        }

        public static void clickRaise() {
            if (procPoker == null)
            {
                procPoker = getProcess();
            }
            if (left == 0)
            {
                CaptureApplication("PokerStars");
            }
            int width = 729, height = 520;
            var point = new System.Drawing.Point(width * widthReal / WIDTH, height * heightReal / HEIGHT);
            ClickOnPointTool.ClickOnPoint(procPoker.MainWindowHandle, point);
        }
    }

    public class ClickOnPointTool
    {

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref System.Drawing.Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649


        public static void ClickOnPoint(IntPtr wndHandle, System.Drawing.Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            ClientToScreen(wndHandle, ref clientPoint);

            /// set cursor on coords, and press mouse
            Cursor.Position = new System.Drawing.Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            /// return mouse 
         //   Cursor.Position = oldPos;
        }

    }

    internal class User32
    {
        [System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

    }
}