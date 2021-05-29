using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            welcomeLabel.BackColor = System.Drawing.Color.Transparent;

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Hide();
            LogIn form = new LogIn();
            form.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            Sign_up form = new Sign_up();
            form.Show();
        }
    }
}
