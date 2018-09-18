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

namespace SendMailCharp
{
    public partial class Form1 : Form
    {
        private MailMessage myMail = new MailMessage();
        private SmtpClient smtpClient = new SmtpClient();

        public Form1()
        {
            InitializeComponent();
            this.myMail.Priority = MailPriority.High;
            this.myMail.BodyEncoding = System.Text.Encoding.UTF8;
            this.myMail.IsBodyHtml = true;
            this.smtpClient.Host = "tarmg.cpall.co.th";
            this.smtpClient.Port = 25;
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string from = this.from.Text;
            string to = this.to.Text;
            string subject = this.subject.Text;
            string body = this.body.Text;

            try
            {

                myMail.To.Clear();
                myMail.CC.Clear();


            //    myMail.From = new MailAddress("ทดสอบแจ้งเตือน WorkFlow Error K2<noreply@cpall.co.th>");

                myMail.From = new MailAddress(from);
                myMail.To.Add(to);



                myMail.Subject = subject;

                myMail.Body = body;


                this.smtpClient.Send(myMail);

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void to_TextChanged(object sender, EventArgs e)
        {

        }

        private void body_TextChanged(object sender, EventArgs e)
        {

        }

   
    }
}
