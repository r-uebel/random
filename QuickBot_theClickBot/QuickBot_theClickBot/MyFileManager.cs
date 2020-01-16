using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBot_theClickBot
{
    public class MyFileManager
    {
        public FileInfo[] files;
        public DirectoryInfo dir;
        public string csvString;
        public string filename;

        public MyFileManager()
        {
            this.dir = new DirectoryInfo(@"../../saves");
        }

        public void getFiles()
        {
            files = dir.GetFiles();
        }

        public void setFiles(Form1 form)
        {
            form.clicksDropdownlist.Items.Clear();
            foreach (FileInfo file in files)
            {
                form.clicksDropdownlist.Items.Add(file);
            }
        }

        public void writeToCsv(List<string[]> clicks, Form1 form)
        {
            foreach (var elem in clicks)
            {
                csvString += elem[0] + "," + elem[1] + "," + elem[2] + ";";
            }
            /////
            filename = form.filenameInput.Text == "" ? "ohshit" : form.filenameInput.Text;
            if (File.Exists(@"../../saves/" + filename + ".csv"))
            {
                File.Delete(@"../../saves/" + filename + ".csv");
            }
            File.WriteAllText(@"../../saves/" + filename + ".csv", csvString);
            //clicks.Clear(); // reset list for new save
            //csvString = ""; // reset string for new save
        }
    }
}
