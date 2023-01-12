using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace navegador1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            navegador.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            navegador.Stop();   
        }

        private void webBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void navegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            navegador.Navigate(URLNavega.Text);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            navegador.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            navegador.Refresh();    
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            navegador.GoHome();
        }

        private void URLNavega_Click(object sender, EventArgs e)
        {

        }
    }
}
