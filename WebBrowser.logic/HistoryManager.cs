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

        /*public object GetHistoryItems()
        {
            throw new NotImplementedException();
        }
        */
    }
}
