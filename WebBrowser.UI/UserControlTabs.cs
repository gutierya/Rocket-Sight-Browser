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

        }

        //Toolstip forward button
        private void userFwdBtn_Click(object sender, EventArgs e)
        {

        }

        //Toolstip refresh button
        private void userRefreshBtn_Click(object sender, EventArgs e)
        {

        }

        //Toolstip Home button
        private void userHomeBtn_Click(object sender, EventArgs e)
        {

        }

        ////Toolstip Address textbox navigation
        private void userAddyTextBox_Click(object sender, EventArgs e)
        {

        }

        //Toolstip Go button
        private void userGoBtn_Click(object sender, EventArgs e)
        {

        }

        //Webbrowser usercontrol
        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
