using LocaluriLibrary.Localuri;
using LocaluriLibrary.Localuri.MagazineFactories;
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
    public partial class Magazine : Form
    {
        private static ILocalFactory _restFact;
        private static ILocalFactory _fastFact;
        Locale _local;
        public Magazine()
        {
            InitializeComponent();
            magazineComboBox.Hide();
            magazineComboBox2.Hide();
            veziMeniuButton.Hide();
            magazineComboBox.Enabled = false;
            magazineComboBox2.Enabled = false;

            _restFact = new Restaurant();
            _fastFact = new FastFood();

            signUpLabel.BackColor = System.Drawing.Color.Transparent;
            signUpLabel.Parent = pictureBox1;

            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Parent = pictureBox1;

            RestaurantRadio.BackColor = System.Drawing.Color.Transparent;
            RestaurantRadio.Parent = pictureBox1;

            FastFoodRadio.BackColor = System.Drawing.Color.Transparent;
            FastFoodRadio.Parent = pictureBox1;


        }

        /// <summary>
        /// Delogheaza utilizatorul si il redirectioneaza catre fereastra de Log In.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Hide();
                LogIn form = new LogIn();
                form.Show();
            }
            catch (Exception err)
            {
                Console.WriteLine("{0} Exception caught.", err);
            }

        }

        /// <summary>
        /// Permite utilizatorului sa paraseasca aplicatia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Sigur vrei sa iesi?", "Glovo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Redirectioneaza utilizatorul catre fereastra care contine meniul corespunzator localului selectat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void veziMeniuButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (magazineComboBox.Enabled)
                    switch (magazineComboBox.SelectedItem)
                    {
                        case "Splend'eat":
                            _local = _restFact.MakeRestaurant(RestaurantType.SPLENDEAT);

                            break;
                        case "Noodle Pack":
                            _local = _restFact.MakeRestaurant(RestaurantType.NOODLEPACK);
                            break;
                        case "La Cuib":
                            _local = _restFact.MakeRestaurant(RestaurantType.LACUIB);
                            break;
                        case "Oxford":
                            _local = _restFact.MakeRestaurant(RestaurantType.OXFORD);
                            break;
                        case "Cartuf":
                            _local = _restFact.MakeRestaurant(RestaurantType.CARTUF);
                            break;
                        case "Mamma Mia":
                            _local = _restFact.MakeRestaurant(RestaurantType.MAMMAMIA);
                            break;
                        case "Delicio":
                            _local = _restFact.MakeRestaurant(RestaurantType.DELICIO);
                            break;
                        default:
                            throw new Exception();



                    }
                else if (magazineComboBox2.Enabled)
                {
                    switch (magazineComboBox2.SelectedItem)
                    {
                        case "McDonalds":

                            _local = _fastFact.MakeFastFood(FastFoodType.MCDONALDS);
                            break;
                        case "KFC":
                            _local = _fastFact.MakeFastFood(FastFoodType.KFC);
                            break;

                        default:
                            throw new Exception();
                    }
                }
                if (!FastFoodRadio.Checked && !RestaurantRadio.Checked)
                    throw new ApplicationException();

                if (_local == null)
                {
                    MessageBox.Show("_local este NULL!");
                }
                else
                {
                    Hide();
                    Menu form = new Menu(_local);
                    form.Show();
                }
            }

            catch (ApplicationException ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
                MessageBox.Show("NU AI BIFAT CASUTA!!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
                MessageBox.Show("Nu ai selectat Restaurant!!");

            }
        }


        /// <summary>
        /// Afiseaza combo box-ul destinat tipului de local selectat de catre utilizator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectLocal_Click(object sender, EventArgs e)
        {
            try
            {
                if (RestaurantRadio.Checked)
                {
                    magazineComboBox.Enabled = true;
                    magazineComboBox.Show();
                    veziMeniuButton.Show();
                    FastFoodRadio.Hide();
                    RestaurantRadio.Hide();
                    SelectLocal.Hide();

                }
                else
                    if (FastFoodRadio.Checked)
                {
                    magazineComboBox2.Enabled = true;
                    magazineComboBox2.Show();
                    veziMeniuButton.Show();
                    FastFoodRadio.Hide();
                    RestaurantRadio.Hide();
                    SelectLocal.Hide();


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

    }
}

