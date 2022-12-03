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
        readonly SqlConnection _connection;
        private SqlCommand _sqlCommand;

        public DataUtility()
        {
            _connection = new SqlConnection("data source=.; database=CSharp; integrated security=SSPI");
        }
        public void GiveSqlCommand(string sqlCommand)
        {
            _sqlCommand = new SqlCommand(sqlCommand);
        }

        
    }
}
