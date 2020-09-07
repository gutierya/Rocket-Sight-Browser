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
    public partial class MainFormMod3 : Form
    {
        public MainFormMod3()
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

        //Toolstrip Controls
        //Address Bar
        private void AddressTxtBox_Click(object sender, EventArgs e)
        {
            
        }

        //Go Button functionality
        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
