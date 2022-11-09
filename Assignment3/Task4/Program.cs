
using Task4;

Teacher teacher = new Teacher("Mishu", "Rahman", "mishu1@gmail.com");
teacher.GenerateId();
Console.WriteLine(teacher.Id);
Console.WriteLine(teacher.FullName);
Console.WriteLine(teacher.Email);

Student student = new Student("Mishu", "Rahman", "mishu2@gmail.com");
student.GenerateId();
Console.WriteLine(student.Id);
Console.WriteLine(student.FullName);
Console.WriteLine(student.Email);

Admin admin = new Admin("Mishu", "Rahman", "mishu3@gmail.com");
admin.GenerateId();
Console.WriteLine(admin.Id);
Console.WriteLine(admin.FullName);
Console.WriteLine(admin.Email);

