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
    public partial class Game_Select : Form
    {
        public Game_Select()
        {
            InitializeComponent();
        }

        private void LoadStandardGame(object sender, EventArgs e)
        {
            StandardGame NewGame = new StandardGame();

            NewGame.Show();
        }

        private void LoadAdvancedGame(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not been programmed in yet.", "Help");
        }
    }
}
