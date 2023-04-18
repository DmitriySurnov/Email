using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ErrorBox(String namePolia)
        {
            MessageBox.Show(
                   "Вы не заполнили поле '" + namePolia + "'",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSender.Text))
            {
                ErrorBox("От кого");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRecipient.Text))
            {
                ErrorBox("Кому");
                return;
            }
            string subject = string.IsNullOrWhiteSpace(textBoxSubject.Text) ? "Без темы" :
                textBoxSubject.Text;

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress fromAddress = new MailAddress(textBoxSender.Text);
            // кому отправляем
            MailAddress toAddress = new MailAddress(textBoxRecipient.Text);
            // создаем объект сообщения
            MailMessage message = new MailMessage(fromAddress, toAddress);
            // тема письма
            message.Subject = subject;
            // текст письма
            message.Body = textBoxTextOfLetter.Text;
            // письмо представляет код html
            message.IsBodyHtml = checkBoxHtml.Checked;

            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("surnovdv@gmail.com", "wunyogzdmciasmma");
            //smtp.EnableSsl = true;
            //smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.TargetName = "email_consol";

            smtp.Send(message);
            MessageBox.Show(
               "Письмо успешно отправлено",
               "Оповещение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            textBoxSender.Text = "";
            textBoxRecipient.Text = "";
            textBoxSubject.Text = "";
            textBoxTextOfLetter.Text = "";
            checkBoxHtml.Checked = false;
        }
    }
}
