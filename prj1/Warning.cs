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
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
            personalidtxt.KeyPress += new KeyPressEventHandler(personalidtxt_KeyPress);
        }

        OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand Cmd = new OleDbCommand();
        OleDbDataAdapter Da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            
            if (countrytxt.Text == "U.S.A.")
            {
                MessageBox.Show("You need to have a visa to travel to U.S.A.!", "Complete this formular if u want to apply to visa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Apply";
            }

            if (countrytxt.Text == "China")
            {
                MessageBox.Show("You need to have a visa to travel to China!", "Complete this formular if u want to apply to visa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Apply";
            }

            if (countrytxt.Text == "Russia")
            {
                MessageBox.Show("You need to have a visa to travel to Russia!", "Complete this formular if u want to apply to visa!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Apply";
            }

            if (countrytxt.Text == "U.K.")
            {
                MessageBox.Show("You need to have a passport to travel to U.K.!", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "Brazil")
            {
                MessageBox.Show("You need to have a passport to travel to Brazil !", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "France")
            {
                MessageBox.Show("You don't need a passport to travel to France!", "To travel to France is necessary to have only your ID!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.Visible = false;
            }

            if (countrytxt.Text == "Japan")
            {
                MessageBox.Show("You need to have a passport to travel to Japan!", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "Canada")
            {
                MessageBox.Show("You need to have a passport to travel to Canada!", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "Mexic")
            {
                MessageBox.Show("You need to have a passport to travel to Mexic!", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "Morroco")
            {
                MessageBox.Show("You need to have a passport to travel to Morroco!", "Complete this formular if u want to make one!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }

            if (countrytxt.Text == "Norway")
            {
                MessageBox.Show("You can go to Norway with your ID Card of Passport!", "If you want a passport,you cand complete this form!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                panel2.Visible = true;
                button2.Text = "Make";
            }
        }



        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Conn.Open();
            string warning = "INSERT INTO Visa_Passport_TB VALUES ('" + firstnametxt.Text + "', '" + lastnametxt.Text + "','" + personalidtxt.Text + "','" + gendertxt.Text + "','" + birthdaydate.Value + "','" + addresstxt.Text + "','" + studyleveltxt.Text + "','" + documenttype.Text + "','" + reasontxt.Text + "','" + workingplacetxt.Text + "')";
            Cmd = new OleDbCommand(warning, Conn);
            Cmd.ExecuteNonQuery();
            Conn.Close();

            MessageBox.Show("Form completed!", "Your form is sent to an administrator!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void personalidtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Warning_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
