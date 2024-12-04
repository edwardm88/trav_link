using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj1
{
    public partial class Stays : Form
    {

        

        public Stays()
        {
            InitializeComponent();
            
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightsButton_MouseHover(object sender, EventArgs e)
        {
            flightsButton.BackColor = Color.LawnGreen;
            flightsButton.ForeColor = Color.Black;
        }

        private void Mixbutton_MouseHover(object sender, EventArgs e)
        {
            Mixbutton.BackColor = Color.LawnGreen;  
            Mixbutton.ForeColor = Color.Black;  
        }

        private void Stays_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
           

            DateTime selecteddata = dateTimePicker1.Value;
            DateTime selecteddata2 = dateTimePicker2.Value;

            string date1 = dateTimePicker1.Value.ToString();
            string date2 = dateTimePicker2.Value.ToString();

            if ((textBox10.Text == "" || comboBox1.Text == "" || adultupdown.Value == 0 || roomupdown.Value == 0 || (selecteddata.ToString("dd-MM-yyyy") == selecteddata2.ToString("dd-MM-yyyy"))))
            {
                MessageBox.Show("Error!You can't make a reservation now!","Please complete all camps!", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
            else
            {
                connection.Open();
                string stays = "INSERT INTO Stays_TB VALUES ('"+textBox10.Text+"','"+comboBox1.Text+"','"+date1+"','"+date2+"','"+roomupdown.Value+"','"+adultupdown.Value+"','"+childupdown.Value+"')";
                command = new OleDbCommand(stays,connection);
                command.ExecuteNonQuery();  
                connection.Close(); 
                MessageBox.Show("Your reservation is created succesfull!","Reservation created!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void childupdown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void singinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already login!", "Already login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account already added", "You already have an account!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Show(); 
            this.Hide();        
        }

        private void Home_Click(object sender, EventArgs e)
        {
             
            this.Close();
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null)
            {
                form1.Show();
            }
        }

        

        private void flightsButton_MouseLeave(object sender, EventArgs e)
        {
           flightsButton.BackColor = Color.LimeGreen;
            flightsButton.ForeColor = Color.Black;
        }

        private void taxiButton_MouseHover(object sender, EventArgs e)
        {
            taxiButton.BackColor = Color.LawnGreen;
            taxiButton.ForeColor = Color.Black; 
        }

        private void taxiButton_MouseLeave(object sender, EventArgs e)
        {
            taxiButton.BackColor = Color.LimeGreen;    
            taxiButton.ForeColor = Color.Black; 
        }

        private void singinButton_MouseHover(object sender, EventArgs e)
        {
            singinButton.BackColor = Color.White;
            singinButton.ForeColor = Color.Black;
        }

        private void singinButton_MouseLeave(object sender, EventArgs e)
        {
            singinButton.BackColor = Color.Honeydew;
            singinButton.ForeColor= Color.Black;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);  
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculs calculs = new Calculs();
            calculs.Show();
        }
    }
}
