using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.logic; //referencing logic
using System.Globalization;
using System.Text.RegularExpressions;

namespace WebBrowser.UI
{
    public partial class UserControlTabs : UserControl
    {

        //initialization
        public UserControlTabs()
        {
            InitializeComponent();
        }

        //Toolstrip Home button 
        private void userHomeBtn_Click(object sender, EventArgs e)
        {
            string url = "github.com/gutierya";
            userCtrlWebBrowser.Navigate(url);
            userCtrlWebBrowser.ScriptErrorsSuppressed = true;
        }

        //Stack of strings - backinks and forwardlinks 
        Stack<string> backLink = new Stack<string>();
        Stack<string> fwdLink = new Stack<string>();

        //Getter/Setters - Site, Title, Date
        public string URL { get; private set; }
        public object Title { get; private set; }
        public DateTime Date { get; private set; }


        //Back button functionality
        private void userBackBtn_Click(object sender, EventArgs e)
        {
            string url = userAddyTextBox.Text;
            //Pushing current link to top of fwd stack
            fwdLink.Push(url);

            //URL Navigation
            string backNextUrl = backLink.Pop();
            userCtrlWebBrowser.Navigate(backNextUrl);
            userAddyTextBox.Text = backNextUrl;

            //Status label for when pg loading
            timer1.Start();
            toolStripStatusLabel1.Text = "Loading";
            toolStripProgressBar1.Value = 0;
        }

        //BackLinks Field 
        public void backLinkField()
        {
            string url = userAddyTextBox.Text;
            backLink.Push(url);
        }

        //Forward button functionality
        private void userFwdBtn_Click(object sender, EventArgs e)
        {

            //Pushing current link to top of back stack
            string url = userAddyTextBox.Text;
            backLink.Push(url);
            string fwdNextUrl = fwdLink.Pop();

            //URL Navigation
            userCtrlWebBrowser.Navigate(fwdNextUrl);
            userAddyTextBox.Text = fwdNextUrl;

            //Status label for when pg loading
            timer1.Start();
            toolStripStatusLabel1.Text = "Loading";
            toolStripProgressBar1.Value = 0;
        }

        //Forward Links Field 
        public void fwdLinkField()
        {
            while (userAddyTextBox.Text != null)
            {
                fwdLink.Push(userAddyTextBox.Text);
            }
        }

        //Toolstrip refresh button 
        private void userRefreshBtn_Click(object sender, EventArgs e)
        {
            userCtrlWebBrowser.Refresh();

            //Status label for pg refresh
            timer1.Start();
            toolStripStatusLabel1.Text = "Loading";
            toolStripProgressBar1.Value = 0;
        }

        //Toolstrip Go button
        private void userGoBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(userAddyTextBox.Text.ToString());

            String url = userAddyTextBox.Text; 
            userCtrlWebBrowser.Navigate(url);

            //links pushed 
            backLink.Push(url);
            fwdLink.Push(url);

            //Status label for pg navigation
            timer1.Start();
            toolStripStatusLabel1.Text = "Loading";
            toolStripProgressBar1.Value = 0; 
        }

        //Webbrowser usercontrol - after load, add to history table
        private void webBrowser2_Completed(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
                var item = new HistoryItem();
                item.URL = userAddyTextBox.Text;
                item.Title = webBrowser1.DocumentTitle;
                item.Date = DateTime.Now;

                //Adding new history item to db
                HistoryManager.AddItemHistory(item);

                //Statuslabel
                toolStripStatusLabel1.Text = "Done";
                timer1.Stop();
                toolStripProgressBar1.Value = 100;
        }

        //Bookmark button - title and pg URL added to db
        private void userBookmarkBtn_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem(); 
            
            item.URL = userAddyTextBox.Text;
            item.Title = webBrowser1.DocumentTitle;
            
            if (!itemExists(URL))
            {
                BookmarkManager.addItemBookmark(item);
            }
        }

        //If bookmark exists in DB - alert user
        private bool itemExists(string url)
        {
            var test = BookmarkManager.GetBookmarkItems();
            foreach(var i in test)
            {
                if (i.URL.Equals(url))
                {
                    MessageBox.Show("You've already Bookmarked this site");
                    return true;
                }
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.toolStripProgressBar1.Value == 100)
            {
                timer1.Stop();
                toolStripStatusLabel1.Text = "Done";
            }
            else
            {
                this.toolStripProgressBar1.Value++;
            }
        }

        private void userAddyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string url = userAddyTextBox.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    userAddyTextBox.Text = url;
                    userCtrlWebBrowser.Navigate(url);
                    userCtrlWebBrowser.ScriptErrorsSuppressed = true;

                    //links pushed 
                    backLink.Push(url);
                    fwdLink.Push(url);

                    //Status label for keypress 
                    timer1.Start();
                    toolStripStatusLabel1.Text = "Loading";
                    toolStripProgressBar1.Value = 0;
                }
            }
        }
    }
}
