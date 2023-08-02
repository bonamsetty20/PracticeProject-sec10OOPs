using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProjectSection10_OOPs
{
    public class TeacherWithSubjects
    {
        public Teacher Teacher { get; set; }
        public List<Subject> Subjects { get; set; }

        public TeacherWithSubjects()
        {
            Subjects = new List<Subject>();
        }
    }

}
