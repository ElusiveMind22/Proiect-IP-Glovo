/**************************************************************************
 *                                                                        *
 *  File:        Bon_de_ordin.cs                                          *
 *  Copyright:   (c) 2021, Brumă Raluca-Ioana                             *
 *  E-mail:      raluca-ioana.bruma@student.tuiasi.ro                     *
 *  Description: Clasa ce realizeaza un bon de ordine                     *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace Interfata
{
    public partial class Bon_de_ordin : Form
    {
        private readonly Random _random = new Random();
        public Bon_de_ordin(string[] meniuri, double[] preturi, string total)
        {
            InitializeComponent();
            dateTimePicker1.MinDate = dateTimePicker2.MinDate = dateTimePicker3.MinDate = dateTimePicker4.MinDate=DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
            dateTimePicker2.Value = dateTimePicker2.Value.AddMinutes(30);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
        }
       
        private void Bon_de_ordin_Load(object sender, EventArgs e)
        {

        }

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void button_genereaza_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int nrcomanda = rnd.Next(0, 1000);
                textBox_nrcomanda.Text = nrcomanda.ToString();
                
                if (MessageBox.Show("Doriti bon de ordin?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PrintPreviewDialog p = new PrintPreviewDialog();
                    p.Document = new PrintDocument();
                    p.Document.PrintPage += (a, b) =>
                    {
                        Font drawFont = new Font("Arial", 16);
                        Font drawFont1 = new Font("Arial", 12);
                        b.Graphics.DrawString("Bon de comanda:", drawFont, Brushes.Black, 350, 70);
                        b.Graphics.DrawString(textBox_nrcomanda.Text.ToString(), drawFont, Brushes.Black, 550, 70);
                        b.Graphics.DrawString("Firma: Glovo", drawFont1, Brushes.DarkOrange, 150, 50);
                        b.Graphics.DrawString("Localitatea: Iasi", drawFont1, Brushes.DarkOrange, 150, 68);
                        b.Graphics.DrawString("Judetul: Iasi", drawFont1, Brushes.DarkOrange, 150, 88);
                        b.Graphics.DrawString("Data comanda:", drawFont1, Brushes.Red, 150, 140);
                        b.Graphics.DrawString(dateTimePicker3.Value.ToShortDateString(), drawFont1, Brushes.Black, 300, 140);
                        b.Graphics.DrawString(dateTimePicker1.Value.ToLongTimeString(), drawFont1, Brushes.Black, 400, 140);
                        b.Graphics.DrawString("Data livrare:", drawFont1, Brushes.Red, 150, 180);
                        b.Graphics.DrawString(dateTimePicker4.Value.ToShortDateString(), drawFont1, Brushes.Black, 300, 180);
                        b.Graphics.DrawString(dateTimePicker2.Value.ToLongTimeString(), drawFont1, Brushes.Black, 400, 180);
                       
                    };
                    p.ShowDialog();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
            //dateTimePicker2 += dateTimePicker1;
        }

        private void button_genereaza_comanda_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
