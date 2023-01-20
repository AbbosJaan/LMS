using LMS.DataAccess.Entity;
using LMS.DataAccess.Entity.ManyToManyReletionships;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<InformationMessage> InformationMessages { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Student_Course> Students_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher_Group> Teachers_Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student_Course>().HasKey(am => new
            {
                am.StudentId,
                am.CourseId
            });

            modelBuilder.Entity<Student_Course>().HasOne(m => m.Student).WithMany(am => am.Students_Courses).HasForeignKey(m => m.StudentId);
            modelBuilder.Entity<Student_Course>().HasOne(m => m.Course).WithMany(am => am.Students_Courses).HasForeignKey(m => m.CourseId);




            modelBuilder.Entity<Teacher_Group>().HasKey(am => new
            {
                am.TeacherId,
                am.GroupId
            });
            modelBuilder.Entity<Teacher_Group>().HasOne(t => t.Teacher).WithMany(t => t.Teachers_Groups).HasForeignKey(t => t.TeacherId);
            modelBuilder.Entity<Teacher_Group>().HasOne(t => t.Group).WithMany(t => t.Teachers_Groups).HasForeignKey(t => t.GroupId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
