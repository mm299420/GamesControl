using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartenspiel;
using System.Threading;

namespace GamesControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlayerVSPC_Click(object sender, EventArgs e)
        {
            Kartenspiel.Form1 f1 = new Kartenspiel.Form1();
            f1.Show();
            bool prevent = true;
            bool preventM = true;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Kartenspiel.Form1 f2 = new Kartenspiel.Form1();
                while (prevent)
                {
                    if (!f2.Exit)
                    {
                        Close();
                    }
                }
                while (preventM)
                {
                    if (!f2.Menu)
                    {
                        Show();
                        Focus();
                    } 
                }
            }).Start();
        }

        private void btnBlackJ_Click(object sender, EventArgs e)
        {
            Kartenspiel.Form1 f1 = new Kartenspiel.Form1();
            f1.Show();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}