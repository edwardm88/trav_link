using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;



namespace prj1
{
    //aplicatiiteste@gmail.com
    //Testeaplicatiicpp
    public partial class Solutions : Form
    {
        public Solutions()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.MinimumSize = new Size(1011, 665);
            this.MaximumSize = new Size(1011, 665);
        }

       

        private void sendbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string toEmail = EmailTxt.Text;
                string subject = Subjectcombo.Text;
                string body = Problemtxt.Text;

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.Credentials = new NetworkCredential(Nametxt.Text, passtxt.Text);
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(Nametxt.Text);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;

                mailMessage.To.Add(toEmail);    
                smtpClient.Send(mailMessage);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Solutions_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
