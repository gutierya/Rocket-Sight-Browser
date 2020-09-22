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

        //Toolstip Home button - functionality to be added - module 3
        private void userHomeBtn_Click(object sender, EventArgs e)
        {

        }

        //module 4
        Stack<string> backLink = new Stack<string>();
        Stack<string> fwdLink = new Stack<string>();

        //module 5
        public string URL { get; private set; }
        public object Title { get; private set; }
        public DateTime Date { get; private set; }


        //Toolstip back button - mod 4
        private void userBackBtn_Click(object sender, EventArgs e)
        {
            string url = userAddyTextBox.Text;
            //pushing current link to top of fwd stack
            fwdLink.Push(url);

            //navigate url
            string backNextUrl = backLink.Pop();
            userCtrlWebBrowser.Navigate(backNextUrl);
            userAddyTextBox.Text = backNextUrl;
        }

        //BackLinks Field - stack of strings - mod 4
        public void backLinkField()
        {
            string url = userAddyTextBox.Text;
            backLink.Push(url);
        }

        //Toolstip forward button - mod 4
        private void userFwdBtn_Click(object sender, EventArgs e)
        {

            //pushing current link to top of back stack
            string url = userAddyTextBox.Text;
            backLink.Push(url);
            string fwdNextUrl = fwdLink.Pop();

            //navigate url
            userCtrlWebBrowser.Navigate(fwdNextUrl);
            userAddyTextBox.Text = fwdNextUrl;
        }

        //FwdLinks Field - stack of strings - mod 4
        public void fwdLinkField()
        {
            while (userAddyTextBox.Text != null)
            {
                fwdLink.Push(userAddyTextBox.Text);
            }
        }

        //Toolstip refresh button - mod 3/4
        private void userRefreshBtn_Click(object sender, EventArgs e)
        {
            userCtrlWebBrowser.Refresh();
        }

        //do not delete - creates UI for usercontrol
        private void UserControlTabs_Load(object sender, EventArgs e)
        {

        }



        ////Toolstip Address textbox - added module 4
        private void userAddyTextBox_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(userAddyTextBox.Text.ToString());

            HistoryItem item = new HistoryItem(); //*I need to investigate why it cant access public class even though using "using"

            URL = userAddyTextBox.Text.ToString();
            Title = userAddyTextBox.Text.ToString();
            Date = DateTime.Now;
        }

        //Toolstip Go button
        private void userGoBtn_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(userAddyTextBox.Text.ToString());

            String url = userAddyTextBox.Text; 
            userCtrlWebBrowser.Navigate(url);

            //links pushed 
            backLink.Push(url);
            fwdLink.Push(url);
            
        }

        //Webbrowser usercontrol - mod 4
        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //Text address bar - key Code event handler - mod 4
        private void userAddyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                }
            }
        }

        //bookmark button 
        private void userBookmarkBtn_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem(); //debugging in progress to see why can't access public class
            item.URL = userAddyTextBox.Text;
            item.Title = webBrowser1.DocumentTitle;

            BookmarkManager.addItemBookmark(item);
        }
    }
}
