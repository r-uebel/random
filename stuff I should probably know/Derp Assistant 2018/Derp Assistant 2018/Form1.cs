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
using System.Text.RegularExpressions;

namespace Derp_Assistant_2018
{
    public partial class derpassistant : Form
    {
        public static Random rnd = new Random();

        public static int word_index = 0;
        public static int wordtype_index = 1;
        public static int solution_index = 2;
        public static int seperatorline_index = 3; // werde ich wahrscheinlich nicht verwenden, steht hier um spätere verwirrung durch die indexe zu vermeiden.

        public static string filetext;
        public static string[] filetext_array;
        public static int filetext_arraysize;
        public static int file_linecount;

        public static string[] wordarray;
        public static string[] wordtypearray;
        public static string[] solutionarray;

        public static string file = "";
        public static int difficulty = 1; // default: leicht
        public static int playable_rounds = difficulty * 10;
        public static int round = 1;
        public static int index = round - 1;
        public static int points = 0;

        public static List<string> list_of_wrong_answers = new List<string>();

        public derpassistant()
        {
            InitializeComponent();
        }

        private void changefileMenuItem_click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (file != "") // wenn bereits eine datei geladen wurde, alles zurücksetzen.
                {
                    resetall(); // resets... all...
                }

                file = openFileDialog1.FileName;
                try
                {
                    filetext = File.ReadAllText(file);
                    filetext_array = Regex.Split(filetext, ",,,|\n");
                    file_linecount = filetext_array.Length;
                    filetext_arraysize = file_linecount / 4;

                    string[] temp_wordarray = new string[filetext_arraysize];
                    string[] temp_wordtypearray = new string[filetext_arraysize];
                    string[] temp_solutionarray = new string[filetext_arraysize];

                    for (int i = 0; i < filetext_arraysize; i++)
                    {
                        temp_wordarray[i] = filetext_array[word_index];
                        temp_wordtypearray[i] = filetext_array[wordtype_index];
                        temp_solutionarray[i] = filetext_array[solution_index];

                        word_index += 4;
                        wordtype_index += 4;
                        solution_index += 4;
                    }

                    mega_shuffle(temp_wordarray, temp_wordtypearray, temp_solutionarray);
                    wordarray = new string[playable_rounds];
                    wordtypearray = new string[playable_rounds];
                    solutionarray = new string[playable_rounds];

                    for (int i = 0; i < playable_rounds; i++)
                    {
                        wordarray[i] = temp_wordarray[i];
                        wordtypearray[i] = temp_wordtypearray[i];
                        solutionarray[i] = temp_solutionarray[i];
                    }

                } catch { }

            }

        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (round <= playable_rounds)
                {
                    if (wordlabel.Text != "Wort")
                    { // beim ersten buttonclick nicht erhöhen.
                        index++;
                    }

                    wordlabel.Text = wordarray[index];
                    wordtypelabel.Text = wordtypearray[index];
                    solutionlabel.Text = "";



                    nextbutton.Visible = false;
                    showsolutionbutton.Visible = true;
                }else
                {
                    nextbutton.Visible = false;
                    showsolutionbutton.Visible = false;
                    wordlabel.Text = "SPIEL";
                    wordtypelabel.Text = "ZUENDE";
                    pointslabel.Text = Convert.ToString(points);

                    string wrong_answers = "";
                    foreach (string answer in list_of_wrong_answers)
                    {
                        wrong_answers = wrong_answers + answer + ", ";
                    }
                    solutionlabel.Text = "Lernbedarf bei: " + wrong_answers;
                }
            } catch { }
        }

        private void showsolutionbutton_Click(object sender, EventArgs e)
        {
            solutionlabel.Text = solutionarray[index];

            showsolutionbutton.Visible = false;
            yesbutton.Visible = true;
            nobutton.Visible = true;
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            points++;
            round++;
            roundcounterlabel.Text = "Runde: " + round;

            yesbutton.Visible = false;
            nobutton.Visible = false;
            nextbutton.Visible = true;
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            list_of_wrong_answers.Add(wordarray[index]);
            round++;
            roundcounterlabel.Text = "Runde: " + round;

            yesbutton.Visible = false;
            nobutton.Visible = false;
            nextbutton.Visible = true;
        }








        public void resetall()
        {
            wordlabel.Text = "Wort";
            wordtypelabel.Text = "Wortart";
            solutionlabel.Text = "Lösung";
            roundcounterlabel.Text = "Runde: 1";
            pointslabel.Text = "";

            list_of_wrong_answers.Clear();
            list_of_wrong_answers.TrimExcess();

            yesbutton.Visible = false;
            nobutton.Visible = false;
            showsolutionbutton.Visible = false;
            nextbutton.Visible = true;

            word_index = 0;
            wordtype_index = 1;
            solution_index = 2;
            seperatorline_index = 3; // werde ich wahrscheinlich nicht verwenden, steht hier um spätere verwirrung durch die indexe zu vermeiden.

            filetext = "";
            filetext_array = new string[0];
            filetext_arraysize = 0;
            file_linecount = 0;

            wordarray = new string[0];
            wordtypearray = new string[0];
            solutionarray = new string[0];

            file = "";
            difficulty = difficulty; // einstellungen sollen erhalten bleiben.
            playable_rounds = difficulty * 10;
            round = 1;
            index = round - 1;
            points = 0;
        }

        static void shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + rnd.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

        static void mega_shuffle<T>(T[] array, T[] array2, T[] array3) // shuffle x 3, damit alle arrays indexe haben die auch zusammenhängen.
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + rnd.Next(n - i);
                T t = array[r];
                T tt = array2[r];
                T ttt = array3[r];
                array[r] = array[i];
                array[i] = t;
                array2[r] = array2[i];
                array2[i] = tt;
                array3[r] = array3[i];
                array3[i] = ttt;
            }
        }

        private void leichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            playable_rounds = difficulty * 10;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            playable_rounds = difficulty * 10;
        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            playable_rounds = difficulty * 10;
        }
    }

}
