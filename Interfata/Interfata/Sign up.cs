using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
            parolaSignUpTextBox.PasswordChar = '•';
            parolaConfirmSignUpTextBox.PasswordChar = '•';
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Main form = new Main();
            form.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\Interfata\Interfata\DataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();                            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Daca exista deja utilizator cu numele asta sau cu mailul asta e nono.

            SqlDataAdapter sql = new SqlDataAdapter("Select Count(*) From [Table] Where Username='" + usernameSignUpTextBox.Text + "' or mail='" + emailSignUpTextBox.Text + "'", conn);
            DataTable dta = new DataTable();
            sql.Fill(dta);
            if (usernameSignUpTextBox.Text == "" || parolaSignUpTextBox.Text == "" || parolaConfirmSignUpTextBox.Text == "" || emailSignUpTextBox.Text=="")
            {
                MessageBox.Show("Campurile Utilizator, Email sau Parola sunt goale", "Inregistrare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            if (!gdprCheckBox.Checked)
            {
                MessageBox.Show("Trebuie sa fiti de acord cu GDPR!");
            }
            else
            if(parolaConfirmSignUpTextBox.Text!=parolaSignUpTextBox.Text)
            {
                MessageBox.Show("Parola nu corespunde!", "Inregistrare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            if (dta.Rows[0][0].ToString() == "0")
            {
                cmd.CommandText = "insert into [Table] values(@username,@password,@mail)";
                cmd.Parameters.AddWithValue("@username", usernameSignUpTextBox.Text);
                cmd.Parameters.AddWithValue("@password", parolaSignUpTextBox.Text);
                cmd.Parameters.AddWithValue("@mail", emailSignUpTextBox.Text);

                usernameSignUpTextBox.Text = "";
                parolaSignUpTextBox.Text = "";
                parolaConfirmSignUpTextBox.Text = "";
                emailSignUpTextBox.Text = "";

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("V-ați înregistrat cu succes!");
                    Hide();
                    LogIn form = new LogIn();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Email or username has already been registred!");
                usernameSignUpTextBox.Text = "";
                parolaSignUpTextBox.Text = "";
                parolaConfirmSignUpTextBox.Text = "";
                emailSignUpTextBox.Text = "";
                parolaSignUpTextBox.Focus();
            }



        }

        private void parolaSignUpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailSignUpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameSignUpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gdprCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_afiseaza_parola_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox_afiseaza_parola.Checked)
                {
                    parolaSignUpTextBox.PasswordChar = '\0';
                    parolaConfirmSignUpTextBox.PasswordChar = '\0';
                }
                else
                {
                    parolaSignUpTextBox.PasswordChar = '•';
                    parolaConfirmSignUpTextBox.PasswordChar = '•';
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void button_Stergere_Click(object sender, EventArgs e)
        {
            usernameSignUpTextBox.Text = "";
            parolaSignUpTextBox.Text = "";
            parolaConfirmSignUpTextBox.Text = "";
            emailSignUpTextBox.Focus();
        }
    }
}
