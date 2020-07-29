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
    class statistics
    {
        public static int totalSent = 0;
        public static int totalNames = 0;
        public static int totalEmails = 0;
        public static int totalAttachments = 0;
        //

        public static int totalsentNames = 0;
        public static int totalsentEmails = 0;
        public static int totalsentAttachments = 0;
        //
        public static string lastEmail = null;
        public static string lastName = null;
        public static string lastAttachment = null;
        //
        public static void update(MetroLabel name, MetroLabel emails, MetroLabel attachments)
        {
            name.Text = totalsentNames.ToString();
            emails.Text = totalsentEmails.ToString();
            attachments.Text = totalsentAttachments.ToString();
        }
        public static void count(MetroLabel name, MetroLabel email, MetroLabel attachment,string names,string emails,string attachments)
        {
            totalNames = IO.count(names);
            totalEmails = IO.count(emails);
            totalAttachments = IO.count(attachments);
            name.Text = totalNames.ToString();
            email.Text = totalEmails.ToString();
            attachment.Text = totalAttachments.ToString();
        }

    }
}
