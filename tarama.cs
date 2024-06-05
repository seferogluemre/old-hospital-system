using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hastane_Sistemi2
{
    public partial class tarama : Form
    {
        public tarama()
        {
            InitializeComponent();
        }

        private void tarama_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("file:///C:/Users/yunus/OneDrive/Masa%C3%BCst%C3%BC/WEB%20TASARIM/slider.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
