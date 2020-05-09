using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Course_Project.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[А-ЯҐЄЇІ]+[А-Яа-яЇїЄєҐґІі'-]*$")]
        public string Name { get; set; }
        public string Group { get; set; }
        [Required]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }



    }
}
