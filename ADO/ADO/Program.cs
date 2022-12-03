using System.Data.SqlClient;

SqlConnection con = null;

try
{
    // Creating Connection  
    string ConnectionString = "Data Source = ASUS\\SQLEXPRESS; Initial Catalog=CSharp; Integrated Security = True";
    con = new SqlConnection(ConnectionString);
    con.Open();


    Console.WriteLine("Connection Established Successfully");
    SqlCommand sqlCommand = new SqlCommand("Select * from Courses", con);
    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    while (sqlDataReader.Read())
    {
        Console.WriteLine($"{sqlDataReader["title"].ToString().Trim()} {sqlDataReader[2]} {sqlDataReader[5],-20}");
    }
}
catch (Exception e)
{
    Console.WriteLine("OOPs, something went wrong.\n" + e);
}
finally
{   // Closing the connection  
    con.Close();
}

