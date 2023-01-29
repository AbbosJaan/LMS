using LMS.DataAccess.Entity;
using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.RequestEntity
{
    public class GroupRequest
    {
        public string Name { get; set; }


        //Reletionships
        public List<Group_Course> Group_Course { get; set; }
        public List<ApplicationUser> Students { get; set; }

    }
}
