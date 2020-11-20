using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryBookmarkDBDataSetTableAdapters;
using WebBrowser.Data;

namespace WebBrowser.logic
{
    public class BookmarkManager
    {

        //Add bookmark item to DB
        public static void addItemBookmark(BookmarkItem item)
        {  
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        //Get bookmark items and return/display from DB
        public static List<BookmarkItem> GetBookmarkItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }
            return results;
        }

        //Remove bookmark item
        public static void RemoveBookMarkItem(string bookmarkRemove)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                string confirm = string.Format("[{0}] {1} {2}", row.Id, row.Title, row.URL);

                if (confirm == bookmarkRemove)
                {
                    adapter.Delete(row.Id);
                }
            }
        }

        //Clear bookmark item
        public static void ClearBookMarkItem()
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id);
            }
        }

    }
}
