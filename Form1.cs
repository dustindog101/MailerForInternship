using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailerForDereje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Internals.updateTitle(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Internals.SendEmail(this,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
        }
    }
}
