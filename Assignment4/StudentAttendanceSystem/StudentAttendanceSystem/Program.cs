
using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem;
using StudentAttendanceSystem.Entities;
using StudentAttendanceSystem.Services;


SASDbContext sasDbContext = new SASDbContext();

//Admin admin = new Admin("Mishu Rahman", "mishu@rahman", "123456");
//sasDbContext.Add(admin);
//sasDbContext.SaveChanges();

login:
Console.WriteLine("Welcome to Student Attendace System.\n");
//Guest.CollectLoginInfo returns tuple of username, password, usertype
var loginInfo = Guest.CollectLoginInfo();
home:
if (loginInfo.usertype == UserTypes.Admin)
{
    Admin admin = (Admin)Admin.Login(loginInfo);
    admin?.ShowTaskList();

}
else if (loginInfo.usertype == UserTypes.Teacher)
{
    Teacher teacher = (Teacher)Teacher.Login(loginInfo);
    teacher?.ShowTaskList();
}
else if (loginInfo.usertype == UserTypes.Student)
{
    Student student = (Student)Student.Login(loginInfo);
    student?.ShowTaskList();
}
else
{
    Console.WriteLine("Invalid User Type!");
}

Console.WriteLine("\n\nPress 1 to go home page");
Console.WriteLine("Press 2 to Logout");
Console.WriteLine("Press 0 to Exit()");

int choice = Convert.ToInt32(Console.ReadLine());
if(choice== 1)
{
    goto home;
}else if(choice== 2)
{
    goto login;
}
else
{
    Console.WriteLine("End.");
}