using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailerForDereje
{
    class IO
    {
        public static string turnIntoString(string inp)//this reads the file and returns it
        {
            string outp; // output
            try
            {

                using (var SR = new StreamReader(inp))
                {
                    outp = SR.ReadToEnd();
                    SR.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Please enter valid locations\n\n " + ex.Message);
                return "ERROR";
            }
            return outp;
        }

        public static int count(string inp)
        {
            int abc = 0;
            foreach (string newline in inp.Split(new[] { '\n' }))
            {
                abc++;
            }
            return abc;
        }
        public static int filecount(string inp)
        {
            return  Directory.GetFiles(inp, "*", SearchOption.AllDirectories).Length;
        }
        
    }
}
