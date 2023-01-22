using ADO;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

//SqlConnection con = null;

//try
//{
//    // Creating Connection  
//    string ConnectionString = "Data Source = ASUS\\SQLEXPRESS; Initial Catalog=CSharp; Integrated Security = True";
//    con = new SqlConnection(ConnectionString);
//    con.Open();


//    Console.WriteLine("Connection Established Successfully");
//    SqlCommand sqlCommand = new SqlCommand("Select * from Courses", con);
//    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
//    while (sqlDataReader.Read())
//    {
//        Console.WriteLine($"{sqlDataReader["title"].ToString().Trim()} {sqlDataReader[2]} {sqlDataReader[5],-20}");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("OOPs, something went wrong.\n" + e);
//}
//finally
//{   // Closing the connection  
//    con.Close();
//}

//Console.Write("Enter Course Title: ");
//string title = Console.ReadLine();
//Console.Write("\nEnter Course Fees: ");
//double fees = Double.Parse(Console.ReadLine());
//Console.Write("\nEnter Course Class Start Date: ");
//DateTime classStart = DateTime.Parse(Console.ReadLine());
//Console.Write("\nIs Course Open now? ");
//bool isOpen = bool.Parse(Console.ReadLine());

//string insertQuery = "INSERT INTO Courses(title, fees, classStart, isopen, courseid) VALUES(@title, @fees, @classStart, @isOpen, @courseid);";
List<SqlParameter> parameters= new List<SqlParameter>();
//parameters.Add(new SqlParameter("title", title));
//parameters.Add(new SqlParameter("fees", fees));
//parameters.Add(new SqlParameter("classStart", classStart));
//parameters.Add(new SqlParameter("isOpen", isOpen));
//parameters.Add(new SqlParameter("courseid", Guid.NewGuid()));

DataUtility datautility = new DataUtility();
//dataUtility.ExecuteCommand(insertQuery, parameters);

//Select Query
//string selectQuery = "SELECT TOP(10) * from Courses";
//   List<Dictionary<string, object>> result = datautility.ExecuteQuery(selectQuery, parameters);
//Console.WriteLine(result.Count);

//Delete Query
//string deleteQuery = "DELETE FROM Courses WHERE id=6";
//Console.WriteLine(datautility.ExecuteCommand(deleteQuery, parameters));


//Update Query

Console.Write("Enter course title to edit fees: ");
string title = Console.ReadLine();
Console.Write("\nEnter course fees: ");
double fees = Convert.ToDouble(Console.ReadLine());
string updateQuery = "UPDATE Courses SET fees=@fees WHERE title=@title";
parameters.Add(new SqlParameter("title", @title));
parameters.Add(new SqlParameter("fees", @fees));
Console.WriteLine(datautility.ExecuteCommand(updateQuery, parameters));