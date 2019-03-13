using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRecords
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void completeButton_Click(object sender, EventArgs e)
        {         

 
            Person s1 = new Person();
            s1.setName(textBox1.Text);
            s1.setAge(Convert.ToInt32(textBox2.Text));
            Address a1 = new Address(Convert.ToString(textBox3));
            Convert.ToString(textBox4.Text);
            Convert.ToString(textBox5.Text);
            Convert.ToString(textBox6.Text);
            s1.setAddress(a1);
        }
    }
}
