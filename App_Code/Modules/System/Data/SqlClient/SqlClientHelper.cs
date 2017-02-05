using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Modules.System.Data.SqlClient
{
    public class SqlClientHelper : IDisposable
    {
        private const string CONNECTIONSTRING = "Data Source = localhost; Initial Catalog = ASP; user = user; password = Password_2013";

        private SqlConnection Connection;

        public SqlClientHelper()
        {
            Connection = new SqlConnection(CONNECTIONSTRING);
            Connection.Open();
        }

        public SqlDataReader Query(string statement, params object[] @params)
        {
            if (statement.Trim().ToLower().StartsWith("select"))
            {
                SqlCommand cmd = new SqlCommand(statement, Connection);
                cmd.Prepare();

                MatchCollection Matches = Regex.Matches(statement, "(@[A-z0-9]+)");
                for (int i = 0; i < @params.Length; i++)
                    cmd.Parameters.AddWithValue(Matches[i].Value, @params[i]);

                return cmd.ExecuteReader();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(statement.Trim(), Connection);
                cmd.Prepare();

                MatchCollection Matches = Regex.Matches(statement, "(@[A-z0-9]+)");
                for (int i = 0; i < @params.Length; i++)
                    cmd.Parameters.AddWithValue(Matches[i].Value, @params[i]);

                cmd.ExecuteNonQuery();
                return null;
            }
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}