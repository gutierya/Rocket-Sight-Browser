using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data;


namespace WebBrowser.logic
{
    public class HistoryItem
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; } //tried changing from 'DateTime' to string
    }
}
