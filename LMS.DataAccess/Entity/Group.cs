using LMS.DataAccess.Entity.ManyToManyReletionships;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMS.DataAccess.Entity
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        //Reletionships
        [JsonIgnore]
        public virtual ICollection<Group_Course> Group_Course { get; set; }
        //[JsonIgnore]
        public virtual ICollection<ApplicationUser> Students { get; set; }

    }
}
