using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class WebBrowsUI : Form
    {
        public WebBrowsUI()
        {
            InitializeComponent();
        }

        //Strip Menu item action
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This browser will be speedy, efficient and a great addition to your Computer!" +
                "\n" + "Created by: Yamilet Gutierrez, ID#904104865");
        }

        //Strip Menu item action
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddressTxtBox_Click(object sender, EventArgs e)
        {

        }

        //Go Button functionality
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string url = AddressTxtBox.Text;
            webBrowser1.Navigate(url);
        }

        //tab control housing webBrowser control
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //Toolstrip Controls
        //Address Bar
        private void AddressTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = AddressTxtBox.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                    MessageBox.Show("You pressed Enter");
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
