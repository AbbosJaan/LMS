using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ProfilePictureUrl { get; set; }


        //Reletionships
        public List<Student_Course> Students_Courses { get; set; }
        public List<Rate> Rates { get; set; }


        //Group
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
