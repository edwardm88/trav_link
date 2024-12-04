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
using System.Diagnostics;

namespace prj1
{
    public partial class Taxies : Form
    {
        public Taxies()
        {
            InitializeComponent();
            destinationtxt.Text += new EventHandler(destinationtxt_Click);
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand Cmd = new OleDbCommand();
        OleDbDataAdapter Da = new OleDbDataAdapter();

        private void textBox7_TextChanged(object sender, EventArgs e)
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

        private void Taxibtn_Click(object sender, EventArgs e)
        {
            if(usertxt.Text == "" || comboBox1.Text == "" || destinationtxt.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please complete all camps!", "Invalid reservation!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string taxies = "INSERT INTO Transport_TB VALUES ('" + usertxt.Text + "','" + comboBox1.Text+ "','" + destinationtxt.Text + "','" + comboBox2.Text + "')";
                Cmd = new OleDbCommand(taxies,con);
                Cmd.ExecuteNonQuery();  
                con.Close();    

                MessageBox.Show("The request had been send!","Transport succes!",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            }
        }

        private void Taxies_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaysButton_Click(object sender, EventArgs e)
        {
            Stays stays = new Stays();  
            stays.Show();
            this.Hide();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();    
            flights.Show();
            this.Hide();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void destinationtxt_Click(object sender, EventArgs e)
        {
            destinationtxt.Text = "";
            Process.Start(new ProcessStartInfo()
                {
                FileName = "https://maps.google.com",
                UseShellExecute = true
            });
            MessageBox.Show("Please select your destination in Google Maps, copy the name, and paste it into the TextBox.");
        }

        private void destinationtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
