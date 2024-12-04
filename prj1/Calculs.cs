using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;


namespace prj1
{
    public partial class Calculs : Form
    {


        public Calculs()
        {
            InitializeComponent();

        }

        public double GenerateValut(double min, double max)
        {
            Random random = new Random();

            double randomD = min + (random.NextDouble() * (max - min));

            return randomD;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            double valoare = double.Parse(amountTxt.Text);
            if (fromCurrency.Text == " " && Tocurrency.Text == " " && amountTxt.Text == " ")
            {
                MessageBox.Show("Please complete all spaces!", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double x = 0;
                if (fromCurrency.Text == "Lei" && Tocurrency.Text == "Euro")
                {
                    x = valoare * GenerateValut(0.1990, 0.2020);
                }

                if (fromCurrency.Text == "Lei" && Tocurrency.Text == "USD")
                {
                    x = valoare * GenerateValut(0.1650, 0.1620);
                }

                if (fromCurrency.Text == "Lei" && Tocurrency.Text == "USD")
                {
                    x = valoare * GenerateValut(0.2110, 0.2160);
                }

                if (fromCurrency.Text == "Euro" && Tocurrency.Text == "Lei")
                {
                    x = valoare * GenerateValut(4.9750, 4.970);
                }

                if (fromCurrency.Text == "Euro" && Tocurrency.Text == "USD")
                {
                    x = valoare * GenerateValut(1.0520, 1.0580);
                }

                if (fromCurrency.Text == "Euro" && Tocurrency.Text == "Pound")
                {
                    x = valoare * GenerateValut(0.8320, 0.8360);
                }

                if (fromCurrency.Text == "USD" && Tocurrency.Text == "Euro")
                {
                    x = valoare * GenerateValut(0.9420, 0.9460);
                }

                if (fromCurrency.Text == "USD" && Tocurrency.Text == "Lei")
                {
                    x = valoare * GenerateValut(4.7030, 4.7070);
                }

                if (fromCurrency.Text == "USD" && Tocurrency.Text == "Pound")
                {
                    x = valoare * GenerateValut(0.7850, 0.7890);
                }

                if (fromCurrency.Text == "Pound" && Tocurrency.Text == "USD")
                {
                    x = valoare * GenerateValut(1.2850, 1.2890);
                }

                if (fromCurrency.Text == "Pound" && Tocurrency.Text == "Euro")
                {
                    x = valoare * GenerateValut(1.1970, 1.220);
                }

                if (fromCurrency.Text == "USD" && Tocurrency.Text == "Lei")
                {
                    x = valoare * GenerateValut(5.940, 5.980);
                }

                DisplayConvert.Text = x.ToString();
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);
        }


        public double GenerateValues(double min, double max)
        {
            Random rnd = new Random();

            double randomD = min + (rnd.NextDouble() * (max - min));

            return randomD;

        }


        public void CalculBtn_Click(object sender, EventArgs e)
        {

            if (staysbtn.Checked == false && flightBtn.Checked == false) MessageBox.Show("Please select one option!", "Error on calcul!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (staysbtn.Checked == true)
            {
                Random random = new Random();

                flightBtn.Checked = false;

                double price = 0;

                int adults = (int)AdultsNumber.Value;
                int nights = (int)Nights.Value;

                if (adults == 0) MessageBox.Show("You can't calculate for 0 adults!", "Please select number of adults!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (nights == 0) MessageBox.Show("You can't calculate for 0 nights!", "Please select number of nights!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (destinationBox.Text == "Zurich")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(220, 260) * nights * 1.5;
                    }
                    else price = GenerateValues(220, 260) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(240, 280) * nights * 1.5;
                        }
                        else price = GenerateValues(240, 280) * nights;
                    }
                }

                if (destinationBox.Text == "London")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(200, 230) * nights * 1.5;
                    }
                    else price = GenerateValues(200, 230) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(210, 250) * nights * 1.5;
                        }
                        else price = GenerateValues(210, 250) * nights;
                    }
                }

                if (destinationBox.Text == "Paris")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(200, 210) * nights * 1.5;
                    }
                    else price = GenerateValues(200, 210) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(210, 240) * nights * 1.5;
                        }
                        else price = GenerateValues(210, 240) * nights;
                    }
                }

                if (destinationBox.Text == "New York")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(240, 280) * nights * 1.5;
                    }
                    else price = GenerateValues(240, 280) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(260, 290) * nights * 1.5;
                        }
                        else price = GenerateValues(240, 290) * nights;
                    }
                }

                if (destinationBox.Text == "Berlin")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(180, 200) * nights * 1.5;
                    }
                    else price = GenerateValues(180, 200) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(200, 220) * nights * 1.5;
                        }
                        else price = GenerateValues(200, 220) * nights;
                    }
                }

                if (destinationBox.Text == "Los Angeles")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(230, 260) * nights * 1.5;
                    }
                    else price = GenerateValues(230, 260) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(250, 270) * nights * 1.5;
                        }
                        else price = GenerateValues(250, 270) * nights;
                    }
                }

                if (destinationBox.Text == "Tokyo")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(200, 230) * nights * 1.5;
                    }
                    else price = GenerateValues(200, 230) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(220, 270) * nights * 1.5;
                        }
                        else price = GenerateValues(220, 270) * nights;
                    }
                }

                if (destinationBox.Text == "Bucharest")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(150, 180) * nights * 1.5;
                    }
                    else price = GenerateValues(150, 180) * nights;

                    if (adults > 3)
                    {
                        if (childrenNumber.Value > 0)
                        {
                            price = GenerateValues(170, 200) * nights * 1.5;
                        }
                        else price = GenerateValues(170, 200) * nights;
                    }
                }

                valueLbl.Text = price.ToString("F2");
            }


            if (flightBtn.Checked)
            {
                staysbtn.Checked = false;

                Random random = new Random();
                double price = 0;
                int adults = (int)AdultsNumber.Value;
                int seats = (int)Nights.Value;
                comboBox1.Items.Add("Economic");
                comboBox1.Items.Add("Bussines");
                comboBox1.Items.Add("First Class");

                nightsLbl.Name = "Seats";
                AccomodationTypeLbl.Name = "Seat Type";
                RoomLbl.Name = "Select your departure point";

                if (destinationBox.Text == "Bucharest" && comboBox1.Text == "Zurich")
                {

                    if (childrenNumber.Value > 0)
                    {
                        price = GenerateValues(140, 160) * seats * 1.5;
                    }
                    else price = GenerateValues(150, 180) * seats;

                    
                }

            }
        }

        private void destinationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void amountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) e.Handled = true;
        }
    }
}
