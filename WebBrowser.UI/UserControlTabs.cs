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
    }
}
