using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyLife.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Accesemp> Accesemps { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminName = "Arsentiy";
            string adminSurname = "Zhunussov";
            string adminPassword = "123456";

            
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };
            User adminUser = new User { UserId = 1, Email = adminEmail, Name = adminName , Surname = adminSurname ,  Password = adminPassword, RoleId = adminRole.Id };
            User user1 = new User { Email = "bauyrzhan@mail.ru", Name = "Bauyrzhan", Surname = "Taimanov", Password = "123456", RoleId = 2 };
            User user2 = new User {  Email = "askarove@mail.ru", Name = "Айша", Surname = "Аскарова", Password = "123456", RoleId = 2 };
            User user3 = new User {  Email = "alisher@mail.ru", Name = "Alisher", Surname = "Kuanyshbekov", Password = "123456", RoleId = 2 };
            User user4 = new User { Email = "dil@mail.ru", Name = "Диляра", Surname = "Нурмуханова", Password = "123456", RoleId = 2 };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
          
            base.OnModelCreating(modelBuilder);
        }
    }
}
