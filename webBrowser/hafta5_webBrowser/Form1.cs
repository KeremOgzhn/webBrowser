using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta5_webBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void git_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);
        }

        private void geri_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void dur_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser2.ScriptErrorsSuppressed = true;
        }

        private void webBrowser2_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox1.Text=e.Url.ToString();
            richTextBox1.Text=webBrowser2.DocumentText;
            
        }
        //1.Yol
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13) //ENTER İse
            {
                webBrowser2.Navigate(textBox1.Text);
            }
        }
        //2.Yol
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                webBrowser2.Navigate(textBox1.Text);
            }
        }
    }
}
