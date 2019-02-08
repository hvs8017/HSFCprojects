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
        private String currentPlayer;
        private OxoGame.Piece currentPiece;

        private OxoGame makeMove;
        private String nextPiece;
        public GameUI(String p1name, String p2name)
        {
            
            InitializeComponent();
            label1.Text = p1name;
            label2.Text = p2name;
            player1 = p1name;
            player2 = p2name;
        }
        private void GameUI_Load(object sender, EventArgs e)

        {

            OxoGame theGame = new OxoGame(player1, player2); // pass names OxoGame 
            
            currentPlayer = theGame.nextPlayer();

            currentPiece = theGame.nextPiece();
            
        }


        private void button1_Click(object sender, EventArgs e)
           
        {
            
            if (currentPiece == OxoGame.Piece.Nought)

            {
                // display your Nought image at 0,0  
                button1.Image = Properties.Resources.Nought;
            }

            else

            {
                // display your Cross image at 0,0  
                button1.Image = Properties.Resources.cross;
            }

            theGame.makeMove(0, 0, currentPiece);  // make the move in the model too! 

            currentPlayer = GameUI.theGame.nextPlayer();

            currentPiece = theGame.nextPiece();

            // now test for a win too; 

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
 

}
