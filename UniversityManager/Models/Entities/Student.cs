using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManager.Models.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }


        /*Navigation Properties*/
        public virtual Group Group { get; set; }
        public int? GroupId { get; set; }
        
        public string ApplicationUserId { get; set; }
      
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}