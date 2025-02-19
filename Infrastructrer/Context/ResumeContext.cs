using Infrastructrer.Entities;
using Infrastructrer.Initializers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructrer.Context
{


    public class ResumeContext : IdentityDbContext<Applicationuser,ApplicationRole,string>
    {
        public ResumeContext(DbContextOptions<ResumeContext> options) : base(options) { }

        public DbSet<Resume> Resumes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
            //modelBuilder.BuildRelations();
          
        }

       
    }
}
