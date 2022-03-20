using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowserCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text != "") webBrowser.Navigate(txtAdres.Text);
            else Text = "No page";
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && txtAdres.Text != "") webBrowser.Navigate(txtAdres.Text);
            else Text = "No page";
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtAdres.Text = webBrowser.Url.ToString();
            Text = webBrowser.DocumentTitle;
            if (webBrowser.CanGoBack) cmdBack.Enabled = true;
            else cmdBack.Enabled = false;
            if (webBrowser.CanGoForward) cmdNext.Enabled = true;
            else cmdNext.Enabled = false;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }
    }
}
