using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace Sci_fi_Battleship
{
    public partial class Form1 : Form
    {

        List<Button> PlayerPositionButtons;
        List<Button> EnemyPositionButtons;

        Random rand = new Random();
        int totalShips = 3;
        int Round = 10;
        int playerScore;
        int enemyScore;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void txtPlayerS_Click(object sender, EventArgs e)
        {

        }

        private void txtHelp_Click(object sender, EventArgs e)
        {

        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {

        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            if (ELocLB.Text != "")
            {
                var AttackPosition = ELocLB.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Choose a position to attack from the drop down box.", "Help");
            }
        }

        private void PlayerPositonEvent(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "Player Ship";
                button.BackColor = Color.Orange;
                totalShips -= 1;
                if (totalShips == 0)
                {
                    btnAttack.Enabled = true;
                    btnAttack.BackColor = Color.Red;
                    btnAttack.ForeColor = Color.White;
                    txtHelp.Text = "2. Pick a positon to attack from the drop down box.";
                }
            }
        }

        private void enemyLocationPicker()
        {
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(EnemyPositionButtons.Count);
                if (EnemyPositionButtons[index].Enabled == true && (string)EnemyPositionButtons[index].Tag == null)
                {
                    EnemyPositionButtons[index].Tag = "Enemy Ship";
                    Debug.WriteLine("Enemy Position: " + EnemyPositionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(EnemyPositionButtons.Count);
                }
            }
        }

        private void RestartGame()
        {
            PlayerPositionButtons = new List<Button> { w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            EnemyPositionButtons = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };

            ELocLB.Items.Clear();

            ELocLB.Text = null;
            txtHelp.Text = "1. Click on 3 different locations above to start";

            for (int i = 0; i < EnemyPositionButtons.Count; i++)
            {
                EnemyPositionButtons[i].Enabled = true;
                EnemyPositionButtons[i].Tag = null;
                EnemyPositionButtons[i].BackColor = Color.White;
                EnemyPositionButtons[i].BackgroundImage = null;
                ELocLB.Items.Add(EnemyPositionButtons[i].Text);

            }

            for (int i = 0; i < PlayerPositionButtons.Count; i++)
            {
                PlayerPositionButtons[i].Enabled = true;
                PlayerPositionButtons[i].Tag = null;
                PlayerPositionButtons[i].BackColor = Color.White;
                PlayerPositionButtons[i].BackgroundImage = null;
            }
            playerScore = 0;
            enemyScore = 0;
            Round = 10;
            totalShips = 3;
            txtPlayerS.Text = playerScore.ToString();
            txtEnemyS.Text = enemyScore.ToString();
            EnemyAttack.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();

        }

    }
}
