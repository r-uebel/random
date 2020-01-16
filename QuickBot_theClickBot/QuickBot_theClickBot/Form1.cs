using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Gma.UserActivityMonitor;
using System.Diagnostics;
using System.IO;

namespace QuickBot_theClickBot
{
    public partial class Form1 : Form
    {
        //[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        //public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //[DllImport("user32.dll")]
        //static extern bool SetCursorPos(int X, int Y);

        //public List<string[]> clicks = new List<string[]>();
        //public string[] singleClickData;
        //public Stopwatch watch;
        //public int cheapCounter = 1;
        public MyFileManager fileManager;
        //public ClickManager clickManager;


        // mouse actions
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public bool recordClicks = false;

        public Form1()
        {
            InitializeComponent();
            fileManager = new MyFileManager();
            fileManager.getFiles();
            fileManager.setFiles(this);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // deactivated for debugging purposes
            //WindowState = FormWindowState.Minimized;
            HookManager.MouseClick += new MouseEventHandler(ClickManager.getMouseClickData);
            recordClicks = true;
            ClickManager.watch = Stopwatch.StartNew();
            // start saving click positions and timings
        }

        public void button2_Click(object sender, EventArgs e)
        {
            recordClicks = false;
            ClickManager.watch.Stop();
            fileManager.writeToCsv(ClickManager.clicks, this);
            fileManager.getFiles();
            fileManager.setFiles(this);
        }

        public async void hammertimeButton_Click(object sender, EventArgs e)
        {
            List<uint[]> allClickData = ClickManager.parseClicks(this);
            uint[] shit = allClickData.First();
            int timing = Convert.ToInt32(shit[2]);
            for (int i = 0; i < allClickData.Count()-1; i++)
            {
                uint x = allClickData[i][0];
                uint y = allClickData[i][1];
                try
                {
                    int thisTiming = (int)allClickData[i][2];
                    int nextTiming = (int)allClickData[i+1][2];
                    timing = nextTiming - thisTiming;
                    timing = timing < 0 ? timing * -1 : timing;
                }
                catch (IndexOutOfRangeException) { timing = 50; }

                await Task.Delay(timing);

                ClickManager.SetCursorPos((int)x, (int)y);
                ClickManager.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
        }

        // debug only start
        public void label1_Click(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.Red)
                label1.BackColor = Color.Green;
            else
                label1.BackColor = Color.Red;
        }
        public void label2_Click(object sender, EventArgs e)
        {
            if (label2.BackColor == Color.Red)
                label2.BackColor = Color.Green;
            else
                label2.BackColor = Color.Red;
        }
        public void label3_Click(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.Red)
                label3.BackColor = Color.Green;
            else
                label3.BackColor = Color.Red;
        }
        public void label5_Click(object sender, EventArgs e)
        {
            if (label5.BackColor == Color.Red)
                label5.BackColor = Color.Green;
            else
                label5.BackColor = Color.Red;
        }
        public void label6_Click(object sender, EventArgs e)
        {
            if (label6.BackColor == Color.Red)
                label6.BackColor = Color.Green;
            else
                label6.BackColor = Color.Red;
        }
        // debug only end
    }
}
