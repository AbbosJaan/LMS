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
        public int TopicId { get; set; }
        public int StudentId { get; set; }
        public decimal Value { get; set; }
    }
}
