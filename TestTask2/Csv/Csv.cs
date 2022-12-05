using System;
using CsvHelper;
using System.Globalization;
using System.IO;
using TestTask2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace TestTask2.Csv
{
    public static class Csv
    {
        public static List<Record> GetRecords(string path)
        {
            List<Record> records = null;

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Record>().ToList();
            }

            return records;
        }

        public static Records FindRecord(List<Record> record, string columnName, string columnData)
        {
            string columnFind = $"<{columnName}>k__BackingField";
            Records findRecords = new Records();

            foreach (Record item in record)
            {

                string type = (string)item.GetType().GetField(columnFind, BindingFlags.Instance |
                       BindingFlags.NonPublic |
                       BindingFlags.Public).GetValue(item);
                if (type == columnData)
                {
                    findRecords.Add(item);
                }

            }

            findRecords.SearchQuery = columnName + "=" + columnData;
            return findRecords;
        }

        public static string ConvertToJson(Records records)
        {
            if (records != null)
                return JsonConvert.SerializeObject(records);
            return "Column not found.";
        }
    }
}









