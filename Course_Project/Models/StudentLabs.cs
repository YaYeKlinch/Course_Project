using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Project.Models
{
    public class StudentLabs
    {
        public int StudentLabsID { get; set; }
        public int StudentID { get; set; }
        public int LabID { get; set; }

        Student students { get; set;  }
        Labs lab { get; set; }
    }
}
