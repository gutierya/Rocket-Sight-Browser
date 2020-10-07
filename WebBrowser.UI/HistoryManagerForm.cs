using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.logic; //reference

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            //get all history items
            var items = HistoryManager.GetHistoryItems(); //debug why HManager inaccessible now
            listBoxHist.Items.Clear();

            // Display in listbox
            foreach (var item in items)
            {
                listBoxHist.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        //search button history
        private void button1_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetHistoryItems();

            //listBoxHist.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(searchHistoryTextBox.Text) || item.URL.Contains(searchHistoryTextBox.Text))
                {
                    listBoxHist.Items.Add(string.Format("[{0}] ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        //clear history button
        private void button2_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
            listBoxHist.Items.Clear();
        }

        //delete history button
        private void button3_Click(object sender, EventArgs e)
        {
            /* removing old method for better call
            if (this.listBoxHist.SelectedIndex >=0)
            {
                this.listBoxHist.Items.RemoveAt(this.listBoxHist.SelectedIndex);
            }
            */
            string input = listBoxHist.GetItemText(listBoxHist.SelectedItem);

            HistoryManager.RemoveHistoryItem(input);
            listBoxHist.Items.RemoveAt(listBoxHist.SelectedIndex);
        }
    }
}
