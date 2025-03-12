using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Course
    {
        [Key]
        public int ld {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUr1 { get; set; }
    }
}
