using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beardthingV2
{
    public class Npc
    {
        public int points;
        public string name;
        public int npcPos;
        public string[] dialog;
        public int howMuchDialog;
        public int dialogDepth = 0;
        public bool inDialog = false;

        public Npc(int points, string name, int npcPos, string[] dialog = null)
        {
            this.points = points;
            this.name = name;
            this.npcPos = npcPos;
            this.dialog = dialog;
            this.howMuchDialog = dialog == null ? 0 : dialog.Count();
        }
    }
}
