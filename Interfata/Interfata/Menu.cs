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

            
            
            label3.Text = _numeLocal;
            label4.Text = _tipDeLocal;


            ciuperciCheckBox.Text = _meniu[0];
            pasteCheckBox.Text = _meniu[1];
            sarmaleCheckBox.Text = _meniu[2];
            mamaligaCheckBox.Text = _meniu[3];
            gulasCheckBox.Text = _meniu[4];
            ciorbaCheckBox.Text = _meniu[5];
            chifteleVegCheckBox.Text = _meniu[6];
            cartofiPaiCheckBox.Text = _meniu[7];


            ciuperciTextBox.Text = "0"; 
            pasteTextBox.Text = "0";
            sarmaleTextBox.Text = "0";
            mamaligaTextBox.Text = "0";
            gulasTextBox.Text = "0";
            ciorbaTextBox.Text = "0";
            chifteleVegTextBox.Text = "0";
            cartofiPaiTextBox.Text = "0";
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
            if (cartofiPaiCheckBox.Checked == true)
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
            if (chifteleVegCheckBox.Checked == true)
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
            if (pasteCheckBox.Checked == true)
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
            if (ciuperciCheckBox.Checked == true)
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
            if (mamaligaCheckBox.Checked == true)
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
            if (sarmaleCheckBox.Checked == true)
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
            if (ciorbaCheckBox.Checked == true)
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
            if (gulasCheckBox.Checked)
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
                pretProdus[0] = Convert.ToDouble(cartofiPaiTextBox.Text) * _preturi[0];
                pretProdus[1] = Convert.ToDouble(pasteTextBox.Text) * _preturi[1];
                pretProdus[2] = Convert.ToDouble(ciuperciTextBox.Text) * _preturi[2];
                pretProdus[3] = Convert.ToDouble(sarmaleTextBox.Text) * _preturi[3];
                pretProdus[4] = Convert.ToDouble(mamaligaTextBox.Text) * _preturi[4];
                pretProdus[5] = Convert.ToDouble(gulasTextBox.Text) * _preturi[5];
                pretProdus[6] = Convert.ToDouble(ciorbaTextBox.Text) * _preturi[6];
                pretProdus[7] = Convert.ToDouble(chifteleVegTextBox.Text) * _preturi[7];

                double total = 0.0;
                for (int i = 0; i < 8; ++i)
                {
                    total += pretProdus[i];
                }
                totalTextBox.Text = total.ToString()+" lei";

            }
            catch(FormatException ex)
            {
                
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
                _meniu[5]+"\t\t"+ _preturi[5].ToString()+" lei",
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
    }
}
