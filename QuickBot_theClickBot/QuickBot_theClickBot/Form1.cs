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

namespace QuickBot_theClickBot
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        public List<string[]> clicks = new List<string[]>();
        public string[] singleClickData;
        public Stopwatch watch;

        // mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public bool recordClicks = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void getMouseClickData(object sender, MouseEventArgs e)
        {
            if (recordClicks == true) {
                HookManager.MouseClick -= new MouseEventHandler(getMouseClickData);
                /////

                singleClickData = new string[3];
                singleClickData[0] = Convert.ToString(Cursor.Position.X);
                singleClickData[1] = Convert.ToString(Cursor.Position.Y);
                singleClickData[2] = Convert.ToString(watch.ElapsedMilliseconds);
                clicks.Add(singleClickData);

                label1.Text = singleClickData[0];
                label2.Text = singleClickData[1];
                label3.Text = singleClickData[2];

                //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                /////
                HookManager.MouseClick += new MouseEventHandler(getMouseClickData);
            }
        }

        public void setData()
        {
            foreach (var elem in clicks)
            {
                clicksDropdownlist.Items.Add(elem[0] + " " + elem[1] + " " + elem[2]);
            }
        }

        public void linkData()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Minimized;
            HookManager.MouseClick += new MouseEventHandler(getMouseClickData);
            recordClicks = true;
            watch = Stopwatch.StartNew();
            // start saving click positions
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recordClicks = false;
            watch.Stop();
            setData();
        }
    }
}
