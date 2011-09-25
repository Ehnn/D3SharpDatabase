using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using D3SharpDatabase;

namespace D3Database
{
    class D3DB
    {
        //private static SQLiteConnection Connection;

        public static DBEntities context;

        public static void Connect()
        {
            try
            {
                context = new DBEntities();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*if (Connection == null || Connection.State != System.Data.ConnectionState.Open)
            {
                Connection = new SQLiteConnection(string.Format("Data Source={0}", path));
                Connection.Open();
            }*/
        }

        public static bool IsConnected { get { return context != null; } }

        /*internal static int Update(string table, List<SQLiteParameter> insertParameters, List<SQLiteParameter> whereParameters)
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("DB error connection is not open");
                return -1;
            }

            string sql = "UPDATE {0} SET {1} WHERE {2}";

            var sbInsert = new StringBuilder();
            foreach (var parameter in insertParameters)
                sbInsert.AppendFormat("`{0}`={1},", parameter.ParameterName.Replace("@", ""), parameter.ParameterName);
            sbInsert.Length -= 1;

            var sbWhere = new StringBuilder();
            foreach (var parameter in whereParameters)
                sbInsert.AppendFormat("`{0}`={1},", parameter.ParameterName.Replace("@", ""), parameter.ParameterName);
            sbWhere.Length -= 1;
            
            sql = string.Format(sql, table, sbInsert, whereParameters);

            var command = new SQLiteCommand(sql, Connection);
            command.Parameters.AddRange(insertParameters.ToArray());
            command.Parameters.AddRange(whereParameters.ToArray());
            return command.ExecuteNonQuery();
        }*/
    }
}
