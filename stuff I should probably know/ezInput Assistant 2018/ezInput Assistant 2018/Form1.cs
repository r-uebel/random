using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ezInput_Assistant_2018
{
    public partial class Form1 : Form
    {

        public static string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void changefileMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = Convert.ToString(wordTextBox.Text);
            string wordtype = Convert.ToString(wordtypeTextBox.Text);
            string wordtext = Convert.ToString(wordtextTextBox.Text);

            string line1 = word + ",,," + wordtype;
            string line2 = wordtext;
            string line3 = "----------";

            if (line1 != "" && line2 != "" && line3 != "") {
                using (StreamWriter file = new StreamWriter(filename, true))
                { // absolut keinen plan warum using hier nen scope bekommt
                    file.WriteLine(line1);
                    file.WriteLine(line2);
                    file.WriteLine(line3);
                }

                line1 = "";
                line2 = "";
                line3 = "";
                wordTextBox.Text = "";
                wordtypeTextBox.Text = "";
                wordtextTextBox.Text = "";
            }
        }
    }
}
