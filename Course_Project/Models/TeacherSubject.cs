using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Project.Models
{
    public class TeacherSubject
    {
        public int SubjectTeacherID { get; set; }
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }

        Teacher teacher { get; set; }
        Subject subject { get; set; }
    }
}
