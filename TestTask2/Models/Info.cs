using System.Collections.Generic;
using System.Linq;

namespace TestTask2.Models
{
    public class Record
    {
        public string deviceVendor { get; set; }
        public string deviceProduct { get; set; }
        public string deviceVersion { get; set; }
        public string signatureId { get; set; }
        public string severity { get; set; }
        public string name { get; set; }
        public string start { get; set; }
        public string rt { get; set; }
        public string msg { get; set; }
        public string shost { get; set; }
        public string smac { get; set; }
        public string dhost { get; set; }
        public string dmac { get; set; }
        public string suser { get; set; }
        public string suid { get; set; }
        public string externalId { get; set; }
        public string cs1Label { get; set; }
        public string cs1 { get; set; }
    }

    public class Records
    {
        public int Count;
        public string SearchQuery;
        public List<Record> Result = new List<Record>();

        public void Add(Record info)
        {
            Result.Add(info);
            Count = Result.Count;
        }

        public bool Any()
        {
            if (Result.Any())
                return true;
            return false;
        }
    }
}
