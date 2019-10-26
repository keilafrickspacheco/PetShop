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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form2 = new Form1();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=si5;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "INSERT INTO petshop (NOME_animal,porte_animal,idade_animal, tipo_animal, procedimento_fazer, valor_pagar, nome_dono, cpf_dono, telefone_dono) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro realizado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=si5;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "update petshop set NOME_animal = '" + textBox1.Text + "',porte_animal = '" + textBox2.Text + "',idade_animal = '" + textBox3.Text + "', tipo_animal = '" + textBox4.Text + "', procedimento_fazer = '" + textBox5.Text + "', valor_pagar = '" + textBox6.Text + "', nome_dono = '" + textBox7.Text + "', cpf_dono = '" + textBox8.Text + "', telefone_dono = '" + textBox9.Text + "' where Id_animal = '" + textBox10.Text + "'";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Alteração realizada com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
