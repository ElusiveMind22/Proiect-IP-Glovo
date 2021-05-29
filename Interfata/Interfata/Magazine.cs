using Interfata.Localuri;
using Interfata.Localuri.MagazineFactories;
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
           
           
        }

            private void label1_Click(object sender, EventArgs e)
            {

            }


            private void magazineComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {

               
            }

        private void button2_Click(object sender, EventArgs e)
        {
            try{

                Hide();
                LogIn form = new LogIn();
                form.Show();
            }catch(Exception err)
            {
                Console.WriteLine("{0} Exception caught.", err);
            }

        }

            private void button1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

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
                   else if(magazineComboBox2.Enabled)
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

            catch(ApplicationException ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
                MessageBox.Show("NU AI BIFAT CASUTA!!");
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
                MessageBox.Show("Nu ai selectat Restaurant!!");
              
            }
        }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void magazineComboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                
            }

        private void FastFoodRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RestaurantRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signUpLabel_Click(object sender, EventArgs e)
        {

        }

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

        private void magazineComboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

