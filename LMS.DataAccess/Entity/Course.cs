﻿using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Reletionships
        public List<Group_Course>  Group_Course { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }

    }
}
