using Newtonsoft.Json;
using TestTask2.Models;
namespace TestTask2.Client
{
    public class SQLClient:ISQLClient
    {
     
        public string SaveData(Records records)
        {

            var answer = Query.InsertQuery(records);
                return answer;
        }
    }
}
    