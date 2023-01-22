// See https://aka.ms/new-console-template for more information
using EntityFrameworkExample;
using EntityFrameworkExample.Entities;
using System.Windows.Markup;

TrainingDbContext context = new TrainingDbContext();
/* 
 //Insert Code
Course course = new Course();
course.Title = "JAVA";
course.Fees = 25000;
course.ClassStartDate = Convert.ToDateTime("01-02-2023");
Console.WriteLine(course.ClassStartDate);

context.Add(course);
context.SaveChanges();

Console.WriteLine(course.Fees);
*/

//Select Code
//List<Course> courses = context.Courses.ToList();
//foreach(var course in courses)
//{
//    Console.WriteLine($"{course.Id}  Title: {course.Title}  Fees: {course.Fees}  Start Date: {course.ClassStartDate}");
//}

////Update Code
//Course course = context.Courses.Where(x => x.Title == "C# modified").FirstOrDefault();
//course.Title="C# Advanced";
//context.SaveChanges();