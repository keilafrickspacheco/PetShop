using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=si5;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "delete from petshop where id_animal = " + " ('" + textBox1.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Exclusão realizada com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form4 = new Form1();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
