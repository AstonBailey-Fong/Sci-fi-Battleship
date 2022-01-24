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
using WMPLib;
using System.Threading;
using System.Timers;

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
        int shots = 0;
        bool targeted = false;
        WindowsMediaPlayer background = new WindowsMediaPlayer();
        SoundPlayer Victory = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\Star Trek Legacy - Federation Stinger.wav");
        SoundPlayer Defeat = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\Star Trek Legacy - Federation Ship Lost.wav");
        SoundPlayer select = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\keyok6.wav");
        SoundPlayer unable = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\input_failed_clean.wav");
        SoundPlayer playerfire = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\tng_phaser4_clean_top.wav");
        SoundPlayer enemyfire = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\tng_disruptor_clean.wav");
        SoundPlayer playerhit = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\largeexplosion2.wav");
        SoundPlayer enemyhit = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\largeexplosion3.wav");
        SoundPlayer miss = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\smallexplosion3.wav");
        
        public Form1()
        {
            InitializeComponent();
            background.URL = "Federation Ambient Theme.mp3";
            background.settings.autoStart = true;
            background.settings.setMode("loop", true);
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
            Thread.Sleep(3000);
            enemyfire.Play();
            Thread.Sleep(3000);
            if (PlayerPositionButtons.Count > 0)
            {
                int Index = rand.Next(PlayerPositionButtons.Count);
                if ((string)PlayerPositionButtons[Index].Tag == "Player Ship")
                {
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                }
                else
                {
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.missIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    miss.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    EnemyPlayTimer.Stop();
                }
            }
            
           if (enemyScore > 2 || playerScore > 2)
            {
                Thread.Sleep(3000);
                EnemyPlayTimer.Stop();
                background.controls.stop();
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
            if (EnemyLocation.Text != "Blank")
            {
                var AttackPosition = EnemyLocation.Text.ToLower();
                shots = 0;
                int index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                if (((string)EnemyPositionButtons[index].Tag == "Sunk") || ((string)EnemyPositionButtons[index].Tag == "Missed"))
                {
                    unable.Play();
                    MessageBox.Show("You have already attacked this position!", "Help");
                }
                else
                {
                    playerfire.Play();
                    Thread.Sleep(3000);
                }
                if (EnemyPositionButtons[index].Enabled)
                {

                    if ((string)EnemyPositionButtons[index].Tag == "Enemy Ship")
                    {
                        EnemyPositionButtons[index].Enabled = false;
                        EnemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                        EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPositionButtons[index].Tag = "Sunk";
                        playerScore += 1;
                        playerhit.Play();
                        btnAttack.BackColor = Color.White;
                        btnAttack.ForeColor = Color.Black;
                    }
                    else
                    {
                        EnemyPositionButtons[index].Enabled = false;
                        EnemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                        EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                        miss.Play();
                        EnemyPositionButtons[index].Tag = "Missed";
                        EnemyPlayTimer.Start();
                        btnAttack.BackColor = Color.White;
                        btnAttack.ForeColor = Color.Black;
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
                Thread.Sleep(3000);
                background.controls.stop();
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
            PlayerPositionButtons = new List<Button> { u1, u2, u3, u4, u5, u6, v1, v2, v3, v4, v5, v6, w1, w2, w3, w4, w5, w6, x1, x2, x3, x4, x5, x6, y1, y2, y3, y4, y5, y6, z1, z2, z3, z4, z5, z6};
            EnemyPositionButtons = new List<Button> { a1, a2, a3, a4, a5, a6, b1, b2, b3, b4, b5, b6, c1, c2, c3, c4, c5, c6, d1, d2, d3, d4, d5, d6, e1, e2, e3, e4, e5, e6, f1, f2, f3, f4, f5, f6 };
            txtHelp.Text = "1. Click on 3 different locations above to start";


            for (int i = 0; i < EnemyPositionButtons.Count; i++)
            {
                EnemyPositionButtons[i].Enabled = true;
                EnemyPositionButtons[i].Tag = null;
                EnemyPositionButtons[i].BackColor = Color.White;
                EnemyPositionButtons[i].BackgroundImage = null;

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
            shots = 0;
            targeted = false;
            EnemyAttack.Text = "A1";
            background.controls.play();
            btnAttack.Enabled = false;
            btnAttack.BackColor = Color.White;
            btnAttack.ForeColor = Color.Black;
            enemyLocationPicker();

        }

        private void AttackSelectionEvent(object sender, EventArgs e)
        {
            var button = (Button)sender;
            select.Play();
            int Index = EnemyPositionButtons.Count;
            if (shots > 0) 
            {
                unable.Play();
                MessageBox.Show("You cannot make another choice until your next turn.", "Help");
            }
            else
            {
                
                EnemyLocation.Text = button.Text;
                button.BackgroundImage = Properties.Resources.target;
                shots = 1;
                targeted = true;
                btnAttack.BackColor = Color.Red;
                btnAttack.ForeColor = Color.White;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }
    }
}
