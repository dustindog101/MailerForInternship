using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MailerForDereje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("Your password is stored in a encrypted file on the machine called PWH.rtz this file is encrypted in AES-256 with padding");
            Application.Run(new Form1());
        }
    }
}
