using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailerForDereje
{
    class Logger
    {
        public static void Log(RichTextBox rt, string input)
        {
            string previous = rt.Text;
            rt.Text += $"-------------\n{input}\n-------------\n";
        }
        public static string Log(string rt,string input)
        {
            return rt + Environment.NewLine + input;
        }
    }
}
