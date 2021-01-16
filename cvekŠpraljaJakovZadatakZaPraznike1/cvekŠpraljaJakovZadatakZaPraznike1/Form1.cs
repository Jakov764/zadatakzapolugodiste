using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekŠpraljaJakovZadatakZaPraznike1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void idiBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void gmailBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.gmail.com");
        }

        private void webmailBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://webmail.com");
        }

        private void ispisBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void natragBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void naprijedBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.hr");
        }
    }
}
