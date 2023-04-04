using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace L6_Server
{
    internal class WCFServer : IWCFServer
    {
        public string ConnectToDB(string querry)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\muica\\OneDrive\\Laptop\\Algo Distrib\\L2\\Laboratoare\\L5_6\\Student.mdf\";Integrated Security=True";
            string queryString = querry;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
            string returnat = string.Empty;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Program.id.Add(reader.GetInt32(0));
                    Program.nume.Add(reader.GetString(1));
                    Program.medie.Add(reader.GetDouble(2));
                }
            }
            for (int i = 0; i < Program.id.Count; i++)
            {
                returnat += $"{Program.id[i]} {Program.nume[i]} {Program.medie[i]} {Environment.NewLine}";
            }
            return returnat;
        }
    }
}
