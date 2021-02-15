using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManager.Models
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentViewModel> Students { get; set; } 
    }
}