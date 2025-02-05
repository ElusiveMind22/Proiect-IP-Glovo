﻿/**************************************************************************
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
    public partial class BonDeOrdin : Form
    {
        private readonly Random _random = new Random();
        private string[] _meniuri;
        private double[] _preturi;
        private string _total;
        private double[] _cantitateProduse;
        public BonDeOrdin(string[] meniuri, double[] preturi, string total, double[] cantitateProduse)
        {
            _meniuri = meniuri;
            _preturi = preturi;
            _total = total;
            _cantitateProduse = cantitateProduse;

            InitializeComponent();
            dateTimePicker1.MinDate = dateTimePicker2.MinDate = dateTimePicker3.MinDate = dateTimePicker4.MinDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
            dateTimePicker2.Value = dateTimePicker2.Value.AddMinutes(30);
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.Format = DateTimePickerFormat.Custom;

            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Parent = pictureBox1;

            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Parent = pictureBox1;

            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Parent = pictureBox1;

            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Parent = pictureBox1;

            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Parent = pictureBox1;

            dateTimePicker3.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox_nrcomanda.Enabled = false;
        }

        /// <summary>
        /// Genereaza un numar la intamplare care reprezinta numarul de ordin.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        /// <summary>
        /// Daca utilizatorul accepta, i se genereaza un bon pentru produsele achizitionate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_genereaza_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int nrcomanda = rnd.Next(0, 1000);
                textBox_nrcomanda.Text = nrcomanda.ToString();

                if (MessageBox.Show("Doriti bon de ordin?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int val = 300;
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
                        for (int i = 0; i < 8; i++)
                        {
                            if (!(_cantitateProduse[i] == 0))
                            {
                                b.Graphics.DrawString(_meniuri[i] + "\t:\t" + _cantitateProduse[i] + "bucăți\t : \t" + _preturi[i] + " lei bucata", drawFont1, Brushes.Black, 150, val);
                                val += 50;
                            }

                        }
                        b.Graphics.DrawString("Total: " + _total, drawFont1, Brushes.Black, 150, val);

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

        /// <summary>
        /// Trimite comanda si redirectioneaza utilizatorul catre fereastra de Log In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_genereaza_comanda_Click(object sender, EventArgs e)
        {

            Hide();
            LogIn form = new LogIn();
            form.Show();
        }

    }
}
