using LMS.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.RequestEntity
{
    public class TopicRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        //Reletionships

        //Course
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
