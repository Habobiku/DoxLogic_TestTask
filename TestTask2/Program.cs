using System;
using System.IO;
using TestTask2.Client;
using Newtonsoft.Json;
using TestTask2.Csv;

namespace TestTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLClient sql = new SQLClient();
            var records = Csv.Csv.GetRecords("/Users/Habob/Downloads/20220601182758.csv");
            string path = "/Users/Habob/Desktop/example";
            var find = Csv.Csv.FindRecord(records, "name", "A cryptographic self test was performed.");
            string result = Csv.Csv.ConvertToJson(find);
            var answer=   sql.SaveData(find);
            Console.WriteLine(answer);
            File.WriteAllText(path, result);

        }
    }
}
