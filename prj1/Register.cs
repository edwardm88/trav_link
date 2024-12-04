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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimumSize = new Size(962, 523);
            this.MaximumSize = new Size(962, 523);    
            
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PRJDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (Nametxt.Text == "" && Passtxt.Text == "" && Conpastxt.Text == "")
            {
                MessageBox.Show("Pleas insert your username and password!", "Register Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Passtxt.Text == Conpastxt.Text)
            {
                conn.Open();
                string register = "INSERT INTO Login_TB VALUES ('" + Nametxt.Text + "','"+Passtxt.Text+"') ";
                cmd = new OleDbCommand(register,conn);
                cmd.ExecuteNonQuery();
                conn.Close();   

                MessageBox.Show("Your account has succesfull created!","Registration Succes!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password doesn't match","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Passtxt.Text = "";
                Conpastxt.Text = "";
                Passtxt.Focus();
            }
    
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn_MouseHover(object sender, EventArgs e)
        {
            registerbtn.BackColor = Color.Lime;
            registerbtn.ForeColor = Color.Black;
        }

        private void registerbtn_MouseLeave(object sender, EventArgs e)
        {
            registerbtn.BackColor = Color.PaleGreen;
            registerbtn.ForeColor = Color.Black;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Passtxt.PasswordChar = '\0';
                Conpastxt.PasswordChar = '\0';
            }
            else
            {
                Passtxt.PasswordChar = '*';
                Conpastxt.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();    
        }
    }
}
