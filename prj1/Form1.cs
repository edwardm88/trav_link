using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj1
{
    public partial class Form1 : Form
    {
        private void PerformMemoryCleanup()
        {
            // Force garbage collection
            GC.Collect();
            // Wait for all finalizers to complete before continuing
            GC.WaitForPendingFinalizers();

            this.MinimumSize = new Size(1421, 812);
            this.MinimizeBox = false;   
        }

        private System.Drawing.Size size;
        private System.Drawing.Size sizem;
        private System.Drawing.Size size2;

        private System.Drawing.Point location;
        private System.Drawing.Point location1;
        private System.Drawing.Point location2;
        private System.Drawing.Point location3;

        private System.Drawing.Point location4;
        private System.Drawing.Point location5;

        private System.Drawing.Point locationA;
        private System.Drawing.Point locationB;

        


        public string TextValue
        {
            get { return textBox10.Text; }
            set { textBox10.Text = value; } 
        }

        


        public string TextBoxValue
        {
            get { return textBox10.Text; }
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            size = StaysButton.Size;
            sizem = Mixbutton.Size;
            size2 = button2.Size;
            

            location = StaysButton.Location;
            location1 = flightsButton.Location;
            location2 = taxiButton.Location;
            location3 = Mixbutton.Location;

            location4 = button2.Location;
            location5 =singinButton.Location;   

            locationA = Attractionsbtn.Location;
            locationB = button1.Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Register re = new Register() )
            {
                re.ShowDialog();    
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void StaysButton_MouseHover(object sender, EventArgs e)
        {
            StaysButton.BackColor = Color.LightGreen;
            StaysButton.ForeColor = Color.Black;

            StaysButton.Location = new System.Drawing.Point(location.X - 5, location.Y - 5);
            StaysButton.Size = new System.Drawing.Size(125,50); 
        }

        private void StaysButton_MouseLeave(object sender, EventArgs e)
        {
            StaysButton.BackColor = Color.LimeGreen;
            StaysButton.ForeColor = Color.White;

            StaysButton.Size = size;
            StaysButton.Location = location;
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                using (Flights flights = new Flights())
                {
                    flights.ShowDialog();
                    
                }
            }
            else if(textBox10.Text == "")
            {
                MessageBox.Show("You must to be login to enter here!", "Please login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flightsButton_MouseHover(object sender, EventArgs e)
        {
            flightsButton.BackColor = Color.LightGreen;
            flightsButton.ForeColor = Color.Black;

            flightsButton.Size = new System.Drawing.Size(125, 50);
            flightsButton.Location = new System.Drawing.Point(location1.X - 5,location1.Y - 5);
         }

        private void flightsButton_MouseLeave(object sender, EventArgs e)
        {
            flightsButton.BackColor = Color.LimeGreen;
            flightsButton.ForeColor = Color.White;

            flightsButton.Size = size;
            flightsButton.Location =location1;  
        }

        private void taxiButton_MouseHover(object sender, EventArgs e)
        {
            taxiButton.BackColor = Color.LightGreen;
            taxiButton.ForeColor = Color.Black;

            taxiButton.Size = new System.Drawing.Size(125, 50);
            taxiButton.Location = new System.Drawing.Point(location2.X - 5, location2.Y - 5);
        }

        private void taxiButton_MouseLeave(object sender, EventArgs e)
        {
            taxiButton.BackColor= Color.LimeGreen;
            taxiButton.ForeColor= Color.White;

            taxiButton.Size = size;
            taxiButton.Location = location2;

        }

        private void Mixbutton_MouseHover(object sender, EventArgs e)
        {
            Mixbutton.BackColor = Color.LightGreen;
            Mixbutton.ForeColor = Color.Black;

            Mixbutton.Size = new System.Drawing.Size(185, 50);
            Mixbutton.Location = new System.Drawing.Point(location3.X - 5,location3.Y - 5);
        }

        private void Mixbutton_MouseLeave(object sender, EventArgs e)
        {
            Mixbutton.BackColor= Color.LimeGreen;   
            Mixbutton.ForeColor= Color.White;

            Mixbutton.Size = sizem;
            Mixbutton.Location = location3;
        }

        private void singinButton_MouseHover(object sender, EventArgs e)
        {
            singinButton.BackColor = Color.White;
            singinButton.ForeColor = Color.Black;

            singinButton.Size = new System.Drawing.Size(93,49);
            singinButton.Location = new System.Drawing.Point(location5.X - 3 ,location5.Y - 3);
            singinButton.Font = new Font(singinButton.Font.FontFamily, 16);

        }

        private void singinButton_MouseLeave(object sender, EventArgs e)
        {
            singinButton.BackColor = Color.Honeydew;
            singinButton.ForeColor = Color.Black;

            singinButton.Size = size2;
            singinButton.Location = location5;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = Color.Black;

            button2.Size = new System.Drawing.Size(93, 49);
            button2.Location = new System.Drawing.Point(location4.X - 3, location4.Y - 3);
            button2.Font = new Font (button2.Font.FontFamily, 16);  
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
            button2.ForeColor = Color.Black;

            button2.Size = size2;
            button2.Location = location4;
        }

        private void logoPng_Click(object sender, EventArgs e)
        {
           
        }

        private void StaysButton_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                using(Stays stay = new Stays())
                {
                    stay.ShowDialog();  
                }
            }
            else if(textBox10.Text == "")
            {
                MessageBox.Show("You must to be login to enter here!", "Please login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void singinButton_Click(object sender, EventArgs e)
        {
            

            if(textBox10.Text != "")
            {
                MessageBox.Show("You are already logged!","Login began!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using(Login login = new Login())
            {
                    login.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void taxiButton_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                using (Taxies taxies = new Taxies())
                {
                    taxies.ShowDialog();
                }
              
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("You must to be login to enter here!", "Please login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Attractionsbtn_Click(object sender, EventArgs e)
        {
            Atractions atractions = new Atractions();
            atractions.Show();
           
        }

        private void Attractionsbtn_MouseHover(object sender, EventArgs e)
        {
            Attractionsbtn.BackColor = Color.Honeydew;
            Attractionsbtn.ForeColor = Color.Black;

            Attractionsbtn.Size = new System.Drawing.Size(205, 40);
            Attractionsbtn.Location = new System.Drawing.Point(Attractionsbtn.Location.X - 3, Attractionsbtn.Location.Y - 3);
        }

        private void Attractionsbtn_MouseLeave(object sender, EventArgs e)
        {
            Attractionsbtn.BackColor= Color.White;  
            Attractionsbtn.ForeColor= Color.Black;

            Attractionsbtn.Size = new System.Drawing.Size(200, 37);
            Attractionsbtn.Location = locationA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Warning warning = new Warning();
            warning.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);
        }

        private void Mixbutton_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
               using (Mix min = new Mix())
                {
                    min.ShowDialog();
                    this.Hide();   
                }
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("You must to be login to enter here!", "Please login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Honeydew;
            button1.ForeColor = Color.Black;

            button1.Size = new System.Drawing.Size(233, 40);
            button1.Location = new System.Drawing.Point(button1.Location.X - 3, button1.Location.Y - 3);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor= Color.Black;
            button1.BackColor= Color.White;

            button1.Size = new System.Drawing.Size(229, 37);
            button1.Location = locationB;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Font = new System.Drawing.Font(button3.Font.FontFamily,12,FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Font = new System.Drawing.Font(button3.Font.FontFamily,12,FontStyle.Regular);
        }

        private void supportclientBtn_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                Solutions solutions = new Solutions();
                
                solutions.Show();
                
            }
            else MessageBox.Show("You must to be login to enter here!", "Please login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
