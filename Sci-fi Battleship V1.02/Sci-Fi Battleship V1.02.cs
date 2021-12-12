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
            if (PlayerPositionButtons.Count > 0)
            {
                int Index = rand.Next(PlayerPositionButtons.Count);
                if ((string)PlayerPositionButtons[Index].Tag == "Player Ship")
                {
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    txtEnemyS.Text = enemyScore.ToString();
                    EnemyPlayTimer.Stop();
                }
                else
                {
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.missIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    PlayerPositionButtons.RemoveAt(Index);
                    EnemyPlayTimer.Stop();
                }
            }
            
           if (enemyScore > 2 || playerScore > 2)
            {
                SoundPlayer Victory = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\Star Trek Legacy - Federation Stinger.wav");
                SoundPlayer Defeat = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\Star Trek Legacy - Federation Ship Lost.wav");

                if (playerScore > enemyScore)
                {
                    Victory.Play();
                    MessageBox.Show("You Win!", "Victory");
                    RestartGame();
                }
                else if (playerScore < enemyScore)
                {
                    Defeat.Play();
                    MessageBox.Show("You Lose!", "Defeat");
                    RestartGame();
                }
                else if (playerScore == enemyScore)
                {
                    MessageBox.Show("It's a tie!", "Tie");
                    RestartGame();
                }
            } 
            

        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            SoundPlayer unable = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\input_failed_clean.wav");
            if (ELocLB.Text != "")
            {
                var AttackPosition = ELocLB.Text.ToLower();
                int index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);

                if (EnemyPositionButtons[index].Enabled)
                {

                    if ((string)EnemyPositionButtons[index].Tag == "Enemy Ship")
                    {
                        EnemyPositionButtons[index].Enabled = false;
                        EnemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                        EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtPlayerS.Text = playerScore.ToString();
                        EnemyPlayTimer.Start();
                    }
                    else
                    {
                        EnemyPositionButtons[index].Enabled = false;
                        EnemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                        EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPlayTimer.Start();
                    }
                }
            }
            else
            {
                unable.Play();
                MessageBox.Show("Choose a position to attack from the drop down box.", "Help");
            }

            if (enemyScore > 2 || playerScore > 2)
            {
                SoundPlayer Victory = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\Star Trek Legacy - Federation Stinger.wav");
                SoundPlayer Defeat = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\Star Trek Legacy - Federation Ship Lost.wav");

                if (playerScore > enemyScore)
                {
                    Victory.Play();
                    EnemyPlayTimer.Stop();
                    MessageBox.Show("You Win!", "Victory");
                    
                    RestartGame();
                }
                else if (playerScore < enemyScore)
                {
                    Defeat.Play();
                    EnemyPlayTimer.Stop();
                    MessageBox.Show("You Lose!", "Defeat");
                    RestartGame();
                }
                else if (playerScore == enemyScore)
                {
                    MessageBox.Show("It's a tie!", "Tie");
                    RestartGame();
                }
            }
        }

        private void PlayerPositonEvent(object sender, EventArgs e)
        {
            SoundPlayer select = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.02\Resources\keyok6.wav");
            if (totalShips > 0)
            {
                var button = (Button)sender;
                select.Play();
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
            totalShips = 3;
            txtPlayerS.Text = playerScore.ToString();
            txtEnemyS.Text = enemyScore.ToString();
            EnemyAttack.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();

        }

    }
}
