using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oxoGame
{
    public partial class Form1 : Form
    {
        private GameUI myGame;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //the user has clicked start
            //we need to collect the two names and pass into game
            myGame = new GameUI(textBox1.Text, textBox2.Text);
            myGame.Show();
            
        }


    }
}
