using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selexted Ford");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selexted Honda");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selexted Toyota");
        }

        private void TeslaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selexted TESLA");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
