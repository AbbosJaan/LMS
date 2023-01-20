using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Rate
    {
        public int Id { get; set; }
        public decimal Value { get; set; }


        //Topic
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        //Student
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
