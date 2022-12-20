

using StudentManagementSystem;
using StudentManagementSystem.Services;

SMSDbContext smsDbContext= new SMSDbContext();
Admin admin = new Admin("Mishu Rahman", "mishu@rahman", "123456");

smsDbContext.Add(admin);
smsDbContext.SaveChanges();