using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
namespace MailerForDereje
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Internals.updateTitle(this);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Locations locations = new Locations();
            locations.Attachments = txtattachments.Text;
            locations.Email = txtEmails.Text;
            locations.Names = txtNames.Text;
            //
            string names = turnIntoString(txtNames.Text);
            foreach (var line in names)
            {
                MessageBox.Show(line.ToString());
            }
        }
        private static string turnIntoString(string inp)//this reads the file and returns it
        {
            string outp; // output
            using (var SR = new StreamReader(inp))
            {
                outp = SR.ReadToEnd();
                SR.Close();
            }
            return outp;
        }
    }
}
