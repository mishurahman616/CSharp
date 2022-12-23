
using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem;
using StudentAttendanceSystem.Entities;
using StudentAttendanceSystem.Services;


SASDbContext sasDbContext = new SASDbContext();

//Admin admin = new Admin("Mishu Rahman", "mishu@rahman", "123456");
//sasDbContext.Add(admin);
//sasDbContext.SaveChanges();


DateTime dateTime;

dateTime=Convert.ToDateTime("7AM");
Console.WriteLine(dateTime.ToString());



Console.WriteLine("Welcome to Student Attendace System.\n");
var loginInfo = Guest.CollectLoginInfo();
if (loginInfo.usertype == UserTypes.Admin)
{
    Admin admin = (Admin)Admin.Login(loginInfo);
    admin?.ShowAdminTaskList();

}
else if (loginInfo.usertype == UserTypes.Teacher)
{

}
else if (loginInfo.usertype == UserTypes.Student)
{

}
else
{
    Console.WriteLine("Invalid User Type!");
}

