using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryBookmarkDBDataSetTableAdapters;

namespace WebBrowser.logic
{
    public class HistoryManager
    {
        //Add history item
        public static void AddItemHistory(HistoryItem item)
        {
            try
            {
                var adapter = new HistoryTableAdapter();
                adapter.Insert(item.URL, item.Title, item.Date);
            }
            catch
            {
            }
        }

        //Get history items and return/display from DB
        public static List<HistoryItem> GetHistoryItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                results.Add(item);
            }
            return results;
        }

        //Clear history
        public static void ClearHistory()
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id,row.Date);
            }
        }

        //Remove history
        public static void RemoveHistoryItem(string historyRemove)
        {
            var adapter = new HistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string confirm = string.Format("[{0}] {1} {2}", row.Date, row.Title, row.URL);

                if (confirm == historyRemove)
                {
                    adapter.Delete(row.Id,row.Date);
                    
                }
            }
        }
    }
}
