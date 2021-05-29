/**************************************************************************
 *                                                                        *
 *  File:        Inregistreaza.cs                                         *
 *  Copyright:   (c) 2021, Dumitru Bianca                                 *
 *  E-mail:      bianca.dumitru@student.tuiasi.ro                         *
 *  Description: Clasa ce realizeaza un bon de ordine                     *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectIP
{
    public partial class Inregistreaza : Form
    {
        public Inregistreaza()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bianca\OneDrive\Desktop\Data.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sql = new SqlDataAdapter();
        private void button_autentificare_Click(object sender, EventArgs e)
        {
            if (textBox_utilizator.Text == "" && textBox_parola.Text == "" && textBox_confirma_parola.Text == "")
            {
                MessageBox.Show("Campurile Utilizator și Parola sunt goale", "Inregistrare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox_parola.Text == textBox_confirma_parola.Text)
            {
                conn.Open();
                string register = "INSERT INTO Autentificare VALUES ('" + textBox_utilizator.Text + "','" + textBox_parola.Text + "')";
                cmd = new SqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                textBox_utilizator.Text = "";
                textBox_parola.Text = "";
                textBox_confirma_parola.Text = "";

                MessageBox.Show("Contul tau a fost creat cu succes", "Inregistrare cu succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_parola.Text = "";
                textBox_confirma_parola.Text = "";
                textBox_parola.Focus();
            }
        }

        private void button_Stergere_Click(object sender, EventArgs e)
        {
            textBox_utilizator.Text = "";
            textBox_parola.Text = "";
            textBox_confirma_parola.Text = "";
            textBox_utilizator.Focus();
        }

        private void label_creare_cont_Click(object sender, EventArgs e)
        {
        
            this.Hide();
        }

        private void checkBox_afiseaza_parola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_afiseaza_parola.Checked)
            {
                textBox_parola.PasswordChar = '\0';
                textBox_confirma_parola.PasswordChar = '\0';
            }
            else
            {
                textBox_parola.PasswordChar = '•';
                textBox_confirma_parola.PasswordChar = '•';
            }
        }

        private void button_iesire_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
