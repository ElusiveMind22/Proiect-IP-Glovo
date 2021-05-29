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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\data.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();                            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //Daca exista deja utilizator cu numele asta sau cu mailul asta e nono.

            SqlDataAdapter sql = new SqlDataAdapter("Select Count(*) From [Table] Where Username='" + usernameSignUpTextBox.Text + "' or email='" + emailSignUpTextBox.Text + "'", conn);
            DataTable dta = new DataTable();
            sql.Fill(dta);
            if(!gdprCheckBox.Checked)
            {
                MessageBox.Show("You must agree to GDPR first!");
            }
            else
            if (dta.Rows[0][0].ToString() == "0")
            {
                cmd.CommandText = "insert into [Table] values(@username,@password,@mail)";
                cmd.Parameters.AddWithValue("@username", usernameSignUpTextBox.Text);
                cmd.Parameters.AddWithValue("@password", parolaSignUpTextBox.Text);
                cmd.Parameters.AddWithValue("@mail", emailSignUpTextBox.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("V-ați înregistrat cu succes!");
                }
            }
            else
            {
                MessageBox.Show("Email or username has already been registred!");
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
    }
}
