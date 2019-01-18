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
    public partial class GameUI : Form
    {
        private String player1;
        private String player2;
        public GameUI(String p1name, String p2name)
        {
            
            InitializeComponent();
            label1.Text = p1name;
            label2.Text = p2name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
