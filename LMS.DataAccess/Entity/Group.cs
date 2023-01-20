using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        //Students
        public List<Student> Students { get; set; }
        public List<Teacher_Group> Teachers_Groups { get; set; }

    }
}
