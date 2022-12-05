using System;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using MySql.Data.MySqlClient;
using TestTask2.Models;
using CsvHelper;
using System.Collections;

namespace TestTask2.Client
{
    public static class Query
    {
       public static string InsertQuery(Records records)
        {
            string cmdString = "";

            MySqlCommand cmd = null;
            MySqlConnection connection = Connection.GetConnection();
            connection.Open();
            try
            {
                foreach (Record record in records.Result)
                {
                    cmdString = $"insert into info values('{record.deviceVendor}','{record.deviceProduct}','{record.deviceVersion}'," +
                        $"'{record.signatureId}','{record.severity}','{record.name}','{record.start}','{record.rt}','{record.msg}','{record.shost}'," +
                        $"'{record.smac}','{record.dhost}','{record.dmac}','{record.suser}','{record.suid}','{record.externalId}','{record.cs1Label}','{record.cs1}')";
                    cmd = new MySqlCommand(cmdString, connection);
                    cmd.ExecuteNonQuery();
                }
                return "Added successfully";
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return "Error while adding";
            }
            finally
            {
                connection.Close();
            }


        }

    }
}

