using Gma.UserActivityMonitor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickBot_theClickBot
{
    public static class ClickManager
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);

        // mouse actions
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static bool recordClicks = false;

        public static int cheapCounter = 1;
        public static string[] singleClickData;
        public static Stopwatch watch;
        public static List<string[]> clicks = new List<string[]>();

        //public ClickManager(){}

        public static void getMouseClickData(object sender, MouseEventArgs e)
        {
            if (recordClicks == true && cheapCounter % 2 == 1)
            {
                HookManager.MouseClick -= new MouseEventHandler(getMouseClickData); // unregister event, prevents infinite loops
                /////

                cheapCounter++;
                singleClickData = new string[3];
                singleClickData[0] = Convert.ToString(Cursor.Position.X);
                singleClickData[1] = Convert.ToString(Cursor.Position.Y);
                singleClickData[2] = Convert.ToString(watch.ElapsedMilliseconds);
                clicks.Add(singleClickData);

                /////
                HookManager.MouseClick += new MouseEventHandler(getMouseClickData); // re-register event
            }
            else { cheapCounter++; }
        }

        public static List<uint[]> parseClicks(Form1 form)
        {
            object selectedItem = form.clicksDropdownlist.SelectedItem;
            string usedFile = selectedItem.ToString();
            string fileText = File.ReadAllText(@"../../saves/" + usedFile);
            string[] clickData = fileText.Split(';');
            Array.Resize(ref clickData, clickData.Length - 1);

            List<uint[]> allClickData = new List<uint[]>();
            foreach (var click in clickData)
            {
                string[] temp = click.Split(',');
                uint[] convertedClickData = Array.ConvertAll<string, uint>(temp, uint.Parse);
                uint[] usableClickData = new uint[3];
                usableClickData[0] = convertedClickData[0]; // X coordinates
                usableClickData[1] = convertedClickData[1]; // Y coordinates
                usableClickData[2] = convertedClickData[2]; // click timing
                allClickData.Add(usableClickData);
            }
            return allClickData;
        }
    }
}
