using LMS.DataAccess.Entity;
using LMS.DataAccess.Entity.ManyToManyReletionships;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<InformationMessage> InformationMessages { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group_Course> Groups_Courses { get; set; }
        public DbSet<Group> Groups { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Group_Course>().HasKey(am => new
            {
                am.GroupId,
                am.CourseId
            });

            modelBuilder.Entity<Group_Course>().HasOne(m => m.Group).WithMany(am => am.Group_Course).HasForeignKey(m => m.GroupId);
            modelBuilder.Entity<Group_Course>().HasOne(m => m.Course).WithMany(am => am.Group_Course).HasForeignKey(m => m.CourseId);




            
            base.OnModelCreating(modelBuilder);
        }
    }
}
