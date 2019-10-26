using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meuprograma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form1 = new Form2();
            form1.ShowDialog();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form1 = new Form4();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form1 = new Form5();
            form1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
