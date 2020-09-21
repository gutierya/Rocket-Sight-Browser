using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.Data
{
    public partial class forAdaptersForm : Form
    {
        public forAdaptersForm()
        {
            InitializeComponent();
        }

        private void bookmarksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookmarksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.historyBookmarkDBDataSet);

        }

        private void forAdaptersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'historyBookmarkDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.historyBookmarkDBDataSet.History);
            // TODO: This line of code loads data into the 'historyBookmarkDBDataSet.Bookmarks' table. You can move, or remove it, as needed.
            this.bookmarksTableAdapter.Fill(this.historyBookmarkDBDataSet.Bookmarks);

        }
    }
}
