using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.logic;


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

        /*Go Button functionality - removed per module 4
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            string url = AddressTxtBox.Text;
            webBrowser1.Navigate(url);
        }
        */

        //tab control housing webBrowser control
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /*Toolstrip Controls Address Bar - removed per module 4
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
        */

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //File Tab - new tab opens when clicked - mod4/5
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTab = new TabPage("Click for new tab!");
            tabControl1.TabPages.Add(myTab);

            UserControl Web = new UserControlTabs();
            Web.Dock = DockStyle.Fill;
            myTab.Controls.Add(Web);

        }

        //File Tab - close tab when clicked 
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            //tabControl1.TabPages.Clear();
        }
   
        //Adding menu item functionality
        private void userControlTabs2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                this.newTabToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control)
            {
                this.closeCurrentTabToolStripMenuItem_Click(sender, e);
            }
        }

        //tools -> manage 'history' functionality - Mod 5 aka "MenuStrip Controls"
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hForm = new HistoryManagerForm();
            hForm.ShowDialog();
        }

        //tools -> manage 'bookmarks' functionality - Mod 5  aka "MenuStrip Controls"
        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mbForm = new BookmarkManagerForm();
            mbForm.ShowDialog();
        }

        //Added module 6 - delete all history items
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
        }


        //unused
        private void actualUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
