using Interfata.Localuri;
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

            
            
            TitluLabel.Text = _numeLocal;
            TipLabel.Text = _tipDeLocal;


     
            menu0CheckBox.Text = _meniu[0];
            menu1CheckBox.Text = _meniu[1];
            menu2CheckBox.Text = _meniu[2];
            menu3CheckBox.Text = _meniu[3];
            menu4CheckBox.Text = _meniu[4];
            menu5CheckBox.Text = _meniu[5];
            menu6CheckBox.Text = _meniu[6];
            menu7CheckBox.Text = _meniu[7];



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Sigur vrei sa iesi?", "Glovo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        private void InitCantitate()
        {
            _cantitateProduse = new double[8]; 
            for(int i=0;i<8;i++)
            {
                _cantitateProduse[i] = 0;
            }
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
            preturiRichTextBox.Text = "";
            resetTextBoxes();
            resetCheckBoxes();
        }

        private void menu4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu4CheckBox.Checked == true)
            {

                menu4CheckBox.Enabled = true;
                menu4CheckBox.Text = "";
                menu4CheckBox.Focus();
            }
            else
            {
                menu4CheckBox.Enabled = false;
                menu4CheckBox.Text = "0";
            }


        }

        private void menu5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu5CheckBox.Checked == true)
            {

                menu5CheckBox.Enabled = true;
                menu5CheckBox.Text = "";
                menu5CheckBox.Focus();
            }
            else
            {
                menu5CheckBox.Enabled = false;
                menu5CheckBox.Text = "0";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu0CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu0CheckBox.Checked == true)
            {

                menu0TextBox.Enabled = true;
                menu0TextBox.Text = "";
                menu0TextBox.Focus();
            }
            else
            {
                menu0TextBox.Enabled = false;
                menu0TextBox.Text = "0";
            }
        }

        private void ciuperciCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu1CheckBox.Checked == true)
            {

                menu1TextBox.Enabled = true;
                menu1TextBox.Text = "";
                menu1TextBox.Focus();
            }
            else
            {
                menu1TextBox.Enabled = false;
                menu1TextBox.Text = "0";
            }
        }

        private void mamaligaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu2CheckBox.Checked == true)
            {

                menu2TextBox.Enabled = true;
                menu2TextBox.Text = "";
                menu2TextBox.Focus();
            }
            else
            {
                menu2TextBox.Enabled = false;
                menu2TextBox.Text = "0";
            }
        }

        private void sarmaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu3CheckBox.Checked == true)
            {

                menu3TextBox.Enabled = true;
                menu3TextBox.Text = "";
                menu3TextBox.Focus();
            }
            else
            {
                menu3TextBox.Enabled = false;
                menu3TextBox.Text = "0";
            }
        }

        private void ciorbaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu6CheckBox.Checked == true)
            {

                menu6TextBox.Enabled = true;
                menu6TextBox.Text = "";
                menu6TextBox.Focus();
            }
            else
            {
                menu6TextBox.Enabled = false;
                menu6TextBox.Text = "0";
            }

        }

        private void gulasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu7CheckBox.Checked)
            {
    
                menu7TextBox.Enabled = true;
                menu7TextBox.Text = "";
                menu7TextBox.Focus();
            }
            else
            {
                menu7TextBox.Enabled = false;
                menu7TextBox.Text = "0";
            }

        }

        private void totalButton_Click(object sender, EventArgs e)
        { try
            {
                double[] pretProdus = new double[8];
                pretProdus[0] = Convert.ToDouble(menu0CheckBox.Text) * _preturi[0];
                pretProdus[1] = Convert.ToDouble(menu1CheckBox.Text) * _preturi[1];
                pretProdus[2] = Convert.ToDouble(menu2CheckBox.Text) * _preturi[2];
                pretProdus[3] = Convert.ToDouble(menu3CheckBox.Text) * _preturi[3];
                pretProdus[4] = Convert.ToDouble(menu4CheckBox.Text) * _preturi[4];
                pretProdus[5] = Convert.ToDouble(menu5CheckBox.Text) * _preturi[5];
                pretProdus[6] = Convert.ToDouble(menu6CheckBox.Text) * _preturi[6];
                pretProdus[7] = Convert.ToDouble(menu7CheckBox.Text) * _preturi[7];

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
                if (totalTextBox.Text == "ERR" || totalTextBox.Text == ""||totalTextBox.Text=="0")
                    throw new Exception();

                if (menu0CheckBox.Checked) _cantitateProduse[0] = Convert.ToInt32(menu0TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[1] = Convert.ToInt32(menu1TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[2] = Convert.ToInt32(menu2TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[3] = Convert.ToInt32(menu3TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[4] = Convert.ToInt32(menu4TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[5] = Convert.ToInt32(menu5TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[6] = Convert.ToInt32(menu6TextBox.Text);
                if (menu0CheckBox.Checked) _cantitateProduse[7] = Convert.ToInt32(menu7TextBox.Text);

                Hide();
            Bon_de_ordin form = new Bon_de_ordin(_meniu,_preturi, totalTextBox.Text, _cantitateProduse);
            form.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nu poti da comanda fara sa alegi ce sa mananci", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error) ;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ciuperciTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu7TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
