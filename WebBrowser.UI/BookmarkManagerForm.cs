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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            //get all bookmark items
            var items = BookmarkManager.GetBookmarkItems();
            listBox1.Items.Clear(); //listbox of bookmark form
            
            //Display in listbox
            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetHistoryItems();

            listBox1.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(textBoxSearchResults.Text) || item.URL.Contains(textBoxSearchResults.Text))
                {
                    listBox1.Items.Add(String.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }  
            }
        }

        //clear results button
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //delete bookmark button
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                this.listBox1.Items.RemoveAt(this.listBox1.SelectedIndex);
            }
        }
    }
}
