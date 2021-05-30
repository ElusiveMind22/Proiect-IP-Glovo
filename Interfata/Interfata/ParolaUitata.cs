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

        /// <summary>
        /// Genereaza un cod aleatoriu necesar pentru modificarea parolei utilizatorului.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
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

            //background transparent
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Parent = pictureBox1;

            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Parent = pictureBox1;

            HelpLabel.BackColor = System.Drawing.Color.Transparent;
            HelpLabel.Parent = pictureBox1;



        }

        /// <summary>
        /// Verifica daca email-ul tastat de utilizator se afla in baza de date si daca da, afiseaza codul pentru modificarea parolei.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\Interfata\Interfata\DataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataAdapter sql = new SqlDataAdapter("Select Count(*) From [Table] Where mail='" + EmailTextBox.Text + "'", conn);
            DataTable dta = new DataTable();
            sql.Fill(dta);
            if (dta.Rows[0][0].ToString() == "1")
            {

                _userEmail = EmailTextBox.Text;
                _codAutentificare = RandomNumber(1000, 9999);
                HelpLabel.Text = "Inserati codul primit pe mail pentru a va schimba parola!";
                MessageBox.Show("Codul dumneavoastra este: " + _codAutentificare + "!");
                NextButton.Hide();
                NextButton2.Show();
                EmailTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Nu am gasit emailul in baza noastra de date!\nMai incearca!");
            }
        }

        /// <summary>
        /// Redirectioneaza utilizatorul catre pagina de Log In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogIn form = new LogIn();
            form.Show();
        }

        /// <summary>
        /// Compara codul introdus de utilizator cu cel generat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(EmailTextBox.Text) == _codAutentificare)
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

        /// <summary>
        /// Modifica parola utilizatorului din baza de date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton3_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vicev\OneDrive\Documents\GitHub\Proiect-IP-Glovo\Interfata\Interfata\DataBase.mdf;Integrated Security=True;Connect Timeout=30;");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update [table] set password=@password where mail='" + _userEmail + "'";
            cmd.Parameters.AddWithValue("@password", EmailTextBox.Text);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Parola schimbata cu succes!");
                Hide();
                LogIn form = new LogIn();
                form.Show();
            }

        }
    }
}
