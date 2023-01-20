using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity.ManyToManyReletionships
{
    public class Student_Course
    {

        // Course connection
        public int CourseId { get; set; }
        public Course Course { get; set; }

        //Student connection
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
