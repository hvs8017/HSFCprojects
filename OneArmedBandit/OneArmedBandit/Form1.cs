using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this is started when the program starts
            //this displays images when the program starts
            imageOne.Image = Properties.Resources.kitten1;
            imageTwo.Image = Properties.Resources.kitten_2;
            imageThree.Image = Properties.Resources.kitten6;
            

            
        }
        private void nudgeBoxOne_Click(object sender, EventArgs e)
        {

            Random rmd = new Random(); //makes a new random
            int tempTwo = rmd.Next(0, 6); //picks a random
            if (tempTwo == 0)
            {
                imageOne.Image = Properties.Resources.kitten1; //if 0, kitten one displays
            }
            if (tempTwo == 1)
            {
                imageOne.Image = Properties.Resources.kitten_2;
            }
            if (tempTwo == 2)
            {
                imageOne.Image = Properties.Resources.kitten3;
            }
            if (tempTwo == 3)
            {
                imageOne.Image = Properties.Resources.kitten4;
            }
            if (tempTwo == 4)
            {
                imageOne.Image = Properties.Resources.kitten5;
            }
            if (tempTwo == 5)
            {
                imageOne.Image = Properties.Resources.kitten6;
            }
        }
        private void spinButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); //makes a new random
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);
            {
                int temp = rnd.Next(0, 6); //between 0 and 5
                if (temp == 1)
                {
                    imageOne.Image = Properties.Resources.kitten1;
                    imageTwo.Image = Properties.Resources.kitten_2;
                    imageThree.Image = Properties.Resources.kitten3;
                }
                else
                {
                    
                }
                if (temp == 2) 
                {
                    imageOne.Image = Properties.Resources.kitten_2;
                    imageTwo.Image = Properties.Resources.kitten3;
                    imageThree.Image = Properties.Resources.kitten4;
                }
                else
                {
                    
                }
                if (temp == 3) 
                {
                    imageOne.Image = Properties.Resources.kitten3;
                    imageTwo.Image = Properties.Resources.kitten4;
                    imageThree.Image = Properties.Resources.kitten5;
                }
                else
                {
                    
                }
                if (temp == 4)
                {
                    imageOne.Image = Properties.Resources.kitten4;
                    imageTwo.Image = Properties.Resources.kitten5;
                    imageThree.Image = Properties.Resources.kitten6;
                }
                else
                {

                }
                if (temp == 5)
                {
                    imageOne.Image = Properties.Resources.kitten5;
                    imageTwo.Image = Properties.Resources.kitten6;
                    imageThree.Image = Properties.Resources.kitten1;
                }
                else
                {

                }
                if (temp == 6)
                {
                    imageOne.Image = Properties.Resources.kitten6;
                    imageTwo.Image = Properties.Resources.kitten1;
                    imageThree.Image = Properties.Resources.kitten_2;
                }
                else
                {

                }

            }
        }
        private void nudgeBoxTwo_Click(object sender, EventArgs e)
        {

            {
                Random rand = new Random(); //makes a new random
                int tempThree = rand.Next(0, 6);
                if (tempThree == 0)
                {
                    imageTwo.Image = Properties.Resources.kitten1;
                }
                if (tempThree == 1)
                {
                    imageTwo.Image = Properties.Resources.kitten_2;
                }
                if (tempThree == 2)
                {
                    imageTwo.Image = Properties.Resources.kitten3;
                }
                if (tempThree == 3)
                {
                    imageTwo.Image = Properties.Resources.kitten4;
                }
                if (tempThree == 4)
                {
                    imageTwo.Image = Properties.Resources.kitten5;
                }
                if (tempThree == 5)
                {
                    imageTwo.Image = Properties.Resources.kitten6;
                }
            }
            
        }
        private void nudgeBoxThree_Click(object sender, EventArgs e)
        {
            Random radm = new Random();
            int tempFour = radm.Next(0, 6);
            if (tempFour == 0)
            {
                imageThree.Image = Properties.Resources.kitten1;
            }
            if (tempFour == 1)
            {
                imageThree.Image = Properties.Resources.kitten_2;
            }
            if (tempFour == 2)
            {
                imageThree.Image = Properties.Resources.kitten3;
            }
            if (tempFour == 3)
            {
                imageThree.Image = Properties.Resources.kitten4;
            }
            if (tempFour == 4)
            {
                imageThree.Image = Properties.Resources.kitten5;
            }
            if (tempFour == 5)
            {
                imageThree.Image = Properties.Resources.kitten6;
            }
        }
    }
}
