using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADO
{
    class DataUtility
    {

        private string _connectionString;
        private SqlCommand _sqlCommand;

        public DataUtility()
        {
            _connectionString = @"Server = ASUS\SQLEXPRESS; Database = CSharp; Trusted_Connection = True";
        }
        public DataUtility(string connectionString)
        {
            if (connectionString != null)
            {
                _connectionString = connectionString;
            }
            else
            {
                _connectionString = @"Server = ASUS\SQLEXPRESS; Database = CSharp; Trusted_Connection = True";
            }
                
        }
        public int ExecuteCommand(string commandText, IList<SqlParameter> parameters)
        {
            using SqlCommand cmd = GetCommand(commandText, parameters);
            return cmd.ExecuteNonQuery();
        }
        public object ExecuteScalar(string commandText, IList<SqlParameter> parameters)
        {
            using SqlCommand cmd = GetCommand(commandText, parameters);
            return cmd.ExecuteScalar();
        }
        public List<Dictionary<string, object>> ExecuteQuery(string query, IList<SqlParameter> parameters)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            using SqlCommand cmd = GetCommand(query, parameters);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> dict = new Dictionary<string, object>();
                for(int i=0; i<reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.GetValue(i));
                }
                result.Add(dict);
            }
            return result;
        }
        private SqlCommand GetCommand(string commandText, IList<SqlParameter> parameters)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand cmd = connection.CreateCommand();
            cmd.Connection = connection;
            cmd.CommandText = commandText;
            if(connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            cmd.Parameters.AddRange(parameters.ToArray());
            return cmd;
        }
        
    }
}
