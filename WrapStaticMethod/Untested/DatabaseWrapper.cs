﻿using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace Data
{
    public static class DatabaseWrapper
    {
        public static string GetSingleResult(string sql)
        {
            var connString = (string)new AppSettingsReader().GetValue("ConnectionString", typeof(string));
            var results = "";
            var connection = new SqlConnection(connString);
            var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                results += reader[0] + ",";
            }
            return results.TrimEnd(',');
        }
    }
}
