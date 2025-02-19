using Infrastructrer.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructrer.Initializers
{
    public static class Initializer
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {

            #region user
           

            modelBuilder.Entity<ApplicationRole>(e => e.HasData(new ApplicationRole
            {
                Id = "1",
                Name = "User",
                NormalizedName = "USER",
                IsDefulte = false,
                IsDeleteed = false,
            }));
            modelBuilder.Entity<ApplicationRole>(e => e.HasData(new ApplicationRole
            {
                Id = "2",
                Name = "Admin",
                NormalizedName = "ADMIN",
                IsDefulte = false,
                IsDeleteed = false,
            }));

           

            #endregion


            #region role
            modelBuilder.Entity<Applicationuser>(e => e.HasData(new Applicationuser
            {
                Id = "1",
                Email = "user@bishyaka.com",
                EmailConfirmed = true,
                FirstName = "User",
                LastName = "",
                NormalizedEmail = "user@bishyaka.com",
                UserName = "user@bishyaka.com",
                NormalizedUserName = "user@bishyaka.com",
                PhoneNumber = "",
                PasswordHash = "+5e07borWQ==", // 123456
                
            })); 
            modelBuilder.Entity<Applicationuser>(e => e.HasData(new Applicationuser
            {
                Id = "2",
                Email = "admin@bishyaka.com",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "",
                NormalizedEmail = "admin@bishyaka.com",
                UserName = "admin@bishyaka.com",
                NormalizedUserName = "admin@bishyaka.com",
                PhoneNumber = "",
                PasswordHash = "+5e07borWQ==", // 123456
                
            }));
            #endregion



            #region Userrole
            modelBuilder.Entity<Microsoft.AspNetCore.Identity.IdentityUserRole<string>>().HasData(
                           new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "1", RoleId = "1" }, // User assigned "User" role
                           new Microsoft.AspNetCore.Identity.IdentityUserRole<string> { UserId = "2", RoleId = "2" }  // Admin assigned "Admin" role
                       );
            

            #endregion


        }

    }
}
