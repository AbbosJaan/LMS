using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity.ManyToManyReletionships
{
    public class Group_Course
    {

        // Course connection
        public int CourseId { get; set; }
        public Course Course { get; set; }

        //Group connection
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
