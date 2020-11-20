using System;
using System.IO;
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
                "\n" + "Web Browser name: Rocket Sight Browser" +
                "\n" + "Created by: Yamilet Gutierrez");
        }

        //Strip Menu item action
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //File Tab - new tab opens when clicked 
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage myTab = new TabPage("Tab");
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

        //Tools -> manage 'history' functionality 
        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hForm = new HistoryManagerForm();
            hForm.ShowDialog();
        }

        //Tools -> manage 'bookmarks' functionality 
        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mbForm = new BookmarkManagerForm();
            mbForm.ShowDialog();
        }

        //Delete all history items
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
        }

        //Save as HTML
        private void saveAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.InitialDirectory = "c:\\";
                saveFile.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
                saveFile.FilterIndex = 1;
                saveFile.RestoreDirectory = true;
                saveFile.Title = "Save";
                saveFile.ShowDialog();

                if (saveFile.FileName !=" " )
                {
                    // Get the path of specified file
                    FileStream filehere = (FileStream)saveFile.OpenFile();
                    filehere.Close();
                }
            }
        }
    }
}
