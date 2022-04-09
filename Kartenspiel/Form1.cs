using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Kartenspiel
{
    public partial class Form1 : Form
    {
        public int k = 0;
        public Random rnd = new Random();
        public bool stopRound = false;
        public bool startRound = true;
        private bool[] karten = new bool[53];
        
        public bool[] Karten()
        {
            bool[] karten = new bool[53]
            {
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false, false, 
                false, false, false, false, false
            };
            return karten;
        }

        private string kartePC;
        private string kartePlayer;
        private string logoPC;
        private string logoPlayer;
        
        private int rndZ;
        private int standPC;
        private int standPlayer;
        private int runde = 0;
        
        private bool PC;
        private bool Player;
        private bool restart;
        
        public bool Exit = true;
        public bool Menu = true;
        
        private string kartenlogo;
        private string kartenwert;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Karten();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                startRound = true;
                stopRound = false;
                picBHerz.Image = Image.FromFile("Herz.jpg");
            }).Start();
        }

        public void round()
        {
            startRound = false;
            stopRound = true;
            while (stopRound)
            {
                roundEnd();
            }
        }
        public void roundEnd()
        {
            Karten();
            if (standPlayer < standPC)
            {
                txtStatus.Text = $"PC Gewinnt!\nPunkte: {standPC.ToString()}";
            }
            else if (standPlayer > standPC)
            {
                txtStatus.Text = $"PC Gewinnt!\nPunkte: {standPC.ToString()}";
            }
            else if (standPlayer == standPC)
            {
                txtStatus.Text = $"Spielstand Unentschieden!\nPunkte: {standPC.ToString()}";
            }
            picBPC.Enabled = false;
            picBPlayer.Enabled = false;
            k = 0;
            standPlayer = 0;
            standPC = 0;
            txtPunktePC.Text = "";
            txtPunktePlayer.Text = "";
            lblPlayer.Text = "";
            lblPC.Text = "";
            btnNewGame.Text = "New Game";
            stopRound = false;
            startRound = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Exit = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (btnNewGame.Text == "New Game")
            {
                txtStatus.Text = "Runde Startet!";
                picBPC.Enabled = true;
                picBPlayer.Enabled = true;
            }
            if (btnNewGame.Text == "Next Round")
            {
                txtStatus.Text = "Runde Läuft!";
            }
            k++;
            lblRundeV.Text = k.ToString();
            if (k == 26)
            {
                startRound = false;
                stopRound = true;
                while (stopRound)
                {
                    roundEnd();
                }
            }
            loadNum();
            PC = true;
            int vPC = 1;
            int vPlayer = 1;
            runde++;
            
            while (PC)
            {
                loadNum();
                kartenDefinition();
                kartePC = kartenwert;
                logoPC = kartenlogo;
                lblPC.Text = kartePC;
                switch (kartePC)
                {
                    case "2":
                        vPC = 2;
                        PC = false;
                        break;
                    case "3":
                        vPC = 3;
                        PC = false;
                        break;
                    case "4":
                        vPC = 4;
                        PC = false;
                        break;
                    case "5":
                        vPC = 5;
                        PC = false;
                        break;
                    case "6":
                        vPC = 6;
                        PC = false;
                        break;
                    case "7":
                        vPC = 7;
                        PC = false;
                        break;
                    case "8":
                        vPC = 8;
                        PC = false;
                        break;
                    case "9":
                        vPC = 9;
                        PC = false;
                        break;
                    case "10":
                        vPC = 10;
                        PC = false;
                        break;
                    case "J":
                        vPC = 11;
                        PC = false;
                        break;
                    case "Q":
                        vPC = 12;
                        PC = false;
                        break;
                    case "K":
                        vPC = 13;
                        PC = false;
                        break;
                    case "A":
                        vPC = 14;
                        PC = false;
                        break;
                }
                switch (logoPC)
                {
                    case "Herz":
                        picBPC.Image = Image.FromFile("Herz.jpg");
                        break;
                    case "Kreuz":
                        picBPC.Image = Image.FromFile("Kreuz.jpg");
                        break;
                    case "Karo":
                        picBPC.Image = Image.FromFile("Karo.jpg");
                        break;
                    case "Pik":
                        picBPC.Image = Image.FromFile("Pik.jpg");
                        break;
                }
                Player = true;
            }

            while (Player)
            {
                loadNum();
                kartenDefinition();
                kartePlayer = kartenwert;
                logoPlayer = kartenlogo;
                lblPlayer.Text = kartePlayer;
                
                switch (kartePlayer)
                {
                    case "2":
                        vPlayer = 2;
                        Player = false;
                        break;
                    case "3":
                        vPlayer = 3;
                        Player = false;
                        break;
                    case "4":
                        vPlayer = 4;
                        Player = false;
                        break;
                    case "5":
                        vPlayer = 5;
                        Player = false;
                        break;
                    case "6":
                        vPlayer = 6;
                        Player = false;
                        break;
                    case "7":
                        vPlayer = 7;
                        Player = false;
                        break;
                    case "8":
                        vPlayer = 8;
                        Player = false;
                        break;
                    case "9":
                        vPlayer = 9;
                        Player = false;
                        break;
                    case "10":
                        vPlayer = 10;
                        Player = false;
                        break;
                    case "J":
                        vPlayer = 11;
                        Player = false;
                        break;
                    case "Q":
                        vPlayer = 12;
                        Player = false;
                        break;
                    case "K":
                        vPlayer = 13;
                        Player = false;
                        break;
                    case "A":
                        vPlayer = 14;
                        Player = false;
                        break;
                }
                switch (logoPlayer)
                {
                    case "Herz":
                        picBPlayer.Image = Image.FromFile("Herz.jpg");
                        break;
                    case "Kreuz":
                        picBPlayer.Image = Image.FromFile("Kreuz.jpg");
                        break;
                    case "Karo":
                        picBPlayer.Image = Image.FromFile("Karo.jpg");
                        break;
                    case "Pik":
                        picBPlayer.Image = Image.FromFile("Pik.jpg");
                        break;
                }
            }
            
            if (vPlayer < vPC)
            {
                txtStatus.Text = $"PC Gewinnt!";
                standPC++;
            }
            else if (vPlayer > vPC)
            {
                txtStatus.Text = $"Player Gewinnt!";
                standPlayer++;
            }
            else if (vPlayer == vPC)
            {
                txtStatus.Text = $"Runde Unentschieden!";
                standPC++;
                standPlayer++;
            }
            
            txtPunktePlayer.Text = standPlayer.ToString();
            txtPunktePC.Text = standPC.ToString();
            btnNewGame.Text = "Next Round";
        }
        private void loadNum()
        {
            rndZ = rnd.Next(0, 53);
        }

        public void joker()
        {
            jokerS jScreen = new jokerS();
            jScreen.Show();
        }
        public void kartenDefinition()
        {
            if (!karten[rndZ])
            {
                karten[rndZ] = true;

                if (rndZ <= 13)
                {
                    kartenlogo = "Herz";
                    switch (rndZ)
                    {
                        case 0:
                            kartenwert = "2";
                            break;
                        case 1:
                            kartenwert = "3";
                            break;
                        case 2:
                            kartenwert = "4";
                            break;
                        case 3:
                            kartenwert = "5";
                            break;
                        case 4:
                            kartenwert = "6";
                            break;
                        case 5:
                            kartenwert = "7";
                            break;
                        case 7:
                            kartenwert = "8";
                            break;
                        case 8:
                            kartenwert = "9";
                            break;
                        case 9:
                            kartenwert = "10";
                            break;
                        case 10:
                            kartenwert = "J";
                            break;
                        case 11:
                            kartenwert = "Q";
                            break;
                        case 12:
                            kartenwert = "K";
                            break;
                        case 13:
                            kartenwert = "A";
                            break;
                    }
                }

                if (rndZ <= 26 && rndZ > 13)
                {
                    kartenlogo = "Karo";
                    switch (rndZ)
                    {
                        case 14:
                            kartenwert = "2";
                            break;
                        case 15:
                            kartenwert = "3";
                            break;
                        case 16:
                            kartenwert = "4";
                            break;
                        case 17:
                            kartenwert = "5";
                            break;
                        case 18:
                            kartenwert = "6";
                            break;
                        case 19:
                            kartenwert = "7";
                            break;
                        case 20:
                            kartenwert = "8";
                            break;
                        case 21:
                            kartenwert = "9";
                            break;
                        case 22:
                            kartenwert = "10";
                            break;
                        case 23:
                            kartenwert = "J";
                            break;
                        case 24:
                            kartenwert = "Q";
                            break;
                        case 25:
                            kartenwert = "K";
                            break;
                        case 26:
                            kartenwert = "A";
                            break;
                    }
                }
                else if (rndZ <= 39 && rndZ > 26)
                {
                    kartenlogo = "Kreuz";
                    switch (rndZ)
                    {
                        case 27:
                            kartenwert = "2";
                            break;
                        case 28:
                            kartenwert = "3";
                            break;
                        case 29:
                            kartenwert = "4";
                            break;
                        case 30:
                            kartenwert = "5";
                            break;
                        case 31:
                            kartenwert = "6";
                            break;
                        case 32:
                            kartenwert = "7";
                            break;
                        case 33:
                            kartenwert = "8";
                            break;
                        case 34:
                            kartenwert = "9";
                            break;
                        case 35:
                            kartenwert = "10";
                            break;
                        case 36:
                            kartenwert = "J";
                            break;
                        case 37:
                            kartenwert = "Q";
                            break;
                        case 38:
                            kartenwert = "K";
                            break;
                        case 39:
                            kartenwert = "A";
                            break;
                    }
                }
                else if (rndZ <= 52 && rndZ > 40)
                {
                    kartenlogo = "Pik";
                    switch (rndZ)
                    {
                        case 40:
                            kartenwert = "2";
                            break;
                        case 41:
                            kartenwert = "3";
                            break;
                        case 42:
                            kartenwert = "4";
                            break;
                        case 43:
                            kartenwert = "5";
                            break;
                        case 44:
                            kartenwert = "6";
                            break;
                        case 45:
                            kartenwert = "7";
                            break;
                        case 46:
                            kartenwert = "8";
                            break;
                        case 47:
                            kartenwert = "9";
                            break;
                        case 48:
                            kartenwert = "10";
                            break;
                        case 49:
                            kartenwert = "J";
                            break;
                        case 50:
                            kartenwert = "Q";
                            break;
                        case 51:
                            kartenwert = "K";
                            break;
                        case 52:
                            kartenwert = "A";
                            break;
                    }
                }
                karten[rndZ] = true;
            }
            if (rndZ == 53)
            {
                restart = true;
                joker();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            roundEnd();
        }

        private void btnGameMenu_Click(object sender, EventArgs e)
        {
            Menu = false;
            this.Hide();
        }
    }
}


