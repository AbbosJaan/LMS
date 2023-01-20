using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string AcademicDegree { get; set; }
        public string ProfilePictureUrl { get; set; }

        //Reletionships
        public List<Teacher_Group> Teachers_Groups { get; set; }
    }
}
