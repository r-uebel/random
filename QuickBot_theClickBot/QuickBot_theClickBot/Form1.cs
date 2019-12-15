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
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        public List<string[]> clicks = new List<string[]>();
        public string[] singleClickData;
        public Stopwatch watch;
        public string csvString;
        public string filename;
        public DirectoryInfo dir = new DirectoryInfo(@"../../saves");
        public FileInfo[] files;

        // mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public bool recordClicks = false;

        public Form1()
        {
            InitializeComponent();
            getFiles();
            setFiles();
        }

        public void getMouseClickData(object sender, MouseEventArgs e)
        {
            if (recordClicks == true) {
                HookManager.MouseClick -= new MouseEventHandler(getMouseClickData); // unregister event, prevents infinite loops
                /////

                singleClickData = new string[3];
                singleClickData[0] = Convert.ToString(Cursor.Position.X);
                singleClickData[1] = Convert.ToString(Cursor.Position.Y);
                singleClickData[2] = Convert.ToString(watch.ElapsedMilliseconds);
                clicks.Add(singleClickData);

                /////
                HookManager.MouseClick += new MouseEventHandler(getMouseClickData); // re-register event
            }
        }

        public void getFiles()
        {
            files = dir.GetFiles();
        }
        public void setFiles()
        {
            clicksDropdownlist.Items.Clear();
            foreach (FileInfo file in files)
            {
                clicksDropdownlist.Items.Add(file);
            }
        }

        public void writeToCsv()
        {
            foreach (var elem in clicks)
            {
                csvString += elem[0] + "," + elem[1] + "," + elem[2] + ";";
            }
            /////
            filename = filenameInput.Text == "" ? "ohshit" : filenameInput.Text;
            if (File.Exists(@"../../saves/" + filename+".csv"))
            {
                File.Delete(@"../../saves/"+filename+".csv");
            }
            File.WriteAllText(@"../../saves/"+filename+".csv", csvString);
            clicks.Clear(); // reset list for new save
            //csvString = ""; // reset string for new save
        }

        public List<uint[]> parseClicks()
        {
            object selectedItem = clicksDropdownlist.SelectedItem;
            string usedFile = selectedItem.ToString();
            string fileText = File.ReadAllText(@"../../saves/"+usedFile);
            string[] clickData = fileText.Split(';');
            Array.Resize(ref clickData, clickData.Length - 1);

            List<uint[]> allClickData = new List<uint[]>();
            foreach (var click in clickData)
            {
                string[] temp = click.Split(',');
                uint[] imTired = Array.ConvertAll<string, uint>(temp, uint.Parse);
                uint[] usableClickData = new uint[3];
                usableClickData[0] = imTired[0]; // X coordinates
                usableClickData[1] = imTired[1]; // Y coordinates
                usableClickData[2] = imTired[2]; // click timing
                allClickData.Add(usableClickData);
            }
            return allClickData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // deactivated for debugging purposes
            //WindowState = FormWindowState.Minimized;
            HookManager.MouseClick += new MouseEventHandler(getMouseClickData);
            recordClicks = true;
            watch = Stopwatch.StartNew();
            // start saving click positions and timings
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recordClicks = false;
            watch.Stop();
            writeToCsv();
            getFiles();
            setFiles();
        }

        private async void hammertimeButton_Click(object sender, EventArgs e)
        {
            List<uint[]> allClickData = parseClicks();
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

                SetCursorPos((int)x, (int)y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
        }

        // debug only start
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.Red)
                label1.BackColor = Color.Green;
            else
                label1.BackColor = Color.Red;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.BackColor == Color.Red)
                label2.BackColor = Color.Green;
            else
                label2.BackColor = Color.Red;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.Red)
                label3.BackColor = Color.Green;
            else
                label3.BackColor = Color.Red;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.BackColor == Color.Red)
                label5.BackColor = Color.Green;
            else
                label5.BackColor = Color.Red;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.BackColor == Color.Red)
                label6.BackColor = Color.Green;
            else
                label6.BackColor = Color.Red;
        }
        // debug only end
    }
}
