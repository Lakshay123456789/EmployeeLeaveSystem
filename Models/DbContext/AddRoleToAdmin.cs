using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.Entity_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DbContext
{
    public static class AddRoleToAdmin
    {

        public static void ConfigurationUserAndRole(this ModelBuilder modelBuilder)
        {
            //Seeding a  'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper(),
                   
                }
                );
            //Seeding a  'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                    Name = "Employee",
                    NormalizedName = "Employee".ToUpper()
                }
                );
            var hasher = new PasswordHasher<IdentityUser>();
            // Seeding the User to AspNetUsers table
            modelBuilder.Entity<User>().HasData(
               new User()
               {
                   Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                   FirstName="admin".ToUpper(),
                   UserName = "Admin123@gmail.com",
                   Email = "Admin123@gmail.com",
                   NormalizedUserName = "Admin123@gmail.com".ToUpper(),
                   NormalizedEmail = "Admin123@gmail.com".ToUpper(),
                   PasswordHash = hasher.HashPassword(null, "admin@123"),
              
               }
                );


            modelBuilder.Entity<User>().HasData(
         new User()
         {
             Id = "C4623A85-4A75-4020-BD41-D22B366F8ED7",
             FirstName = "user".ToUpper(),
             UserName = "User123@gmail.com",
          Email = "User123@gmail.com",
          NormalizedUserName = "User123@gmail.com".ToUpper(),
          NormalizedEmail = "User123@gmail.com".ToUpper(),
          PasswordHash = hasher.HashPassword(null, "user@123"),
     
      }
       );
            //Seeding the relation between our user and role to AspNetUserRoles table

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", // 2c5e174e-3b0e-446f-86af-483d56fd7210
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9" // 8e445865-a24d-4543-a6c6-9443d048cdb9
                }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "F5ADAFD5-A464-485E-A924-AAFE642619FE", //F5ADAFD5-A464-485E-A924-AAFE642619FE
                    UserId = "C4623A85-4A75-4020-BD41-D22B366F8ED7" //C4623A85-4A75-4020-BD41-D22B366F8ED7
                }
                );
        }
    }
}
