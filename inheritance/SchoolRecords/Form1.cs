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
    public partial class Form1 : Form
    {
        private Form2 theForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clickForTest_Click(object sender, EventArgs e)
        {
            theForm = new Form2();
            theForm.Show();
            
            Person s2 = new Person();
            s2.setName("John Davies");
            s2.setAge(17);
            Address a2 = new Address("24", "Happy Street", "England", "HR2 6JG");
            s2.setAddress(a2);

        }
    }
}
