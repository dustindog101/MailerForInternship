using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace MailerForDereje
{
    class Internals
    {
        public static void updateTitle(Form form1)
        {
            form1.Text = $"AutoMailer by dustin | Total sent:{EmailDetails.totalSent} | last email:{EmailDetails.lastSent}";   
        }
        public static void SendEmail(Form form1, string tofirst, string tolast, string toemail, string attachment)//send mail function
        {
            //variables
            string fullName =$"{tofirst} {tolast}";
            var fromAddress = new MailAddress(EmailDetails.fromMail, EmailDetails.fromName);
            var toAddress = new MailAddress(toemail, fullName);
            const string fromPassword = EmailDetails.fromPass;
            const string subject = EmailDetails.Subject;
            string body = $"{EmailDetails.Body(tofirst, tolast)}";
            var Attachment = new Attachment(attachment);
            EmailDetails.lastSent = toemail;
            EmailDetails.totalSent += 1;
            updateTitle(form1);

            //configure client
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            //configure message
            var message = new MailMessage(fromAddress, toAddress);
            message.Body = body;
            message.Subject = subject;
            message.Attachments.Add(Attachment);
            message.Priority = MailPriority.High;
            
            
                try
                {

                    
                    smtp.Send(message);
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"ERRORRRRRRRRRRRRRRRRRR#@$%#@^%#$@$$@#$; Error message:{ex.Message}\nWhat does this mean? Well it likely means your mail isnt properly configured. make sure to enable insecure programs.");
                }
            


        }
    }
}
