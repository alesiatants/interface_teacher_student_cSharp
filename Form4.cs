using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Class_Student_Teacher
{
    public partial class Form4 : Form
    {
        CourseWork coursework;
        string email;
        string name;
        public Form4(CourseWork work, string _email, string _name)
        {
            InitializeComponent();
            coursework = work;
            email = _email;
            name = _name;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CourseWork res = new CourseWork();
            this.richTextBoxtitle.Text = coursework.Заголовок;
            this.richTextBoxdescription.Text = coursework.Описание;
            this.richTextBoxdate.Text = coursework.ДатаСдачи.Day + "." + coursework.ДатаСдачи.Month + "." + coursework.ДатаСдачи.Year;
            if (coursework.ДатаСдачи != res.ДатаСдачи)
            {
                this.richTextBoxdate.ForeColor = Color.Red;
                send();
            }
            else
            {
                this.richTextBoxdate.ForeColor = Color.Green;
            }
            //SendMail();
           /* MailAddress fromAdress = new MailAddress("alesiatantsiurenko@gmail.com", "Alesia");
            MailAddress toAddress = new MailAddress(email, "Evgenia");
            MailMessage message = new MailMessage(fromAdress, toAddress);
            message.Body = "Просроченна дата сдачи курсовой! " + coursework.ДатаСдачи;
            message.Subject = "Курсовая '" + coursework.Заголовок + "'" ;
            SmtpClient smptClient = new SmtpClient();
            smptClient.Host = "smtp.gmail.com";
            smptClient.Port = 587;
            smptClient.EnableSsl = true;
            smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptClient.UseDefaultCredentials = false;
            smptClient.Credentials = new NetworkCredential(fromAdress.Address, "aszddjusactkdglf");
            smptClient.Send(message);*/
        }
        public void send()
        {
            MailAddress fromAdress = new MailAddress("alesiatantsiurenko@gmail.com", "Alesia");
            MailAddress toAddress = new MailAddress(email, name);
            MailMessage message = new MailMessage(fromAdress, toAddress);
            message.Body = "Просроченна дата сдачи курсовой! " + coursework.ДатаСдачи;
            message.Subject = "Курсовая '" + coursework.Заголовок + "'";
            SmtpClient smptClient = new SmtpClient();
            smptClient.Host = "smtp.gmail.com";
            smptClient.Port = 587;
            smptClient.EnableSsl = true;
            smptClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smptClient.UseDefaultCredentials = false;
            smptClient.Credentials = new NetworkCredential(fromAdress.Address, "aszddjusactkdglf");
            smptClient.Send(message);
        }
        /*public static void SendMail()
        {
            var fromAddress = new MailAddress("alesiatantsiurenko@gmail.com", "From Name");
            var toAddress = new MailAddress("Mpoltorackiy@gmail.com", "To Name");
            const string fromPassword = "gm040711";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }*/
    }
}
