using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;

namespace prj1
{
    public partial class Mix : Form
    {
        OleDbConnection conection1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand cmD1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();
        public Mix()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Warning warning = new Warning();
            warning.Show(); 
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            DateTime selectdata1 = dateTimePicker3.Value;
            DateTime selectdata2 = dateTimePicker4.Value;
            DateTime selectdata3 = dateTimePicker5.Value;
            DateTime selectdata4 = dateTimePicker6.Value;

            if( selectdata1 < selectdata2 || selectdata3 < selectdata4)
            {
                MessageBox.Show("Please select valid dates!", "Error on selected dates!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            if (Nametxt.Text == "" && Destinationcombo.Text == "" && airportbox.Text == "" && adultsupdown.Value == 0 && seatbox.Text == "" && seatupdown.Value == 0 ||
                adultupdown.Value == 0 && roomsupdown.Value == 0 )
            {
                MessageBox.Show("Please complete all camps!", "Camps are empty!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                conection1.Open();
                string mixing = "INSERT INTO Mixing_TB VALUES ('" + Nametxt.Text + "','" + Destinationcombo.Text + "','" + airportbox.Text + "','" + seatupdown.Value + "','" + seatbox.Text + "','" + adultsupdown.Value + "'" +
                    ",'" + dateTimePicker4.Value + "','" + dateTimePicker3.Value + "','" + adultupdown.Value + "','" + childrenupdown.Value + "','" + roomsupdown.Value + "','" + dateTimePicker5.Value + "','" + dateTimePicker6.Value + "','" + documentsbox.Text + "')";
                cmD1 = new OleDbCommand(mixing, conection1);
                cmD1.ExecuteNonQuery();
                conection1.Close();

                MessageBox.Show("Reservation was succesful made!", "Succesful reservation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StaysButton_Click(object sender, EventArgs e)
        {
            Stays stays = new Stays();
            stays.Show();
            this.Close();   
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
