using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        //Reletionships

        //Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
