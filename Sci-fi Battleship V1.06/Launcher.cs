using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Sci_fi_Battleship
{
    public partial class Main_Menu : Form
    {
        string Player_Faction;
        string Enemy_Faction;

        WindowsMediaPlayer Labackground = new WindowsMediaPlayer();
        SoundPlayer select = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\keyok6.wav");
        SoundPlayer unable = new SoundPlayer(@"C:\Users\aston\Desktop\Google Drive\Year 12\Software Design and Development\Sci-fi Battleship\Sci-fi Battleship V1.03\Resources\input_failed_clean.wav");

        public Main_Menu()
        {
            InitializeComponent();
            Labackground.URL = "Launcher Music.mp3";
            Labackground.settings.autoStart = true;
            Labackground.settings.setMode("loop", true);
        }


        private void LoadGameSelect(object sender, EventArgs e)
        {
            if (PlayerFaction.Text == "")
            {
                unable.Play();
                MessageBox.Show("Select a Faction you wish to play as.", "Help");
            }
            if (EnemyFaction.Text == "")
            {
                unable.Play();
                MessageBox.Show("Select a Faction you wish to play against.", "Help");
            }
            if (PlayerFaction.Text == "United Federation of Planets (ST)")
            {
                Player_Faction = "UFP";
            }
            if (EnemyFaction.Text == "United Federation of Planets (ST)")
            {
                Enemy_Faction = "UFP";
            }
            if (PlayerFaction.Text == "Klingon Empire (ST)")
            {
                Player_Faction = "KlE";
            }
            if (EnemyFaction.Text == "Klingon Empire (ST)")
            {
                Enemy_Faction = "KlE";
            }
            if(PlayerFaction.Text == "Romulan Star Empire (ST)")
            {
                Player_Faction = "RSE";
            }
            if (EnemyFaction.Text == "Romulan Star Empire (ST)")
            {
                Enemy_Faction = "RSE";
            }
            if (PlayerFaction.Text == "Borg Collective (ST)")
            {
                Player_Faction = "BoC";
            }
            if (EnemyFaction.Text == "Borg Collective (ST)")
            {
                Enemy_Faction = "BoC";
            }
            if (PlayerFaction.Text == "Rebel Alliance (SW)")
            {
                Player_Faction = "ReA";
            }
            if (EnemyFaction.Text == "Rebel Alliance (SW)")
            {
                Enemy_Faction = "ReA";
            }
            if (PlayerFaction.Text == "Galactic Empire (SW)")
            {
                Player_Faction = "GaE";
            }
            if (EnemyFaction.Text == "Galactic Empire (SW)")
            {
                Enemy_Faction = "GaE";
            }
            if (PlayerFaction.Text == "Twelve Colonies of Kobol (BSG)")
            {
                Player_Faction = "TCK";
            }
            if (EnemyFaction.Text == "Twelve Colonies of Kobol (BSG)")
            {
                Enemy_Faction = "TCK";
            }
            if (PlayerFaction.Text == "Cylon Empire (BSG)")
            {
                Player_Faction = "CyE";
            }
            if (EnemyFaction.Text == "Cylon Empire (BSG)")
            {
                Enemy_Faction = "CyE";
            }
            if (PlayerFaction.Text != "" && EnemyFaction.Text != "")
            {
                select.Play();
                StandardGame NewGame = new StandardGame(Player_Faction, Enemy_Faction);

                NewGame.Show();
                Labackground.controls.pause();
            }
        }
    }
}
