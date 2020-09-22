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
using Microsoft.VisualBasic;

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
        public static int attachnum = 331;
        public static int forloooop = 0;
      //  public string cattachments = attachments+@"\("+attachnum.ToString()+").pdf";
        public Form1()
        {
            InitializeComponent();
            Internals.updateTitle(this);
        }
       
        private void metroButton1_Click(object sender, EventArgs e)
        {
            forloooop = statistics.totalEmails * 2;
            forloooop = Convert.ToInt32(Interaction.InputBox("Enter the amount of emails you would like to send"));
            StringBuilder sb = new StringBuilder();
            if (Login.check() == true)
            {
                metroButton2.Visible = true;
                metroButton1.Visible = false;
            //    var thread2 = new Thread(new ThreadStart(runner));
                //   thread2.Start();
                for (int i = 0; i < forloooop+1-1; i++)
                {
                    statistics.update(tnamess, temailss, tattachmentss);
                    ;
                    Internals.start(this, metroButton2, metroButton1, EMAIL, richTextBox1);


                    metroButton2.Visible = true;
                    metroButton1.Visible = false;
                    foreach (string newline in Form1.names.Split(new[] { '\n' }))
                    {
                        int index = Form1.names.IndexOf(Environment.NewLine);
                        Form1.names = Form1.names.Substring(index + Environment.NewLine.Length);
                        string[] splitter = newline.ToString().Split(' ');
                        Form1.cfnames = splitter[0];
                        Form1.clnames = splitter[1];
                        break;
                    }
                 foreach (string newline in Form1.emails.Split(new[] { '\n' }))//this returns one line at a time
                 {
                    int index = Form1.emails.IndexOf(Environment.NewLine);
                    Form1.emails = Form1.emails.Substring(index + Environment.NewLine.Length);
                    Form1.cemails = newline.ToString();
                    
                       
                        
                            EMAIL.Text = Form1.cemails.TrimEnd();
                        
                        break;
                    
                 }

                    //
                    sb.Append($"email:{EMAIL.Text} full name: {cfnames} {clnames}\n");
                       Internals.SendEmail(this, Form1.cfnames, Form1.clnames, cemails.TrimEnd(), Form1.attachments + @"\\creatpdf1_Data Set " + Form1.attachnum.ToString() + ".pdf");
                        Logger.Log(richTextBox1, $"First:{Form1.cfnames}\nLast:{Form1.clnames}\nEmail:{Form1.cemails}\nAttachment location:{Form1.attachments + @"\creatpdf1_Data Set " + Form1.attachnum.ToString() + ".pdf"}");
                        // more variable work..
                        attachnum++;

                      
                    
                }
                metroButton2.Visible = false;
                metroButton1.Visible = true;
                MessageBox.Show(sb.ToString()); ;
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
                statistics.update(tnamess, temailss, tattachmentss);
                Thread.Sleep(1500);
                //Internals.start(this, metroButton2, metroButton1, EMAIL, richTextBox1);
              

                       metroButton2.Visible = true;
                        metroButton1.Visible = false;
                    foreach (string newline in Form1.names.Split(new[] { '\n' }))
                    {
                        int index = Form1.names.IndexOf(Environment.NewLine);
                        Form1.names = Form1.names.Substring(index + Environment.NewLine.Length);
                        string[] splitter = newline.ToString().Split(' ');
                        Form1.cfnames = splitter[0];
                        Form1.clnames = splitter[1];
                        break;
                    }
                    foreach (string newline in Form1.emails.Split(new[] { '\n' }))//this returns one line at a time
                    {
                        int index = Form1.emails.IndexOf(Environment.NewLine);
                        Form1.emails = Form1.emails.Substring(index + Environment.NewLine.Length);
                        Form1.cemails = newline.ToString();
                        if (this.InvokeRequired)
                        {
                            this.BeginInvoke(new Action(() =>
                            {
                                EMAIL.Text = Form1.cemails.TrimEnd();
                            }));
                            break;
                        }

                        //
                        MessageBox.Show("second");
                        Internals.SendEmail(this, Form1.cfnames, Form1.clnames, EMAIL.Text, Form1.attachments + @"\ (" + Form1.attachnum.ToString() + ").pdf");
                        Logger.Log(richTextBox1, $"First:{Form1.cfnames}\nLast:{Form1.clnames}\nEmail{Form1.cemails}\nAttachment location:{Form1.attachments + @"\( " + Form1.attachnum.ToString() + ").pdf"}");
                        MessageBox.Show("first");
                    }
                }
            //  runner();
            metroButton1.Visible = true;
            metroButton2.Visible = false;
            MessageBox.Show("Done!");
        }
        public  void runner()
        {
            for (int i = 0; i < statistics.totalEmails; i++)
            {
                statistics.update(tnamess, temailss, tattachmentss);
                Thread.Sleep(1500);
                Internals.start(this, metroButton2, metroButton1, EMAIL, richTextBox1);
            }
            this.BeginInvoke(new Action(() =>
            {
                metroButton1.Visible = true;
                metroButton2.Visible = false;
            }));
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            // backgroundWorker1.CancelAsync();
            metroButton1.Visible = true;
            metroButton2.Visible = false;
            MessageBox.Show("Done!");
        }
    }
}
// ;)