using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kartenspiel
{
    public partial class jokerS : Form
    {
        public jokerS()
        {
            InitializeComponent();
        }

        private void jokerS_Load(object sender, EventArgs e)
        {
            picBJoker.Image = Image.FromFile("Joker.jpg");
        }
    }
}