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

        // 

        // In constructor va fi trimisa o clasa de tip magazin ce are stocate datele necesare paginii.
        public Menu(Locale local)
        {
            InitializeComponent();
            EnableTextBoxes();

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

        private void cartofiPaiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu4CheckBox.Checked == true)
            {
                cartofiPaiTextBox.Enabled = true;
                cartofiPaiTextBox.Text = "";
                cartofiPaiTextBox.Focus();
            }
            else
            {
                cartofiPaiTextBox.Enabled = false;
                cartofiPaiTextBox.Text = "0";
            }


        }

        private void chifteleVegCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu5CheckBox.Checked == true)
            {
                chifteleVegTextBox.Enabled = true;
                chifteleVegTextBox.Text = "";
                chifteleVegTextBox.Focus();
            }
            else
            {
                chifteleVegTextBox.Enabled = false;
                chifteleVegTextBox.Text = "0";
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
            if (menu0CheckBox.Checked == true)
            {
                pasteTextBox.Enabled = true;
                pasteTextBox.Text = "";
                pasteTextBox.Focus();
            }
            else
            {
                pasteTextBox.Enabled = false;
                pasteTextBox.Text = "0";
            }
        }

        private void ciuperciCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu1CheckBox.Checked == true)
            {
                ciuperciTextBox.Enabled = true;
                ciuperciTextBox.Text = "";
                ciuperciTextBox.Focus();
            }
            else
            {
                ciuperciTextBox.Enabled = false;
                ciuperciTextBox.Text = "0";
            }
        }

        private void mamaligaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu2CheckBox.Checked == true)
            {
                mamaligaTextBox.Enabled = true;
                mamaligaTextBox.Text = "";
                mamaligaTextBox.Focus();
            }
            else
            {
                mamaligaTextBox.Enabled = false;
                mamaligaTextBox.Text = "0";
            }
        }

        private void sarmaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu3CheckBox.Checked == true)
            {
                sarmaleTextBox.Enabled = true;
                sarmaleTextBox.Text = "";
                sarmaleTextBox.Focus();
            }
            else
            {
                sarmaleTextBox.Enabled = false;
                sarmaleTextBox.Text = "0";
            }
        }

        private void ciorbaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu6CheckBox.Checked == true)
            {
                ciorbaTextBox.Enabled = true;
                ciorbaTextBox.Text = "";
                ciorbaTextBox.Focus();
            }
            else
            {
                ciorbaTextBox.Enabled = false;
                ciorbaTextBox.Text = "0";
            }

        }

        private void gulasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (menu7CheckBox.Checked)
            {
                gulasTextBox.Enabled = true;
                gulasTextBox.Text = "";
                gulasTextBox.Focus();
            }
            else
            {
                gulasTextBox.Enabled = false;
                gulasTextBox.Text = "0";
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
         
            Hide();
            Bon_de_ordin form = new Bon_de_ordin(_meniu,_preturi, totalTextBox.Text);
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
    }
}
