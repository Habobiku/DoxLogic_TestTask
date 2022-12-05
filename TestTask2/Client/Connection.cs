using MySql.Data.MySqlClient;
using TestTask2.Models;

namespace TestTask2.Client
{
    public static class Connection
    {
        private static readonly Config _config = Extentions.GetConfig();

        public static MySqlConnection GetConnection()
        {
            string connString = "Server=" + _config.Host + ";Database=" + _config.Database
             + ";port=" + _config.Port + ";User Id=" + _config.User + ";password=" + _config.Password;

            MySqlConnection connection = new MySqlConnection(connString);

            return connection;
        }
    }
        
}
