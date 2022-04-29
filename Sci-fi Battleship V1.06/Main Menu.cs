using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sci_fi_Battleship
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }


        private void LoadGameSelect(object sender, EventArgs e)
        {
            Game_Select selectWindow = new Game_Select();

            selectWindow.Show();
        }
    }
}
