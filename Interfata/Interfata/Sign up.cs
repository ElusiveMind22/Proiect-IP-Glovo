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

            signUpLabel.BackColor = System.Drawing.Color.Transparent;
            signUpLabel.Parent = pictureBox1;

            usernameSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            usernameSignUpLabel.Parent = pictureBox1;

            parolaSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            parolaSignUpLabel.Parent = pictureBox1;

            emailSignUpLabel.BackColor = System.Drawing.Color.Transparent;
            emailSignUpLabel.Parent = pictureBox1;

            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Parent = pictureBox1;

            checkBox_afiseaza_parola.BackColor = System.Drawing.Color.Transparent;
            checkBox_afiseaza_parola.Parent = pictureBox1;

            gdprCheckBox.BackColor = System.Drawing.Color.Transparent;
            gdprCheckBox.Parent = pictureBox1;

            newsletterCheckBox.BackColor = System.Drawing.Color.Transparent;
            newsletterCheckBox.Parent = pictureBox1;
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Redirectioneaza utilizatorul catre fereastra principala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            Main form = new Main();
            form.Show();
        }

        /// <summary>
        /// Verifica daca datele introduse de utilizator exista deja in baza de date si daca nu, sunt adaugate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (usernameSignUpTextBox.Text == "" || parolaSignUpTextBox.Text == "" || parolaConfirmSignUpTextBox.Text == "" || emailSignUpTextBox.Text == "")
            {
                MessageBox.Show("Campurile Utilizator, Email sau Parola sunt goale", "Inregistrare esuata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            if (!gdprCheckBox.Checked)
            {
                MessageBox.Show("Trebuie sa fiti de acord cu GDPR!");
            }
            else
            if (parolaConfirmSignUpTextBox.Text != parolaSignUpTextBox.Text)
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

        /// <summary>
        /// Permite utilizatorului sa vizualizeze parola introdusa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sterge textul din casutele de text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Stergere_Click(object sender, EventArgs e)
        {
            usernameSignUpTextBox.Text = "";
            parolaSignUpTextBox.Text = "";
            parolaConfirmSignUpTextBox.Text = "";
            emailSignUpTextBox.Focus();
        }

    }
}
