using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj1
{
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        OleDbConnection conection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand cmD = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Flights_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void singinButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already login!", "Already login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account already added", "You already have an account!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StaysButton_Click(object sender, EventArgs e)
        {
            Stays stays = new Stays();  
            stays.Show();   
            this.Hide();    
        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {

            DateTime selecteddata = dateTimePicker1.Value;
            DateTime selecteddata2 = dateTimePicker2.Value;

            if (usertxt.Text == "" || airportbox.Text == "" || destinationbox.Text == "" || (selecteddata.ToString("dd-MM-yyyy") == selecteddata2.ToString("dd-MM-yyyy") || dateTimePicker1.Value > dateTimePicker2.Value) || adultsupdown.Value == 0 || seatupdown.Value == 0 || seatbox.Text == ""  || airportbox.Text == destinationbox.Text )
            {
                MessageBox.Show("Error!You can't make a reservation now!", "Please complete all camps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conection.Open();
                string flights = "INSERT INTO Flights_TB VALUES ('" + usertxt.Text + "','" + airportbox.Text + "','" + destinationbox.Text + "','"+dateTimePicker1.Value+"','"+dateTimePicker2.Value+"','"+adultsupdown.Value+"','"+seatupdown.Value+"','"+seatbox.Text+"')";
                cmD = new OleDbCommand(flights,conection);
                cmD.ExecuteNonQuery();
                MessageBox.Show("Reservation made!","Your reservation is done!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void taxiButton_Click(object sender, EventArgs e)
        {
            Taxies taxies = new Taxies();
            taxies.Show();  
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();   
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Linen;
            button3.ForeColor = Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Linen;
            button3.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);  
        }
    }
}
