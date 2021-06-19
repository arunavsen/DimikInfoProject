using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DimikInfoProject.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        public ICollection<CourseAssign> CourseAssigns { get; set; }
    }
}
