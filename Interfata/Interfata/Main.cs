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
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Parent = pictureBox1;

            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            DialogResult iExit;
            iExit = MessageBox.Show("Sigur vrei sa iesi?", "Glovo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                Application.Exit();
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
