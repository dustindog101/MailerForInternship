using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailerForDereje
{
    class EmailDetails
    {
        public  static string fromMail = Login.email;
        public static string fromPass = Login.pass;
        public static string fromName = Form1.name;
        public static string Subject = Form1.subject;

        //

        public static string Body(string first, string last, string email)
        {
            return Form1.body.Replace("FNAME", first).Replace("LNAME", last).Replace("EMAIL", email);

        }

    }
}
