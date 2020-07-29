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
using System.Threading;

namespace MailerForDereje
{
    public partial class Form1 : MetroForm
    {
        public static string names = "";
        public static string emails = "";
        public static string attachments = @"NULL";
        //
        public static string cfnames = "";
        public static string clnames = "";
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
            if (Login.check() == true)
            {
                metroButton2.Visible = true;
                metroButton1.Visible = false;
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("A login must be saved before you can start.");
            }
            //cattachments = $@"{attachments}\({attachnum}).pdf";

        }
        

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Internals.load(txtNames,txtEmails, txtattachments);
            statistics.count(tlnamesl, tlemailsl, tattachmentsl, names, emails, attachments);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Login.save(metroTextBox1.Text+":"+metroTextBox2.Text);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < statistics.totalEmails; i++)
            {
                statistics.update(tnamess,temailss,tattachmentss);
                Thread.Sleep(1500);
                Internals.start(this, metroButton2, metroButton1, EMAIL, richTextBox1);
            }
            MessageBox.Show("Done!");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            
            MessageBox.Show("Done!");
        }
    }
}
// ;)