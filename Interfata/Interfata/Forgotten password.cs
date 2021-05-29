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
    public partial class Forgotten_password : Form
    {
        private readonly Random _random = new Random();
        private int _codAutentificare;
        private string _userEmail;
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public Forgotten_password()
        {
            InitializeComponent();
            HelpLabel.Text = "Care este adresa ta de email?";
            NextButton.Show();
            NextButton2.Hide();
            NextButton3.Hide();
        }

        private void Forgotten_password_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\Interfata\Interfata\DataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter sql = new SqlDataAdapter("Select Count(*) From [Table] Where email='" + EmailTextBox.Text + "'", conn);
            DataTable dta = new DataTable();
            sql.Fill(dta);
            if (dta.Rows[0][0].ToString() == "1")
            {

                _userEmail= EmailTextBox.Text;
                _codAutentificare = RandomNumber(1000, 9999);
                HelpLabel.Text = "Inserati codul primit pe email pentru a va schimba parola!";
                MessageBox.Show("Codul dumneavoastra este: " + _codAutentificare+"!");
                NextButton.Hide();
                NextButton2.Show();
                EmailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Nu am gasit emailul in baza noastra de date!\nMai incearca!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogIn form = new LogIn();
            form.Show();
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(EmailTextBox.Text)==_codAutentificare)
            {
                NextButton2.Hide();
                NextButton3.Show();
                HelpLabel.Text = "Parola noua:";

            }
            else
            {
                MessageBox.Show("Cod Incorect! Mai incearca!"); 
            }

        }

        private void NextButton3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\Interfata\Interfata\DataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update [table] set password=@password where email='"+_userEmail+"'";
            cmd.Parameters.AddWithValue("@password", EmailTextBox.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Parola schimbata cu succes!");
                }

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
