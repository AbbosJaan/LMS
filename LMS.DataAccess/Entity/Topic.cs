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


        //Reletionships
        public List<Rate> Rates { get; set; }

        //Course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
