using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj1
{
    public partial class Atractions : Form
    {
        public Atractions()
        {
            InitializeComponent();
        }

        private void Atractions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if(citybox.Text == "" )
            {
                MessageBox.Show("Please select a city!","You don't select a city!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(dateTimePicker1.Value < dateTimePicker2.Value)
            {
                MessageBox.Show("Please insert an avalable date!","Invalid dates!",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            else
            {
                switch(citybox.SelectedItem.ToString())
                {
                    case "Cluj-Napoca":
                        pictureBox1.BackgroundImage = Properties.Resources.cluj1;
                        textBox3.Text = "Turda Salt Mine";
                        

                        pictureBox2.BackgroundImage = Properties.Resources.cluj2;
                        textBox4.Text = "Hoia Baciu Forest ";

                        pictureBox3.BackgroundImage = Properties.Resources.cluj3;
                        textBox5.Text = "The House of Matthias Corvinus";

                        pictureBox4.BackgroundImage = Properties.Resources.cluj4;
                        textBox6.Text = "Cetatuia Park";

                        pictureBox5.BackgroundImage = Properties.Resources.cluj5;
                        textBox7.Text = "Turda Gorge";

                        pictureBox6.BackgroundImage = Properties.Resources.cluj6;
                        textBox8.Text = "Museum Square";

                        pictureBox7.BackgroundImage = Properties.Resources.cluj7;
                        textBox10.Text = "Central Park";

                        pictureBox8.BackgroundImage = Properties.Resources.cluj8;
                        textBox11.Text = "Botanic Garden";

                        pictureBox9.BackgroundImage = Properties.Resources.cluj9;
                        textBox12.Text = "Cluj Arena";

                        pictureBox10.BackgroundImage = Properties.Resources.cluj10;
                        textBox13.Text = "Feleacu Hill";

                        pictureBox11.BackgroundImage = Properties.Resources.cluj11;
                        textBox14.Text = "Ethnographical Museum of Transylvania";

                        pictureBox12.BackgroundImage = Properties.Resources.cluj12;
                        textBox15.Text = "The reformed Church";
                    break;
                    
                    case "Bucharest":
                        pictureBox1.BackgroundImage = Properties.Resources.buc1;
                        textBox3.Text = "The Palace of the Parliment";

                        pictureBox2.BackgroundImage = Properties.Resources.buc2;
                        textBox4.Text = "The Roumanian Athenaeum";

                        pictureBox3.BackgroundImage = Properties.Resources.buc3;
                        textBox5.Text = "The Village Museum";

                        pictureBox4.BackgroundImage = Properties.Resources.buc4;
                        textBox6.Text = "The Ceausescu's House";

                        pictureBox5.BackgroundImage = Properties.Resources.buc5;
                        textBox7.Text = "The Mogosoaia Palace";

                        pictureBox6.BackgroundImage = Properties.Resources.buc6;
                        textBox8.Text = "The Old Center";

                        pictureBox7.BackgroundImage = Properties.Resources.buc7;
                        textBox10.Text = "The Herastrau Park";

                        pictureBox8.BackgroundImage = Properties.Resources.buc8;
                        textBox11.Text = "Cernica Monastery";

                        pictureBox9.BackgroundImage = Properties.Resources.buc9;
                        textBox12.Text = "Controceni Palace";

                        pictureBox10.BackgroundImage = Properties.Resources.buc10;
                        textBox13.Text = "Grigore Antipa Museum";

                        pictureBox11.BackgroundImage = Properties.Resources.buc11;
                        textBox14.Text = "The Way of Victory";

                        pictureBox12.BackgroundImage = Properties.Resources.buc12;
                        textBox15.Text = "The Triumphal Arch";

                        break;
                    case "Madrid":
                        pictureBox1.BackgroundImage = Properties.Resources.madrid1;
                        textBox3.Text = "Estadio Santiago Bernabeu";
                         
                        pictureBox2.BackgroundImage = Properties.Resources.madrid2;
                        textBox4.Text = "Museo del Prado";

                        pictureBox3.BackgroundImage = Properties.Resources.madrid3;
                        textBox5.Text = "Retiro Park";

                        pictureBox4.BackgroundImage = Properties.Resources.madrid4;
                        textBox6.Text = "Puerta del Sol";

                        pictureBox5.BackgroundImage = Properties.Resources.madrid5;
                        textBox7.Text = "Madrid’s Plaza Mayor";

                        pictureBox6.BackgroundImage = Properties.Resources.madrid6;
                        textBox8.Text = "Temple of Debod";

                        pictureBox7.BackgroundImage = Properties.Resources.madrid7;
                        textBox10.Text = "Almudena Cathedral";

                        pictureBox8.BackgroundImage = Properties.Resources.madrid8;
                        textBox11.Text = "Puerta de Alcalá";

                        pictureBox9.BackgroundImage = Properties.Resources.madrid9;
                        textBox12.Text = "Las Ventas Bullring";

                        pictureBox10.BackgroundImage = Properties.Resources.madrid10;
                        textBox13.Text = "Sorolla Museum";

                        pictureBox11.BackgroundImage = Properties.Resources.madrid11;
                        textBox14.Text = "Campo del Moro";

                        pictureBox12.BackgroundImage = Properties.Resources.madrid12;
                        textBox15.Text = "Madrid’s Botanical Garden";

                        break;
                    case "London":
                        pictureBox1.BackgroundImage = Properties.Resources.london1;
                        textBox3.Text = "The London Eye";

                        pictureBox2.BackgroundImage = Properties.Resources.london2;
                        textBox4.Text = "Tower of the London";

                        pictureBox3.BackgroundImage = Properties.Resources.london3;
                        textBox5.Text = "The National Gallery";

                        pictureBox4.BackgroundImage = Properties.Resources.london4;
                        textBox6.Text = "Buckingham Palace";

                        pictureBox5.BackgroundImage = Properties.Resources.london5;
                        textBox7.Text = "Westminster Abbey";

                        pictureBox6.BackgroundImage = Properties.Resources.london6;
                        textBox8.Text = "Tower Bridge";

                        pictureBox7.BackgroundImage = Properties.Resources.london7;
                        textBox10.Text = "Wembley Stadium";

                        pictureBox8.BackgroundImage = Properties.Resources.london8;
                        textBox11.Text = "Queen Elizabeth Olympic Garden";

                        pictureBox9.BackgroundImage = Properties.Resources.london9;
                        textBox12.Text = "Big Ben";

                        pictureBox10.BackgroundImage = Properties.Resources.london10;
                        textBox13.Text = "Royal Opera House";

                        pictureBox11.BackgroundImage = Properties.Resources.london11;
                        textBox14.Text = "The British Museum";

                        pictureBox12.BackgroundImage = Properties.Resources.london12;
                        textBox15.Text = "Trafalgar Square ";

                        break;
                    case "Paris":
                        pictureBox1.BackgroundImage = Properties.Resources.paris1;
                        textBox3.Text = "Eiffel Tower";

                        pictureBox2.BackgroundImage = Properties.Resources.paris2;
                        textBox4.Text = "DisneyLand";

                        pictureBox3.BackgroundImage = Properties.Resources.paris3;
                        textBox5.Text = "Palace of Versailles";

                        pictureBox4.BackgroundImage = Properties.Resources.paris4;
                        textBox6.Text = "The Arc of Triomphe";

                        pictureBox5.BackgroundImage = Properties.Resources.paris5;
                        textBox7.Text = "The Louvre";

                        pictureBox6.BackgroundImage = Properties.Resources.paris6;
                        textBox8.Text = "The Catacombes";

                        pictureBox7.BackgroundImage = Properties.Resources.paris7;
                        textBox10.Text = "Canal Saint Martin";

                        pictureBox8.BackgroundImage = Properties.Resources.paris8;
                        textBox11.Text = "Notre Damme";

                        pictureBox9.BackgroundImage = Properties.Resources.paris9;
                        textBox12.Text = "Stade de France";

                        pictureBox10.BackgroundImage = Properties.Resources.paris10;
                        textBox13.Text = "Orsay Museum";

                        pictureBox11.BackgroundImage = Properties.Resources.paris11;
                        textBox14.Text = "Garnier Palace";

                        pictureBox12.BackgroundImage = Properties.Resources.paris12;
                        textBox15.Text = "Sacré-Cœur";
                        break;
                    default:
                        pictureBox1.BackgroundImage = null;
                        textBox3.Text = "";
                        pictureBox2.BackgroundImage = null;
                        textBox4.Text = "";
                        pictureBox3.BackgroundImage = null;
                        textBox5.Text = "";
                        pictureBox4.BackgroundImage = null;
                        textBox6.Text = "";
                        pictureBox5.BackgroundImage = null;
                        textBox7.Text = "";
                        pictureBox6.BackgroundImage= null;
                        textBox8.Text = "";
                        pictureBox7.BackgroundImage = null;
                        textBox10.Text = "";
                        pictureBox8.BackgroundImage= null;
                        textBox11.Text = "";
                        pictureBox9.BackgroundImage = null;
                        textBox12.Text = "";
                        pictureBox10.BackgroundImage = null;
                        textBox13.Text = "";
                        pictureBox11.BackgroundImage= null;
                        textBox14.Text = "";
                        pictureBox12.BackgroundImage = null;
                        textBox15.Text = "";
           
                        break;
                }
            }
        }

        private void Atractions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            this.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Linen;
            button2.ForeColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Linen;
            button2.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/edy_merticariu/";
            System.Diagnostics.Process.Start(url);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
