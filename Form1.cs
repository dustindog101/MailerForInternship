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
        public string names = "";
        public string emails = "";
        public string attachments = @"NULL";
        //
        public string cfnames = "";
        public string clnames = "";
        public static string cemails = "";
        public static int attachnum = 1;
      //  public string cattachments = attachments+@"\("+attachnum.ToString()+").pdf";
        public Form1()
        {
            InitializeComponent();
            Internals.updateTitle(this);
           
        }
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            Locations locations = new Locations();//this is honestly unneccesary and ill remove it asap
            locations.Attachments = txtattachments.Text;
            locations.Email = txtEmails.Text;
            locations.Names = txtNames.Text;
            //
            
            foreach (string newline in names.Split(new[] { '\n' }))
            {
                int index = names.IndexOf(Environment.NewLine);
                names = names.Substring(index + Environment.NewLine.Length);
                string[] splitter = newline.ToString().Split(' ');
                cfnames = splitter[0];
                clnames = splitter[1];

                break;
                
            }
           foreach (string newline in emails.Split(new[] { '\n' }))
            {
                int index = emails.IndexOf(Environment.NewLine);
                emails = emails.Substring(index +Environment.NewLine.Length);
                cemails = newline.ToString();
                EMAIL.Text = cemails.TrimEnd();
                break;

            }
            //

          // Internals.SendEmail(this,cfnames,clnames,EMAIL.Text, @"C:\Users\dusti\source\repos\MailerForDereje\bin\Debug\test\attachments\(1).pdf");

            MessageBox.Show($"First:{cfnames}\nLast:{clnames}\nEmail{cemails}\nAttachment location:{attachments + @"\(" + attachnum.ToString() + ").pdf"}");
            attachnum++;
            //cattachments = $@"{attachments}\({attachnum}).pdf";

        }
        private static string turnIntoString(string inp)//this reads the file and returns it
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            names = turnIntoString(txtNames.Text);
           emails = turnIntoString(txtEmails.Text);
           attachments = txtattachments.Text;
            MessageBox.Show("Done!");
        }
    }
}
