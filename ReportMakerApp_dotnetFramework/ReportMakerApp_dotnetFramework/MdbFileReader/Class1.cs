using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMakerApp_dotnetFramework.MdbFileReader
{
    internal class Class1
    {
        public static void ReadData(string connectionstring, string querystring)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionstring))
            {
                connection.ConnectionString = connectionstring;
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(querystring, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));
                        }
                    }
                }
            }
        }
    }
}
