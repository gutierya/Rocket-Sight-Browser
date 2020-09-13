using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UserControlTabs : UserControl
    {
        Stack<string> backLink = new Stack<string>();
        Stack<string> fwdLink = new Stack<string>();

        public UserControlTabs()
        {
            InitializeComponent();
        }

        private void UserControlTabs_Load(object sender, EventArgs e)
        {

        }

        //Toolstip back button
        private void userBackBtn_Click(object sender, EventArgs e)
        {
            //pushing current link to top of fwd stack
            fwdLink.Push(userAddyTextBox.Text);
            String url = userAddyTextBox.Text;
            backLink.Push(url);

            //navigate url
            userCtrlWebBrowser.Navigate(url);
        }

        //BackLinks Field - stack of strings
        public void backLinkField()
        {
            String url = userAddyTextBox.Text;
            backLink.Push(url);
        }

        //Toolstip forward button
        private void userFwdBtn_Click(object sender, EventArgs e)
        {
            foreach (var addy in fwdLink)
            {
                //pushing current link to top of back stack
                backLink.Push(userAddyTextBox.Text);
                String url = userAddyTextBox.Text;
                fwdLink.Pop();

                //navigate url
                userCtrlWebBrowser.Navigate(url);
            }
        }

        //FwdLinks Field - stack of strings
        public void fwdLinkField()
        {
            while (userAddyTextBox.Text != null)
            {
                fwdLink.Push(userAddyTextBox.Text);
            }
        }

        //Toolstip refresh button
        private void userRefreshBtn_Click(object sender, EventArgs e)
        {

        }

        //Toolstip Home button - to be added
        private void userHomeBtn_Click(object sender, EventArgs e)
        {

        }

        ////Toolstip Address textbox 
        private void userAddyTextBox_Click(object sender, EventArgs e)
        {

        }

        //Toolstip Go button
        private void userGoBtn_Click(object sender, EventArgs e)
        {
            String url = userAddyTextBox.Text;
            backLink.Push(url);
        }

        //Webbrowser usercontrol
        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //Text address bar - key Code event handler
        private void userAddyTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String url = userAddyTextBox.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    userAddyTextBox.Text = url;
                    userCtrlWebBrowser.Navigate(url);
                    userCtrlWebBrowser.ScriptErrorsSuppressed = true;
                }
            }
        }
    }
}
