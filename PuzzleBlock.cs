using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    class PuzzleBlock : Button

    {
        public PuzzleBlock()
        {
            InitializePuzzleBlock();
        }

        private void InitializePuzzleBlock()
        {
            this.BackColor = Color.LightSteelBlue;
            this.Height = 100;
            this.Width = 100;
            this.Text = "0";
            this.Font = new Font( "Romantic", 18);
            
        }


        
    }
}
