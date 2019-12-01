using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beardthingV2
{
    public class Map
    {
        ///////////////////// Map start
        public string test;
        public PictureBox[] fields;

        public Map(PictureBox[] fields)
        {
            if (fields != null)
            {
                this.fields = fields;
            }
        }
        ///////////////////// Map ende
    }
}
