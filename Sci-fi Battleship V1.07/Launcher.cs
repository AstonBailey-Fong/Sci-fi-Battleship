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
    public partial class Launcher : Form
    {
        string Player_Faction;
        string Enemy_Faction;
        
        WindowsMediaPlayer Labackground = new WindowsMediaPlayer();
        //string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        SoundPlayer select = new SoundPlayer(Application.StartupPath + @"\Sound Effects\keyok6.wav");
        SoundPlayer unable = new SoundPlayer(Application.StartupPath + @"\Sound Effects\input_failed_clean.wav");

        public Launcher()
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
            if (PlayerFaction.Text == "United Federation of Planets")
            {
                Player_Faction = "UFP";
            }
            if (EnemyFaction.Text == "United Federation of Planets")
            {
                Enemy_Faction = "UFP";
            }
            if (PlayerFaction.Text == "Klingon Empire")
            {
                Player_Faction = "KlE";
            }
            if (EnemyFaction.Text == "Klingon Empire")
            {
                Enemy_Faction = "KlE";
            }
            if(PlayerFaction.Text == "Romulan Star Empire")
            {
                Player_Faction = "RSE";
            }
            if (EnemyFaction.Text == "Romulan Star Empire")
            {
                Enemy_Faction = "RSE";
            }
            if (PlayerFaction.Text == "Dominion Alliance")
            {
                Player_Faction = "DoA";
            }
            if (EnemyFaction.Text == "Dominion Alliance")
            {
                Enemy_Faction = "DoA";
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
