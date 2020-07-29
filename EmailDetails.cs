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
        public const string fromName = "Dustin Hailie";
        public const string Subject = "This is a test emaill";
        //

        public static string Body(string first, string last, string email)
        {
            return $"Hello {first} {last}, this is a test for Mailer made by Dustin blahblahblah" +
                $"" +
                $"" +
                $"If you did not expect this email, please respond saying so." +

                $"Thanks," +
                $"{first} you were chosen to do this ladaldladladlda" +
                $"dustin";

        }

    }
}
