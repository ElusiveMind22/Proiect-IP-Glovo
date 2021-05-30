using LocaluriLibrary.Localuri;
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
    public partial class Menu : Form
    {

        // Variabilele vor fi luate din clasa. sunt 8 date.
        private double[] _preturi;
        private string[] _meniu;
        private string _numeLocal;
        private string _tipDeLocal;
        private double[] _cantitateProduse;

        // 

        // In constructor va fi trimisa o clasa de tip magazin ce are stocate datele necesare paginii.
        public Menu(Locale local)
        {
            InitializeComponent();
            EnableTextBoxes();
            InitCantitate();
            _preturi = local.Preturi;
            _meniu = local.Meniu;
            _numeLocal = local.NumeleDeLocal;
            _tipDeLocal = local.TipDeLocal;

            
            
            LocalLabel.Text = _numeLocal;
            RestaurantLabel.Text = _tipDeLocal;


            menuCheckBox0.Text = _meniu[0];
            menuCheckBox1.Text = _meniu[1];
            menuCheckBox2.Text = _meniu[2];
            menuCheckBox3.Text = _meniu[3];
            menuCheckBox4.Text = _meniu[4];
            menuCheckBox5.Text = _meniu[5];
            menuCheckBox6.Text = _meniu[6];
            menuCheckBox7.Text = _meniu[7];


            menuTextBox1.Text = "0"; 
            menuTextBox0.Text = "0";
            menuTextBox3.Text = "0";
            menuTextBox2.Text = "0";
            menuTextBox7.Text = "0";
            menuTextBox6.Text = "0";
            menuTextBox5.Text = "0";
            menuTextBox4.Text = "0";


            //background transparent
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Parent = pictureBox1;

            menuCheckBox0.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox0.Parent = pictureBox1;

            menuCheckBox1.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox1.Parent = pictureBox1;

            menuCheckBox2.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox2.Parent = pictureBox1;

            menuCheckBox3.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox3.Parent = pictureBox1;

            menuCheckBox4.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox4.Parent = pictureBox1;

            menuCheckBox5.BackColor= System.Drawing.Color.Transparent; 
            menuCheckBox5.Parent = pictureBox1;

            menuCheckBox6.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox6.Parent = pictureBox1;

            menuCheckBox7.BackColor= System.Drawing.Color.Transparent;
            menuCheckBox7.Parent = pictureBox1;

            label2.BackColor= System.Drawing.Color.Transparent;
            label2.Parent = pictureBox1;

            totalLabel.BackColor= System.Drawing.Color.Transparent;
            totalLabel.Parent = pictureBox1;
        }

        private void InitCantitate()
        {
            _cantitateProduse = new double[8];
            for (int i = 0; i < 8; i++)
            {
                _cantitateProduse[i] = 0;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Sigur vrei sa iesi?", "Glovo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        private void resetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
              {
                  foreach (Control control in controls)
                      if (control is TextBox)
                          (control as TextBox).Text = "0";
                      else
                          func(control.Controls);
              };
            func(Controls);
        }

        private void resetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked=false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }



        private void resetButton_Click(object sender, EventArgs e)
        {
            resetTextBoxes();
            resetCheckBoxes();
        }

        private void cartofiPaiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
            if (menuCheckBox4.Checked == true)
            {
                menuTextBox4.Enabled = true;
                menuTextBox4.Text = "";
                menuTextBox4.Focus();
            }
            else
            {
                menuTextBox4.Enabled = false;
                menuTextBox4.Text = "0";
            }


        }

        private void chifteleVegCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (menuCheckBox5.Checked == true)
            {
                menuTextBox5.Enabled = true;
                menuTextBox5.Text = "";
                menuTextBox5.Focus();
            }
            else
            {
                menuTextBox5.Enabled = false;
                menuTextBox5.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox0.Checked == true)
            {
                menuTextBox0.Enabled = true;
                menuTextBox0.Text = "";
                menuTextBox0.Focus();
            }
            else
            {
                menuTextBox0.Enabled = false;
                menuTextBox0.Text = "0";
            }
        }

        private void ciuperciCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox1.Checked == true)
            {
                menuTextBox1.Enabled = true;
                menuTextBox1.Text = "";
                menuTextBox1.Focus();
            }
            else
            {
                menuTextBox1.Enabled = false;
                menuTextBox1.Text = "0";
            }
        }

        private void mamaligaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox2.Checked == true)
            {
                menuTextBox2.Enabled = true;
                menuTextBox2.Text = "";
                menuTextBox2.Focus();
            }
            else
            {
                menuTextBox2.Enabled = false;
                menuTextBox2.Text = "0";
            }
        }

        private void sarmaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox3.Checked == true)
            {
                menuTextBox3.Enabled = true;
                menuTextBox3.Text = "";
                menuTextBox3.Focus();
            }
            else
            {
                menuTextBox3.Enabled = false;
                menuTextBox3.Text = "0";
            }
        }

        private void ciorbaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox6.Checked == true)
            {
                menuTextBox6.Enabled = true;
                menuTextBox6.Text = "";
                menuTextBox6.Focus();
            }
            else
            {
                menuTextBox6.Enabled = false;
                menuTextBox6.Text = "0";
            }

        }

        private void gulasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menuCheckBox7.Checked)
            {
                menuTextBox7.Enabled = true;
                menuTextBox7.Text = "";
                menuTextBox7.Focus();
            }
            else
            {
                menuTextBox7.Enabled = false;
                menuTextBox7.Text = "0";
            }

        }

        private void totalButton_Click(object sender, EventArgs e)
        { try
            {
                double[] pretProdus = new double[8];
                pretProdus[0] = Convert.ToDouble(menuTextBox4.Text) * _preturi[0];
                pretProdus[1] = Convert.ToDouble(menuTextBox0.Text) * _preturi[1];
                pretProdus[2] = Convert.ToDouble(menuTextBox1.Text) * _preturi[2];
                pretProdus[3] = Convert.ToDouble(menuTextBox3.Text) * _preturi[3];
                pretProdus[4] = Convert.ToDouble(menuTextBox2.Text) * _preturi[4];
                pretProdus[5] = Convert.ToDouble(menuTextBox7.Text) * _preturi[5];
                pretProdus[6] = Convert.ToDouble(menuTextBox6.Text) * _preturi[6];
                pretProdus[7] = Convert.ToDouble(menuTextBox5.Text) * _preturi[7];

                double total = 0.0;
                for (int i = 0; i < 8; ++i)
                {
                    total += pretProdus[i];
                }
                totalTextBox.Text = total.ToString()+" lei";

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                totalTextBox.Text = "ERR";
            }
            

        }

        private void preturiRichTextBox_TextChanged(object sender, EventArgs e)
        {
            preturiRichTextBox.Text = "";
            string[] text =
            {
                _meniu[0]+"\t\t"+_preturi[0].ToString()+" lei",
                _meniu[1]+"\t\t"+_preturi[1].ToString()+" lei",
                _meniu[2]+"\t\t"+_preturi[2].ToString()+" lei",
                _meniu[3]+"\t\t"+_preturi[3].ToString()+" lei",
                _meniu[4]+"\t\t"+_preturi[4].ToString()+" lei",
                _meniu[5]+"\t\t"+_preturi[5].ToString()+" lei",
                _meniu[6]+"\t\t"+_preturi[6].ToString()+" lei",
                _meniu[7]+"\t\t"+_preturi[7].ToString()+" lei"
            };
            foreach(string txt in text)
            {
                preturiRichTextBox.Text += txt;
                preturiRichTextBox.AppendText("\x0A");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            Hide();
            Magazine form = new Magazine();
            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PlaseazaComandaButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (totalTextBox.Text == "ERR" || totalTextBox.Text == "" || totalTextBox.Text == "0")
                    throw new Exception();
             
                if (menuCheckBox0.Checked) _cantitateProduse[0] = Convert.ToDouble(menuTextBox0.Text);
                if (menuCheckBox1.Checked) _cantitateProduse[1] = Convert.ToDouble(menuTextBox1.Text);
                if (menuCheckBox2.Checked) _cantitateProduse[2] = Convert.ToDouble(menuTextBox2.Text);
                if (menuCheckBox3.Checked) _cantitateProduse[3] = Convert.ToDouble(menuTextBox3.Text);
                if (menuCheckBox4.Checked) _cantitateProduse[4] = Convert.ToDouble(menuTextBox4.Text);
                if (menuCheckBox5.Checked) _cantitateProduse[5] = Convert.ToDouble(menuTextBox5.Text);
                if (menuCheckBox6.Checked) _cantitateProduse[6] = Convert.ToDouble(menuTextBox6.Text);
                if (menuCheckBox7.Checked) _cantitateProduse[7] = Convert.ToDouble(menuTextBox7.Text);


                Hide();
                BonDeOrdin form = new BonDeOrdin(_meniu, _preturi, totalTextBox.Text, _cantitateProduse);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu poti da comanda fara sa alegi ce sa mananci", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
