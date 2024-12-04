using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace prj1
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            Nametxt.KeyDown += new KeyEventHandler(Nametxt_KeyDown);
            Passtxt.KeyDown += new KeyEventHandler(Passtxt_KeyDown);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.MinimumSize = new Size(941, 526);
            this.MaximumSize = new Size(941, 526);
        }

        

        public string TextBoxValue
        {
            get { return Nametxt.Text; }
        }

       

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {

           

            if (Nametxt.Text == "" && Passtxt.Text == "")
            {
                MessageBox.Show("Pleas insert your username and password!","Login Fail!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    conn.Open();
                    string login = "SELECT * FROM Login_TB WHERE username = '" + Nametxt.Text + "' and password = '" + Passtxt.Text + "' ";
                    cmd = new OleDbCommand(login, conn);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {

                        Form1 ma = new Form1();
                        ma.TextValue = Nametxt.Text;
                        ma.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password don't match!", "Try again later!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Nametxt.Text = "";
                        Passtxt.Text = "";
                    }
                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();    
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.PaleGreen;    
            button2.ForeColor = Color.Black;    
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;    
            button2.ForeColor = Color.LimeGreen;    
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void Nametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Passtxt.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;  
            }
        }

        private void Passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Nametxt.Focus();
            Nametxt.SelectAll();    
        }

        private void Passtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
