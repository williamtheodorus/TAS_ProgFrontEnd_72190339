using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TAS_ProgFrontEnd_72190339.Models
{
    public class Student{
        [Required]
        public string studentID { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}