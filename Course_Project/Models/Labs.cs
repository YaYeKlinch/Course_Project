using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Course_Project.Models
{
    public class Labs
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[А-ЯҐЄЇІ]+[А-Яа-яЇїЄєҐґІі'-]*$")]
        public string Name { get; set; }
        public int SubjectID { get; set; }

        Subject subject { get; set; }
    }
}
