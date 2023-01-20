using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity.ManyToManyReletionships
{
    public class Teacher_Group
    {
        //Group connection
        public int GroupId { get; set; }
        public Group Group { get; set; }


        //Teacher connection
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
