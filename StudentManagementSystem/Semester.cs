using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Semester
    {
        public int Id { get; set; }
        public List<Subject> Subjects { get; } = new List<Subject>();

        public Semester()
        {
        }

        public Semester(int id)
        {
            Id = id;
        }
    }
}
