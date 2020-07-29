using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MailerForDereje
{
    class Login
    {
        public static string email = "";
        public static string pass = "";
        public static void save(string userpass)
        {
            string[] split = userpass.Split(':');
            email = split[0];
            pass = split[1];
            Thread.Sleep(500);
            MessageBox.Show("Done!");

        }
        public static bool check()
        {
            if (email == "" || pass == "")
            {
                return false;
            }
            return true;
        }
    }
}
