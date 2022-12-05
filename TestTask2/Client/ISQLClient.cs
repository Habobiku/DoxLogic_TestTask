using TestTask2.Models;

namespace TestTask2.Client
{
    public interface ISQLClient
    {
        public string SaveData(Records records);
    }
}
