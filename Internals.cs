using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MailerForDereje
{
    class Internals
    {
        public static void updateTitle(Form form1)
        {
            form1.Text = $"AutoMailer by dustin | Total sent:{statistics.totalSent} | last email:{statistics.lastEmail}";
        }
        public static void SendEmail(Form form1, string tofirst, string tolast, string toemail, string attachment)//send mail function
        {
            //variables
         //   MessageBox.Show("THREAD1");
            string fullName = $"{tofirst} {tolast}";
            var fromAddress = new MailAddress(EmailDetails.fromMail, EmailDetails.fromName);
            var toAddress = new MailAddress(toemail.Replace(" ", "").Replace("\n", ""), fullName);
            string fromPassword = EmailDetails.fromPass;
            const string subject = EmailDetails.Subject;
            string body = $"{EmailDetails.Body(tofirst, tolast, toemail)}";
            var Attachment = new Attachment(attachment);
            statistics.lastEmail = toemail;
            statistics.lastName = $"{tofirst} {tolast}";
            statistics.lastAttachment = attachment;
            //
            statistics.totalSent++;
            statistics.totalsentEmails++;
            statistics.totalsentNames++;
            statistics.totalsentAttachments++;
            //
            statistics.totalNames--;
            statistics.totalEmails--;
            statistics.totalAttachments--;
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
            catch (Exception ex)//error handelign
            {

                MessageBox.Show($"ERRORRRRRRRRRRRRRRRRRR#@$%#@^%#$@$$@#$; Error message:{ex.Message}\nWhat does this mean? Well it likely means your mail isnt properly configured. make sure to enable insecure programs.");
            }

           // MessageBox.Show("sent");

        }
        public static void load(MetroTextBox txtNames, MetroTextBox txtEmails, MetroTextBox txtattachments)
        {
            Form1.names = IO.turnIntoString(txtNames.Text);
            Form1.emails = IO.turnIntoString(txtEmails.Text);
            Form1.attachments = txtattachments.Text;
            Thread.Sleep(500);
            MessageBox.Show("Done!");
        }
        public static void start(Form f, MetroButton mb2, MetroButton mb1, MetroTextBox EMAIL, RichTextBox richTextBox1)
        {

            if (f.InvokeRequired)
            {
                f.BeginInvoke(new Action(() =>
                {
                    mb2.Visible = true;
                    mb1.Visible = false;
                }));

                //    mb2.Visible = true;
                //    mb1.Visible = false;
                foreach (string newline in Form1.names.Split(new[] { '\n' }))
                {
                    int index = Form1.names.IndexOf(Environment.NewLine);
                    Form1.names = Form1.names.Substring(index + Environment.NewLine.Length);
                    string[] splitter = newline.ToString().Split(' ');
                    Form1.cfnames = splitter[0];
                    Form1.clnames = splitter[1];
                    break;
                }
                foreach (string newline in Form1.emails.Split(new[] { '\n' }))//this returns one line at a time
                {
                    int index = Form1.emails.IndexOf(Environment.NewLine);
                    Form1.emails = Form1.emails.Substring(index + Environment.NewLine.Length);
                    Form1.cemails = newline.ToString();
                    if (f.InvokeRequired)
                    {
                        f.BeginInvoke(new Action(() =>
                        {
                            EMAIL.Text = Form1.cemails.TrimEnd();
                        }));
                        break;
                    }

                    //
                    MessageBox.Show("second");
                    SendEmail(f, Form1.cfnames, Form1.clnames, EMAIL.Text, Form1.attachments + @"\ (" + Form1.attachnum.ToString() + ").pdf");
                    Logger.Log(richTextBox1, $"First:{Form1.cfnames}\nLast:{Form1.clnames}\nEmail{Form1.cemails}\nAttachment location:{Form1.attachments + @"\( " + Form1.attachnum.ToString() + ").pdf"}");
                    MessageBox.Show("first");
                }
            }
        }


            public static void updateStatistics(MetroLabel name, MetroLabel emails, MetroLabel attachments, string Name, string Emails, string Attachments)
            {
                name.Text = Name;
                emails.Text = Emails;
                attachments.Text = Attachments;
            }
        
    }
}




