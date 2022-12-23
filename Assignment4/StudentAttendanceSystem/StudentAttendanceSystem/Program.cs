
using Microsoft.EntityFrameworkCore;
using StudentAttendanceSystem;
using StudentAttendanceSystem.Entities;
using StudentAttendanceSystem.Services;


SASDbContext sasDbContext = new SASDbContext();

//Admin admin = new Admin("Mishu Rahman", "mishu@rahman", "123456");
//sasDbContext.Add(admin);
//sasDbContext.SaveChanges();
foreach (var x in sasDbContext.Attendances.Where(a => a.StudentId == 1 && a.CourseId == 2).ToList())
{
    Console.WriteLine(x.StudentId);
}


Console.WriteLine("Welcome to Student Attendace System.\n");
//Guest.CollectLoginInfo returns tuple of username, password, usertype
var loginInfo = Guest.CollectLoginInfo();
if (loginInfo.usertype == UserTypes.Admin)
{
    Admin admin = (Admin)Admin.Login(loginInfo);
    admin?.ShowTaskList();

}
else if (loginInfo.usertype == UserTypes.Teacher)
{
    Teacher teacher = (Teacher)Teacher.Login(loginInfo);
    teacher.ShowTaskList();
}
else if (loginInfo.usertype == UserTypes.Student)
{
    Student student = (Student)Student.Login(loginInfo);
    student.ShowTaskList();
}
else
{
    Console.WriteLine("Invalid User Type!");
}

