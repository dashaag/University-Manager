using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManager.Models.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}