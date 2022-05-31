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
using Microsoft.VisualBasic;

namespace Sci_fi_Battleship
{
    public partial class StandardGame : Form
    {

        List<Button> PlayerPositionButtons;
        List<Button> EnemyPositionButtons;
        List<Button> PlayerSelectionButtons;
        List<Button> SpecialAbilityButtons;
        String[] EnemyShipClasses = {  "Enemy Carrier", "Enemy Battleship", "Enemy Cruiser", "Enemy Destroyer", "Enemy Scout"};
        String[] tspreadtargets = { "Blank", "Blank", "Blank" };
        String[] battleshiptargets = { "Blank", "Blank", "Blank", "Blank", "Blank" };
        String[] carriertargets = { "Blank", "Blank", "Blank", "Blank", "Blank", "Blank"};
        String[] EnemyShipPositions = { "Blank", "Blank", "Blank", "Blank", "Blank" };
        String[] EnemyPositions = { "A1", "A2", "A3" , "A4", "A5", "A6", "B1", "B2", "B3", "B4", "B5", "B6", "C1", "C2", "C3", "C4", "C5", "C6", "D1", "D2", "D3", "D4", "D5", "D6", "E1", "E2", "E3", "E4", "E5", "E6", "F1", "F2", "F3", "F4", "F5", "F6"};
        Random rand = new Random();
        int totalShips = 5;
        int pcarrier = 0;
        int pbattleship = 0;
        int pcruiser = 0;
        int pdestroyer = 0;
        int pscout = 0;
        int playerScore;
        int enemyScore;
        int shots = 0;
        int crshots = 0;
        int carrierspecial = 5;
        int battleshipspecial = 4;
        int cruiserspecial = 3;
        int destroyerspecial = 2;
        int scoutspecial = 1;
        bool crspecial = false;
        string AttackPosition;
        int torpspread = 0;
        bool caspecial = false;
        bool baspecial = false;
        string TricobaltTarget;
        int tritarg = 0;
        bool pcarrieralive = true;
        bool pbattleshipalive = true;
        bool pcruiseralive = true;
        bool pdestroyeralive = true;
        bool pscoutalive = true;
        bool hittarget;
        int catargets = 0;
        bool scspecial = false;
        bool despecial = false;
        string caspecialname;
        string baspecialname;
        string crspecialname;
        string despecialname;
        string scspecialname;

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
        SoundPlayer cruiserfire = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.05\Resources\tng_torpedo_clean.wav");
        SoundPlayer battleshipfire = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.05\Resources\quantumtorpedoes.wav");
        SoundPlayer tricobalt = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.05\Resources\largeexplosion1.wav");
        SoundPlayer fighter = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.05\Resources\pulse.WAV");
        SoundPlayer homing = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.05\Resources\quantumtorpeodoes2.wav");
        public StandardGame(string Player_Faction, string Enemy_Faction)
        {
            InitializeComponent();
            PlayerFaction.Text = "Player Faction: " + Player_Faction;
            EnemyFaction.Text = "Enemy Faction: " + Enemy_Faction;
            if (Player_Faction == "UFP")
            {
                background.URL = "Federation Ambient Theme.mp3";
            }
            if (Player_Faction == "KlE")
            {
                background.URL = "Klingon Ambient Theme.mp3";
            }
            if (Player_Faction == "RSE")
            {
                background.URL = "Romulan Ambient Theme.mp3";
            }
            if (Player_Faction == "DoA")
            {
                background.URL = "Borg Ambient Theme.mp3";
            }
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
            hittarget = false;
            crshots = 0;
            tritarg = 0;
            torpspread = 0;
            catargets = 0;
            String[] tspreadtargets = { "Blank", "Blank", "Blank" };
            String[] battleshiptargets = { "Blank", "Blank", "Blank", "Blank", "Blank" };
            String[] carriertargets = { "Blank", "Blank", "Blank", "Blank", "Blank", "Blank" };
            int Index = rand.Next(PlayerPositionButtons.Count);
            if (PlayerPositionButtons.Count > 0)
            {
                if ((string)PlayerPositionButtons[Index].Tag == "Player Carrier")
                {
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].BackgroundImage = Properties.Resources.missIcon;
                    pcarrieralive = false;
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    hittarget = true;

                }
                if ((string)PlayerPositionButtons[Index].Tag == "Player Battleship")
                {
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].BackgroundImage = Properties.Resources.missIcon;
                    pbattleshipalive = false;
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    hittarget = true;

                }
                if ((string)PlayerPositionButtons[Index].Tag == "Player Cruiser")
                {
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].BackgroundImage = Properties.Resources.missIcon;
                    pcruiseralive = false;
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    hittarget = true;

                }
                if ((string)PlayerPositionButtons[Index].Tag == "Player Destroyer")
                {
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].BackgroundImage = Properties.Resources.missIcon;
                    pdestroyeralive = false;
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    hittarget = true;

                }
                if ((string)PlayerPositionButtons[Index].Tag == "Player Scout")
                {
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].BackgroundImage = Properties.Resources.missIcon;
                    pscoutalive = false;
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.fireIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    enemyhit.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    enemyScore += 1;
                    hittarget = true;
                }
                if ((string)PlayerPositionButtons[Index].Tag == null && hittarget !=true)
                {
                    PlayerPositionButtons[Index].BackgroundImage = Properties.Resources.missIcon;
                    EnemyAttack.Text = PlayerPositionButtons[Index].Text;
                    PlayerPositionButtons[Index].Enabled = false;
                    PlayerPositionButtons[Index].BackColor = Color.DarkBlue;
                    miss.Play();
                    PlayerPositionButtons.RemoveAt(Index);
                    SpecialAbilityCooldown.Start();
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
            if (EnemyLocation.Text != "Blank" && scspecial == false && despecial == false)
            {
                AttackPosition = EnemyLocation.Text.ToLower();
                shots = 0;
                int index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                if (caspecial == true)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        fighter.Play();
                        Thread.Sleep(600);
                    }
                    Thread.Sleep(400);
                    do
                    {
                        AttackPosition = carriertargets[catargets].ToLower();
                        index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                        if ((string)EnemyPositionButtons[index].Tag == "Enemy Carrier" || (string)EnemyPositionButtons[index].Tag == "Enemy Battleship" || (string)EnemyPositionButtons[index].Tag == "Enemy Cruiser" || (string)EnemyPositionButtons[index].Tag == "Enemy Destroyer" || (string)EnemyPositionButtons[index].Tag == "Enemy Scout")
                        {
                            EnemyPositionButtons[index].Enabled = false;
                            EnemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                            EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                            EnemyPositionButtons[index].Tag = "Sunk";
                            playerScore += 1;
                            tricobalt.Play();
                            btnAttack.BackColor = Color.White;
                            btnAttack.ForeColor = Color.Black;
                            if (caspecial == true && catargets < 6)
                            {
                                catargets += 1;
                            }

                        }
                        else
                        {
                            EnemyPositionButtons[index].Enabled = false;
                            EnemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                            EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                            tricobalt.Play();
                            EnemyPositionButtons[index].Tag = "Missed";
                            btnAttack.BackColor = Color.White;
                            btnAttack.ForeColor = Color.Black;
                            if (caspecial == true && catargets < 6)
                            {
                                catargets += 1;
                            }
                        }
                    } while (catargets < 6);
                    if (catargets == 6)
                    {
                        EnemyPlayTimer.Start();
                    }
                }
                if (crspecial == true)
                {
                    do
                    {
                        AttackPosition = tspreadtargets[torpspread].ToLower();
                        index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                        cruiserfire.Play();
                        Thread.Sleep(1000);
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
                                if (crspecial == true && torpspread < 3)
                                {
                                    torpspread += 1;
                                    Thread.Sleep(3000);
                                }

                            }
                            else
                            {
                                EnemyPositionButtons[index].Enabled = false;
                                EnemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                                EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                                miss.Play();
                                EnemyPositionButtons[index].Tag = "Missed";
                                btnAttack.BackColor = Color.White;
                                btnAttack.ForeColor = Color.Black;
                                if (crspecial == true && torpspread < 3)
                                {
                                    torpspread += 1;
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                    } while (torpspread < 3);
                    if (torpspread == 3)
                    {
                        EnemyPlayTimer.Start();
                    }
                }
                if (baspecial == true)
                {
                    battleshipfire.Play();
                    Thread.Sleep(2000);
                    do
                    {
                        AttackPosition = battleshiptargets[tritarg].ToLower();
                        shots = 0;
                        index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                        if ((string)EnemyPositionButtons[index].Tag == "Enemy Carrier" || (string)EnemyPositionButtons[index].Tag == "Enemy Battleship" || (string)EnemyPositionButtons[index].Tag == "Enemy Cruiser" || (string)EnemyPositionButtons[index].Tag == "Enemy Destroyer" || (string)EnemyPositionButtons[index].Tag == "Enemy Scout")
                        {
                            EnemyPositionButtons[index].Enabled = false;
                            EnemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                            EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                            EnemyPositionButtons[index].Tag = "Sunk";
                            playerScore += 1;
                            tricobalt.Play();
                            btnAttack.BackColor = Color.White;
                            btnAttack.ForeColor = Color.Black;
                            if (baspecial == true && tritarg < 5)
                            {
                                tritarg += 1;
                            }

                        }
                        else
                        {
                            EnemyPositionButtons[index].Enabled = false;
                            EnemyPositionButtons[index].BackgroundImage = Properties.Resources.missIcon;
                            EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                            tricobalt.Play();
                            EnemyPositionButtons[index].Tag = "Missed";
                            btnAttack.BackColor = Color.White;
                            btnAttack.ForeColor = Color.Black;
                            if (baspecial == true && tritarg < 5)
                            {
                                tritarg += 1;
                            }
                        }
                    } while (tritarg < 5);
                    if (tritarg == 5)
                    {
                        Thread.Sleep(2500);
                        EnemyPlayTimer.Start();
                    }

                }
                if (crspecial != true && baspecial != true && caspecial != true)
                {
                    if (((string)EnemyPositionButtons[index].Tag == "Sunk") || ((string)EnemyPositionButtons[index].Tag == "Missed"))
                    {
                        unable.Play();
                        MessageBox.Show("You have already attacked this position!", "Help");
                    }
                    playerfire.Play();
                    Thread.Sleep(3000);
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
                            Thread.Sleep(2500);
                        }
                    }

                }
            }
            if (scspecial == true)
            {
                int i = rand.Next(EnemyShipPositions.Length);
                MessageBox.Show("There is an enemy starship at: " + EnemyShipPositions[i], "Sensor Scan results");
                shots = 0;
                EnemyPlayTimer.Start();
            }
            if (despecial == true)
            {
                int i = rand.Next(EnemyShipPositions.Length);
                AttackPosition = EnemyShipPositions[i].ToLower();
                int index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
                homing.Play();
                Thread.Sleep(3000);
                EnemyPositionButtons[index].Enabled = false;
                EnemyPositionButtons[index].BackgroundImage = Properties.Resources.fireIcon;
                EnemyPositionButtons[index].BackColor = Color.DarkBlue;
                EnemyPositionButtons[index].Tag = "Sunk";
                playerScore += 1;
                playerhit.Play();
                btnAttack.BackColor = Color.White;
                btnAttack.ForeColor = Color.Black;
                EnemyPlayTimer.Start();
            }
            if(EnemyLocation.Text == "Blank" && scspecial == false && despecial == false)
            {
                unable.Play();
                MessageBox.Show("Choose a position to attack from the enemy's board.", "Help");
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
            for (int i = 0; i < 5; i++)
            {
                int index = rand.Next(EnemyPositionButtons.Count);
                if (EnemyPositionButtons[index].Enabled == true && (string)EnemyPositionButtons[index].Tag == null)
                {
                    EnemyPositionButtons[index].Tag = EnemyShipClasses[i];
                    Debug.WriteLine(EnemyShipClasses[i] + " Position: " + EnemyPositionButtons[index].Text);
                    EnemyShipPositions[i] = EnemyPositionButtons[index].Text;
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
            SpecialAbilityButtons = new List<Button> { CarrierSpecialB, BattleshipSpecialB, CruiserSpecialB, DestroyerSpecialB, ScoutSpecialB };
            txtHelp.Text = "Select the ship you want to place down, then select where you want it to go on the board.";
            if (PlayerFaction.Text == "Player Faction: UFP")
            {
                CarrierName.Text = "Excalibur Class\nCarrier";
                BattleshipName.Text = "Sovereign Class\nBattleship";
                CruiserName.Text = "Akira Class\nCruiser";
                DestroyerName.Text = "Defiant Class\nDestroyer";
                ScoutName.Text = "Nova Class\nScout";
                caspecialname = "Peregrine Strike";
                baspecialname = "Tricobalt Device";
                crspecialname = "Torpedo Spread";
                despecialname = "Homing Torpedo";
                scspecialname = "Sensor Scan";
                Carrier.Image = Properties.Resources.FedCarrierDisplay;
                Battleship.Image = Properties.Resources.FedBattleshipDisplay;
                Cruiser.Image = Properties.Resources.FedCruiserDisplay;
                Destroyer.Image = Properties.Resources.FedDestroyerDisplay;
                Scout.Image = Properties.Resources.FedScoutDisplay;
            }
            if (PlayerFaction.Text == "Player Faction: KlE")
            {
                CarrierName.Text = "Negh'Var Class\nCommand Battleship";
                BattleshipName.Text = "Vor'cha Class\nBattleship";
                CruiserName.Text = "K'Tinga Class\nCruiser";
                DestroyerName.Text = "Koral Class\nDestroyer";
                ScoutName.Text = "B'Rel Class\nScout";
                caspecialname = "Disruptor Strike";
                baspecialname = "Tricobalt Device";
                crspecialname = "Torpedo Spread";
                despecialname = "Homing Torpedo";
                scspecialname = "Sensor Scan";
                Carrier.Image = Properties.Resources.KliCarrierDisplay;
                Battleship.Image = Properties.Resources.KliBattleshipDisplay;
                Cruiser.Image = Properties.Resources.KliCruiserDisplay;
                Destroyer.Image = Properties.Resources.KliDestroyerDisplay;
                Scout.Image = Properties.Resources.KliScoutDisplay;
            }
            if (PlayerFaction.Text == "Player Faction: RSE")
            {
                CarrierName.Text = "Scimitar Class\nHeavy Warbird";
                BattleshipName.Text = "D'Deridex Class\nWarbird";
                CruiserName.Text = "Valdore Class\nCruiser";
                DestroyerName.Text = "Vas Deletham Class\nDestroyer";
                ScoutName.Text = "Talon Class\nScout";
                caspecialname = "Scorpion Strike";
                baspecialname = "Tricobalt Device";
                crspecialname = "Torpedo Spread";
                despecialname = "Homing Torpedo";
                scspecialname = "Sensor Scan";
                Carrier.Image = Properties.Resources.RomCarrierDisplay;
                Battleship.Image = Properties.Resources.RomBattleshipDisplay;
                Cruiser.Image = Properties.Resources.RomCruiserDisplay;
                Destroyer.Image = Properties.Resources.RomDestroyerDisplay;
                Scout.Image = Properties.Resources.RomScoutDisplay;
            }
            if (PlayerFaction.Text == "Player Faction: DoA")
            {
                CarrierName.Text = "Cychreides Class\nDreadnought";
                BattleshipName.Text = "Mantis Class\nBattleship";
                CruiserName.Text = "Galor Clss\nCruiser";
                DestroyerName.Text = "Scarab Class\nAttack Craft";
                ScoutName.Text = "Hideki Class\nScout";
                caspecialname = "Scarab Strike";
                baspecialname = "Polaron Torpedo";
                crspecialname = "Torpedo Spread";
                despecialname = "Homing Torpedo";
                scspecialname = "Sensor Scan";
                Carrier.Image = Properties.Resources.DomCarrierDisplay;
                Battleship.Image = Properties.Resources.DomBattleshipDisplay;
                Cruiser.Image = Properties.Resources.DomCruiserDisplay;
                Destroyer.Image = Properties.Resources.DomDestroyerDisplay;
                Scout.Image = Properties.Resources.DomScoutDisplay;
            }

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
            for (int i = 0; i < SpecialAbilityButtons.Count; i++)
            {
                SpecialAbilityButtons[i].Enabled = true;
                SpecialAbilityButtons[i].BackgroundImage = null;
            }
            playerScore = 0;
            enemyScore = 0;
            totalShips = 5;
            pcarrier = 0;
            pbattleship = 0;
            pcruiser = 0;
            pdestroyer = 0;
            pscout = 0;
            shots = 0;
            carrierspecial = 5;
            battleshipspecial = 4;
            cruiserspecial = 3;
            destroyerspecial = 2;
            scoutspecial = 1;
            EnemyAttack.Text = "A1";
            EnemyLocation.Text = "Blank";
            background.controls.play();
            btnAttack.Enabled = false;
            btnAttack.BackColor = Color.White;
            btnAttack.ForeColor = Color.Black;
            caspecial = false;
            carrierspecial = 5;
            SpecialAbilityButtons[0].Enabled = false;
            SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
            baspecial = false;
            battleshipspecial = 4;
            SpecialAbilityButtons[1].Enabled = false;
            SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
            crspecial = false;
            cruiserspecial = 3;
            SpecialAbilityButtons[2].Enabled = false;
            SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
            despecial = false;
            destroyerspecial = 2;
            SpecialAbilityButtons[3].Enabled = false;
            SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
            scspecial = false;
            scoutspecial = 1;
            SpecialAbilityButtons[4].Enabled = false;
            SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
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
                MessageBox.Show("Use the cancel button if you wish to make another selection.", "Help");

            }
            else
            {
                
                EnemyLocation.Text = button.Text;
                button.BackgroundImage = Properties.Resources.target;
                shots += 1;
                if (shots == 1)
                {
                    btnAttack.BackColor = Color.Red;
                    btnAttack.ForeColor = Color.White;
                }
                if (crspecial == true && crshots < 3)
                {
                    tspreadtargets[crshots] = EnemyLocation.Text;
                    crshots += 1;
                }
                if (baspecial == true)
                {
                    TricobaltTarget = EnemyLocation.Text;
                    int i = Array.IndexOf(EnemyPositions, TricobaltTarget);
                    battleshiptargets[0] = EnemyPositions[i];
                    battleshiptargets[1] = EnemyPositions[i+1];
                    battleshiptargets[2] = EnemyPositions[i-1];
                    battleshiptargets[3] = EnemyPositions[i+6];
                    battleshiptargets[4] = EnemyPositions[i-6];
                }
                if (caspecial == true)
                {
                    if (EnemyLocation.Text == "A1"|| EnemyLocation.Text == "A2"|| EnemyLocation.Text == "A3"|| EnemyLocation.Text == "A4"|| EnemyLocation.Text == "A5"|| EnemyLocation.Text == "A6")
                    {
                        carriertargets[0] = "A1";
                        carriertargets[1] = "A2";
                        carriertargets[2] = "A3";
                        carriertargets[3] = "A4";
                        carriertargets[4] = "A5";
                        carriertargets[5] = "A6";
                    }
                    if (EnemyLocation.Text == "B1"|| EnemyLocation.Text == "B2"|| EnemyLocation.Text == "B3"|| EnemyLocation.Text == "B4"|| EnemyLocation.Text == "B5"|| EnemyLocation.Text == "B6")
                    {
                        carriertargets[0] = "B1";
                        carriertargets[1] = "B2";
                        carriertargets[2] = "B3";
                        carriertargets[3] = "B4";
                        carriertargets[4] = "B5";
                        carriertargets[5] = "B6";
                    }
                    if (EnemyLocation.Text == "C1"|| EnemyLocation.Text == "C2"|| EnemyLocation.Text == "C3"|| EnemyLocation.Text == "C4"|| EnemyLocation.Text == "C5"|| EnemyLocation.Text == "C6")
                    {
                        carriertargets[0] = "C1";
                        carriertargets[1] = "C2";
                        carriertargets[2] = "C3";
                        carriertargets[3] = "C4";
                        carriertargets[4] = "C5";
                        carriertargets[5] = "C6";
                    }
                    if (EnemyLocation.Text == "D1"|| EnemyLocation.Text == "D2"|| EnemyLocation.Text == "D3"|| EnemyLocation.Text == "D4"|| EnemyLocation.Text == "D5"|| EnemyLocation.Text == "D6")
                    {
                        carriertargets[0] = "D1";
                        carriertargets[1] = "D2";
                        carriertargets[2] = "D3";
                        carriertargets[3] = "D4";
                        carriertargets[4] = "D5";
                        carriertargets[5] = "D6";
                    }
                    if (EnemyLocation.Text == "E1"|| EnemyLocation.Text == "E2"|| EnemyLocation.Text == "E3"|| EnemyLocation.Text == "E4"|| EnemyLocation.Text == "E5"|| EnemyLocation.Text == "E6")
                    {
                        carriertargets[0] = "E1";
                        carriertargets[1] = "E2";
                        carriertargets[2] = "E3";
                        carriertargets[3] = "E4";
                        carriertargets[4] = "E5";
                        carriertargets[5] = "E6";
                    }
                    if (EnemyLocation.Text == "F1"|| EnemyLocation.Text == "F2"|| EnemyLocation.Text == "F3"|| EnemyLocation.Text == "F4"|| EnemyLocation.Text == "F5"|| EnemyLocation.Text == "F6")
                    {
                        carriertargets[0] = "F1";
                        carriertargets[1] = "F2";
                        carriertargets[2] = "F3";
                        carriertargets[3] = "F4";
                        carriertargets[4] = "F5";
                        carriertargets[5] = "F6";
                    }
                }
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
                    button.BackgroundImage = Carrier.Image;
                    totalShips -= 1;
                    pcarrier -= 1;
                }
                if (pbattleship > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Battleship";
                    button.BackgroundImage = Battleship.Image;
                    totalShips -= 1;
                    pbattleship -= 1;
                }
                if (pcruiser > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Cruiser";
                    button.BackgroundImage = Cruiser.Image;
                    totalShips -= 1;
                    pcruiser -= 1;
                }
                if (pdestroyer > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Destroyer";
                    button.BackgroundImage = Destroyer.Image;
                    totalShips -= 1;
                    pdestroyer -= 1;
                }
                if (pscout > 0)
                {
                    var button = (Button)sender;
                    select.Play();
                    button.Enabled = false;
                    button.Tag = "Player Scout";
                    button.BackgroundImage = Scout.Image;
                    totalShips -= 1;
                    pscout -= 1;
                }
                if (totalShips == 0)
                {
                    btnAttack.Enabled = true;
                    txtHelp.Text = "Select a position to attack from the enemy's board.";
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

        private void EnemyLocation_Click(object sender, EventArgs e)
        {

        }

        private void CruiserSpecial(object sender, EventArgs e)
        {
            select.Play();
            crspecial = true;
            shots = -2;
            txtHelp.Text = "Select 3 positions on the board to attack.";
        }

        private void Carrierspecial(object sender, EventArgs e)
        {
            select.Play();
            caspecial = true;
            txtHelp.Text = "Select a row to attack by clicking on a position in the target row.";
        }
    

        private void Battleshipspecial(object sender, EventArgs e)
        {
            select.Play();
            baspecial = true;
            txtHelp.Text = "Select a target for the tricobalt device.";
        }

        private void Destroyerspecial(object sender, EventArgs e)
        {
            select.Play();
            despecial = true;
            shots = 1;
            btnAttack.BackColor = Color.Red;
            btnAttack.ForeColor = Color.White;
            txtHelp.Text = "Press attack to fire the homing torpedo.";
        }

        private void Scoutspecial(object sender, EventArgs e)
        {
            select.Play();
            scspecial = true;
            shots = 1;
            btnAttack.BackColor = Color.Red;
            btnAttack.ForeColor = Color.White;
            txtHelp.Text = "Press attack to activate the sensor scan.";
        }

        private void CancelAttack(object sender, EventArgs e)
        {
            select.Play();
            caspecial = false;
            baspecial = false;
            tritarg = 0;
            crspecial = false;
            crshots = 0;
            AttackPosition = EnemyLocation.Text.ToLower();
            shots = 0;
            despecial = false;
            scspecial = false;
            int index = EnemyPositionButtons.FindIndex(a => a.Name == AttackPosition);
            EnemyPositionButtons[index].BackgroundImage = null;
            EnemyLocation.Text = "Blank";
            txtHelp.Text = "Select a position to attack from the enemy's board.";
        }

        private void SpecialAbilityCooldownEvent(object sender, EventArgs e)
        {
            if (pcarrieralive == true)
            {
                if (carrierspecial > 0)
                {
                    SpecialAbilityButtons[0].Enabled = false;
                    carrierspecial -= 1;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                }
                if (caspecial == true)
                {
                    caspecial = false;
                    carrierspecial = 5;
                    battleshipspecial = 4;
                    cruiserspecial = 3;
                    destroyerspecial = 2;
                    scoutspecial = 1;
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (carrierspecial == 0)
                {
                    SpecialAbilityButtons[0].Enabled = true;
                    SpecialAbilityButtons[0].Text = caspecialname + ": Ready";
                }
            }
            if (pbattleshipalive == true)
            {
                if (battleshipspecial > 0)
                {
                    SpecialAbilityButtons[1].Enabled = false;
                    battleshipspecial -= 1;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                }
                if (baspecial == true)
                {
                    baspecial = false;
                    carrierspecial = 5;
                    battleshipspecial = 4;
                    cruiserspecial = 3;
                    destroyerspecial = 2;
                    scoutspecial = 1;
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (battleshipspecial == 0)
                {
                    SpecialAbilityButtons[1].Enabled = true;
                    SpecialAbilityButtons[1].Text = baspecialname+ ": Ready";
                }
            }
            if (pcruiseralive == true)
            {
                if (cruiserspecial > 0)
                {
                    SpecialAbilityButtons[2].Enabled = false;
                    cruiserspecial -= 1;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                }
                if (crspecial == true)
                {
                    crspecial = false;
                    carrierspecial = 5;
                    battleshipspecial = 4;
                    cruiserspecial = 3;
                    destroyerspecial = 2;
                    scoutspecial = 1;
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (cruiserspecial == 0)
                {
                    SpecialAbilityButtons[2].Enabled = true;
                    SpecialAbilityButtons[2].Text = crspecialname + ": Ready";
                }
            }
            if (pdestroyeralive == true)
            {
                if (destroyerspecial > 0)
                {
                    SpecialAbilityButtons[3].Enabled = false;
                    destroyerspecial -= 1;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                }
                if (despecial == true)
                {
                    despecial = false;
                    carrierspecial = 5;
                    battleshipspecial = 4;
                    cruiserspecial = 3;
                    destroyerspecial = 2;
                    scoutspecial = 1;
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (destroyerspecial == 0)
                {
                    SpecialAbilityButtons[3].Enabled = true;
                    SpecialAbilityButtons[3].Text = despecialname + ": Ready";
                }
            }
            if (pscoutalive == true)
            {
                if (scoutspecial > 0)
                {
                    SpecialAbilityButtons[4].Enabled = false;
                    scoutspecial -= 1;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (scspecial == true)
                {
                    scspecial = false;
                    carrierspecial = 5;
                    battleshipspecial = 4;
                    cruiserspecial = 3;
                    destroyerspecial = 2;
                    scoutspecial = 1;
                    SpecialAbilityButtons[0].Enabled = false;
                    SpecialAbilityButtons[0].Text = caspecialname + ": " + carrierspecial + " turns remaining";
                    SpecialAbilityButtons[1].Enabled = false;
                    SpecialAbilityButtons[1].Text = baspecialname + ": " + battleshipspecial + " turns remaining";
                    SpecialAbilityButtons[2].Enabled = false;
                    SpecialAbilityButtons[2].Text = crspecialname + ": " + cruiserspecial + " turns remaining";
                    SpecialAbilityButtons[3].Enabled = false;
                    SpecialAbilityButtons[3].Text = despecialname + ": " + destroyerspecial + " turns remaining";
                    SpecialAbilityButtons[4].Enabled = false;
                    SpecialAbilityButtons[4].Text = scspecialname + ": " + scoutspecial + " turns remaining";
                }
                if (scoutspecial == 0)
                {
                    SpecialAbilityButtons[4].Enabled = true;
                    SpecialAbilityButtons[4].Text = scspecialname + ": Ready";
                }
            }
            SpecialAbilityCooldown.Stop();
        }
    }
}
