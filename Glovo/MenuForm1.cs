using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glovo
{
    public partial class MenuForm1 : Form
    {
        const double pret_Paste = 25.5;
        const double pret_Ciuperci = 16.8;
        const double pret_Mamaliga = 10.0;
        const double pret_Sarmale = 28.4;
        const double pret_Gulas = 27.0;
        const double pret_CartofiPai = 9.5;
        const double pret_ChifteleVeg = 17.2;
        const double pret_Ciorba = 13.0;

        public MenuForm1()
        {
            InitializeComponent();
            EnableTextBoxes();

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
                pretProdus[0] = Convert.ToDouble(cartofiPaiTextBox.Text) * pret_CartofiPai;
                pretProdus[1] = Convert.ToDouble(pasteTextBox.Text) * pret_Paste;
                pretProdus[2] = Convert.ToDouble(ciuperciTextBox.Text) * pret_Ciuperci;
                pretProdus[3] = Convert.ToDouble(sarmaleTextBox.Text) * pret_Sarmale;
                pretProdus[4] = Convert.ToDouble(mamaligaTextBox.Text) * pret_Mamaliga;
                pretProdus[5] = Convert.ToDouble(gulasTextBox.Text) * pret_Gulas;
                pretProdus[6] = Convert.ToDouble(ciorbaTextBox.Text) * pret_Ciorba;
                pretProdus[7] = Convert.ToDouble(chifteleVegTextBox.Text) * pret_ChifteleVeg;

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
                "Paste\t\t"+pret_Paste.ToString()+" lei",
                "Ciuperci\t\t"+pret_Ciuperci.ToString()+" lei",
                "Mamaliga\t\t"+pret_Mamaliga.ToString()+" lei",
                "Sarmale\t\t"+pret_Sarmale.ToString()+" lei",
                "Cartofi pai\t\t"+pret_CartofiPai.ToString()+" lei",
                "Chiftele\t\t"+pret_ChifteleVeg.ToString()+" lei",
                "Ciorba\t\t"+pret_Ciorba.ToString()+" lei",
                "Gulas\t\t"+pret_Gulas.ToString()+" lei"
            };
            foreach(string txt in text)
            {
                preturiRichTextBox.Text += txt;
                preturiRichTextBox.AppendText("\x0A");
            }
        }
    }
}
