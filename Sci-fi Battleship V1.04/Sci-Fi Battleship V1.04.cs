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
        List<Button> PlayerSelectionButtons;
        String[] EnemyShipClasses = {  "Enemy Carrier", "Enemy Battleship", "Enemy Cruiser", "Enemy Destroyer", "Enemy Scout"};

        Random rand = new Random();
        int totalShips = 5;
        int pcarrier = 0;
        int pbattleship = 0;
        int pcruiser = 0;
        int pdestroyer = 0;
        int pscout = 0;
        int ecarrier = 0;
        int ebattleship = 0;
        int ecruiser = 0;
        int edestroyer = 0;
        int escout = 0;
        int playerScore;
        int enemyScore;
        int shots = 0;
        bool targeted = false;
        int carrierspecial = 5;
        int battleshipspecial = 4;
        int cruiserspecial = 3;
        int destroyerspecial = 2;
        int scoutspecial = 1;

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
                if ((string)PlayerPositionButtons[Index].Tag == "Player Carrier" || (string)PlayerPositionButtons[Index].Tag == "Player Battleship" || (string)PlayerPositionButtons[Index].Tag == "Player Cruiser" || (string)PlayerPositionButtons[Index].Tag == "Player Destroyer" || (string)PlayerPositionButtons[Index].Tag == "Player Scout")
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
            
           if (enemyScore > 4 || playerScore > 4)
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

                    if ((string)EnemyPositionButtons[index].Tag == "Enemy Carrier" || (string)EnemyPositionButtons[index].Tag == "Enemy Battleship" || (string)EnemyPositionButtons[index].Tag == "Enemy Cruiser" || (string)EnemyPositionButtons[index].Tag == "Enemy Destroyer" || (string)EnemyPositionButtons[index].Tag == "Enemy Scout")
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
            if (enemyScore > 4 || playerScore > 4)
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

        }

        private void enemyLocationPicker()
        {
            int j = 0;
            for (int i = 0; i < 5; i++)
            {
                int index = rand.Next(EnemyPositionButtons.Count);
                if (EnemyPositionButtons[index].Enabled == true && (string)EnemyPositionButtons[index].Tag == null)
                {
                    EnemyPositionButtons[index].Tag = EnemyShipClasses[j];
                    Debug.WriteLine(EnemyShipClasses[j] + " Position: " + EnemyPositionButtons[index].Text);
                    j += 1;
                }
                else
                {
                    index = rand.Next(EnemyPositionButtons.Count);
                }
            }
        }

        private void RestartGame()
        {
            string[] EnemyShipClasses = {  "Enemy Carrier", "Enemy Battleship", "Enemy Cruiser", "Enemy Destroyer", "Enemy Scout"};
            PlayerPositionButtons = new List<Button> { u1, u2, u3, u4, u5, u6, v1, v2, v3, v4, v5, v6, w1, w2, w3, w4, w5, w6, x1, x2, x3, x4, x5, x6, y1, y2, y3, y4, y5, y6, z1, z2, z3, z4, z5, z6};
            EnemyPositionButtons = new List<Button> { a1, a2, a3, a4, a5, a6, b1, b2, b3, b4, b5, b6, c1, c2, c3, c4, c5, c6, d1, d2, d3, d4, d5, d6, e1, e2, e3, e4, e5, e6, f1, f2, f3, f4, f5, f6 };
            PlayerSelectionButtons = new List<Button> { Carrier, Battleship, Cruiser, Destroyer, Scout };
            txtHelp.Text = "1. Click on 5 different locations above to start";


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
            for (int i = 0; i < PlayerSelectionButtons.Count; i++)
            {
                PlayerSelectionButtons[i].Enabled = true;
            }
            playerScore = 0;
            enemyScore = 0;
            totalShips = 5;
            pcarrier = 0;
            pbattleship = 0;
            pcruiser = 0;
            pdestroyer = 0;
            pscout = 0;
            ecarrier = 1;
            ebattleship = 0;
            ecruiser = 0;
            edestroyer = 0;
            escout = 0;
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

        private void PlayerPositionEvent(object sender, EventArgs e)
        {
            if (totalShips > 0 )
            {
                if (pcarrier > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Carrier";
                    button.BackgroundImage = Properties.Resources.FedCarrier;
                    totalShips -= 1;
                    pcarrier -= 1;
                }
                if (pbattleship > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Battleship";
                    button.BackgroundImage = Properties.Resources.FedBattleship;
                    totalShips -= 1;
                    pbattleship -= 1;
                }
                if (pcruiser > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Cruiser";
                    button.BackgroundImage = Properties.Resources.FedCruiser;
                    totalShips -= 1;
                    pcruiser -= 1;
                }
                if (pdestroyer > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Destroyer";
                    button.BackgroundImage = Properties.Resources.FedDestroyer;
                    totalShips -= 1;
                    pdestroyer -= 1;
                }
                if (pscout > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Scout";
                    button.BackgroundImage = Properties.Resources.FedScout;
                    totalShips -= 1;
                    pscout -= 1;
                }
                //var button = (Button)sender;
                //select.Play();
                //button.Enabled = false;
                //button.Tag = "Player Ship";
                //button.BackColor = Color.Orange;
                //totalShips -= 1;
                if (totalShips == 0)
                {
                    btnAttack.Enabled = true;
                    txtHelp.Text = "2. Select a position to attack from the enemy's board.";
                }

            }
        }

        private void ShipSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.BackColor = Color.Orange;

        }

        private void Ship2ASelect(object sender, EventArgs e)
        {

        }

        private void Ship2BSelect(object sender, EventArgs e)
        {

        }

        private void Ship1Select(object sender, EventArgs e)
        {

        }

        private void Deselectattack(object sender, EventArgs e)
        {

        }

        private void BattleshipSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.Enabled = false;
            pbattleship += 1;
        }

        private void CruiserSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.Enabled = false;
            pcruiser += 1;
        }

        private void CarrierSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.Enabled = false;
            pcarrier += 1;
        }

        private void DestroyerSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.Enabled = false;
            pdestroyer += 1;
        }

        private void ScoutSelect(object sender, EventArgs e)
        {
            select.Play();
            var sbutton = (Button)sender;
            sbutton.Enabled = false;
            pscout += 1;
        }
    }
}
