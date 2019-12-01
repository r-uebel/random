using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beardthingV2
{
    public partial class Form1 : Form
    {
        Map map;

        Player player = new Player();
        Npc npc1 = new Npc(0, "larry", 0, getDialog("dialog1.txt"));
        Npc npc2 = new Npc(0, "steve", 15, getDialog("dialog2.txt"));

        public PictureBox[] fields;
        

        public Form1()
        {
            InitializeComponent();
            fields = Controls.OfType<PictureBox>().Where(pbx => pbx.Name.StartsWith("pictureBox")).OrderBy(pbx => pbx.Name).ToArray();
            map = new Map(fields);
            npcLabel1.Text = npc1.name;
            npcLabel2.Text = npc2.name;
            npcPointsLabel1.Text = Convert.ToString(npc1.points);
            npcPointsLabel2.Text = Convert.ToString(npc2.points);
        }

        public bool isMovementPossible (int playerPos, string direction)
        {
            switch (direction)
            {
                case ("up"):
                    if (playerPos == 4 || playerPos == 1 || playerPos == 2 || playerPos == 3)
                        return false;
                    else
                        return true;
                    break;

                case ("right"):
                    if (playerPos == 3 || playerPos == 7 || playerPos == 11 || playerPos == 14)
                        return false;
                    else
                        return true;
                    break;

                case ("down"):
                    if (playerPos == 12 || playerPos == 13 || playerPos == 14 || playerPos == 11)
                        return false;
                    else
                        return true;
                    break;

                case ("left"):
                    if (playerPos == 1 || playerPos == 4 || playerPos == 8 || playerPos == 12)
                        return false;
                    else
                        return true;
                    break;

                default:
                    return false;
                    break;
            }
        }

        public bool isNpcOneClose(int playerPos)
        {
            if (playerPos == 1 || playerPos == 4)
                return true;
            return false;
        }
        public bool isNpcTwoClose(int playerPos)
        {
            if (playerPos == 11 || playerPos == 14)
                return true;
            return false;
        }

        public bool calculatePoints (Npc npc)
        {
            npc.points = npc.points >= 100 ? 100 : npc.points + 5;
            // erweiterbar
            return true;
        }

        public static string[] getDialog(string filename)
        {
            string[] dialog = System.IO.File.ReadAllLines(@"C:\Users\froze\Desktop\beardthingV2\" + filename);

            return dialog;
        }

        public void endDialog(Npc npc)
        {
            npc.inDialog = false;
            npc.dialogDepth = 0;
            player.inDialog = false;
            dialogLabel.Text = "-----";
        }

        public void happyEnding()
        {
            if (npc1.points == 100)
            {
                npc1.points = 0;
                player.playerAvatar = @"\player1beard1.png";
            }
            else if (npc2.points == 100)
            {
                npc2.points = 0;
                player.playerAvatar = @"\player1beard2.png";
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (player.inDialog)
            {
                if (npc1.inDialog == true)
                {
                    if (calculatePoints(npc1))
                    {
                        try
                        {
                            dialogLabel.Text = npc1.dialog[npc1.dialogDepth];
                            npc1.dialogDepth++;
                            npcPointsLabel1.Text = Convert.ToString(npc1.points);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            endDialog(npc1);
                            happyEnding();
                        }
                    }

                }
                if (npc2.inDialog == true)
                {
                    if (calculatePoints(npc2))
                    {
                        try
                        {
                            dialogLabel.Text = npc2.dialog[npc2.dialogDepth];
                            npc2.dialogDepth++;
                            npcPointsLabel2.Text = Convert.ToString(npc2.points);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            endDialog(npc2);
                            happyEnding();
                        }
                    }
                }
            }
            else if (isNpcOneClose(player.playerPos))
            {
                npc1.inDialog = true;
                player.inDialog = true;
                dialogLabel.Text = "Dialog NPC 1 start";

                npc2.inDialog = false;
            }
            else if (isNpcTwoClose(player.playerPos))
            {
                npc2.inDialog = true;
                player.inDialog = true;
                dialogLabel.Text = "Dialog NPC 2 start";

                npc1.inDialog = false;
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (isMovementPossible(player.playerPos, "left"))
            {
                Image myimage = new Bitmap(@"C:\Users\froze\Desktop\beardthingV2" + player.playerAvatar);
                map.fields[player.playerPos].BackgroundImage = null;
                player.playerPos -= 1;
                map.fields[player.playerPos].BackgroundImage = myimage;
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (isMovementPossible(player.playerPos, "down"))
            {
                Image myimage = new Bitmap(@"C:\Users\froze\Desktop\beardthingV2" + player.playerAvatar);
                map.fields[player.playerPos].BackgroundImage = null;
                player.playerPos += 4;
                map.fields[player.playerPos].BackgroundImage = myimage;
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (isMovementPossible(player.playerPos, "right"))
            {
                Image myimage = new Bitmap(@"C:\Users\froze\Desktop\beardthingV2" + player.playerAvatar);
                map.fields[player.playerPos].BackgroundImage = null;
                player.playerPos += 1;
                map.fields[player.playerPos].BackgroundImage = myimage;
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (isMovementPossible(player.playerPos, "up"))
            {
                Image myimage = new Bitmap(@"C:\Users\froze\Desktop\beardthingV2" + player.playerAvatar);
                map.fields[player.playerPos].BackgroundImage = null;
                player.playerPos -= 4;
                map.fields[player.playerPos].BackgroundImage = myimage;
            }
        }
    }
}
