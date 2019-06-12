using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class NonPlayerCharacter
    {
        // attributes
        private string name; // name of npc
        private int affection; // simple point value to determine currently displayed text in dialoguebox
        private string text1; // first text for dialoguebox
        private string text2; // second text for dialoguebox
        private string text3; // third text for dialoguebox 

        private string activetext;

        // getter setter
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Affection
        {
            get
            {
                return affection;
            }

            set
            {
                affection = value;
            }
        }

        public string Text1
        {
            get
            {
                return text1;
            }

            set
            {
                text1 = value;
            }
        }

        public string Text2
        {
            get
            {
                return text2;
            }

            set
            {
                text2 = value;
            }
        }

        public string Text3
        {
            get
            {
                return text3;
            }

            set
            {
                text3 = value;
            }
        }

        public string Activetext
        {
            get
            {
                return activetext;
            }

            set
            {
                activetext = value;
            }
        }

        // constructor
        public NonPlayerCharacter(string name, string text1 = "Hallo1", string text2 = "Hallo2", string text3 = "Hallo3", int affection = 0)
        {
            this.Name = name;
            this.Affection = affection;
            this.Text1 = text1;
            this.Text2 = text2;
            this.Text3 = text3;
            this.Activetext = this.text1;
        }

        // methods
        public void raiseAffection(int plus = 10)
        {
            this.affection += plus;
        }

        public void lowerAffection(int minus = 10)
        {
            this.affection -= minus;
        }
    }
}
