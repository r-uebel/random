using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // insert names
            beard1label.Text = beard1.Name;
            beard2label.Text = beard2.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            resetDialogueBoxes();
            affectBeard = 0; // change which npc will be affected with next click, 0 = none (disallows repeated presses on yes / no, so the player cannot skip steps)
            updateAffections();
            checkForEnding();
        }

        private void box0_0_Click(object sender, EventArgs e)
        {
            // update the actively shown text for the main dialoguebox
            if (beard1.Affection >= 100)
            {
                beard1.Activetext = "DONE 1";
            }
            else if (beard1.Affection >= 66)
            {
                beard1.Activetext = beard1.Text3;
            }
            else if (beard1.Affection >= 33)
            {
                beard1.Activetext = beard1.Text2;
            }
            else
            {
                beard1.Activetext = beard1.Text1;
            }
            // insert new text into main dialoguebox
            dialogueBox.Text = beard1.Activetext;
            affectBeard = 1; // change which npc will be affected with next click, 1 = beard1
            updateYesNoDialogueBoxes();
            updateAffections();
            checkForEnding();
        }

        private void box3_5_Click(object sender, EventArgs e)
        {
            // update the actively shown text for the main dialoguebox
            if (beard2.Affection >= 100)
            {
                beard2.Activetext = "DONE 2";
            }
            else if (beard2.Affection >= 66)
            {
                beard2.Activetext = beard2.Text3;
            }
            else if (beard2.Affection >= 33)
            {
                beard2.Activetext = beard2.Text2;
            }
            else
            {
                beard2.Activetext = beard2.Text1;
            }
            // insert new text into main dialoguebox
            dialogueBox.Text = beard2.Activetext;
            affectBeard = 2; // change which npc will be affected with next click, 2 = beard2
            updateYesNoDialogueBoxes();
            updateAffections();
            checkForEnding();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // check which npc will be affected
            if (affectBeard == 1)
            {
                if (beard1.Affection < 100)
                    beard1.raiseAffection(10);
            }
            else if (affectBeard == 2)
            {
                if (beard2.Affection < 100)
                    beard2.raiseAffection(10);
            }
            affectBeard = 0; // change which npc will be affected with next click, 0 = none (disallows repeated presses on yes / no, so the player cannot skip steps)
            resetDialogueBoxes();
            updateAffections();
            checkForEnding();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (affectBeard == 1)
            {
                if (beard1.Affection > 0)
                    beard1.lowerAffection(10);
            }
            else if (affectBeard == 2)
            {
                if (beard2.Affection > 0)
                    beard2.lowerAffection(10);
            }
            affectBeard = 0; // change which npc will be affected with next click, 0 = none (disallows repeated presses on yes / no, so the player cannot skip steps)
            resetDialogueBoxes();
            updateAffections();
            checkForEnding();
        }


        // essential administration functions
        public void updateAffections() // updates affectionlabels with currently saved values
        {
            affectionLabel1.Text = Convert.ToString(beard1.Affection);
            affectionLabel2.Text = Convert.ToString(beard2.Affection);
        }
        public void resetDialogueBoxes() // resets dialogueboxes
        {
            dialogueBox.Text = "-----";
            yesLabel.Text = "-----";
            noLabel.Text = "-----";
        }
        public void updateYesNoDialogueBoxes() // update yes and no Labels to show that a choice is available
        {
            yesLabel.Text = "JA";
            noLabel.Text = "NEIN";
        }
        public void checkForEnding() // check if ending dialogue should be inserted
        {
            if (beard1.Affection >= 100 && beard2.Affection >= 100)
            {
                dialogueBox.Text = "ENDE YAY"; // generic end text, mainly for debug purposes
            }
        }
    }
}
