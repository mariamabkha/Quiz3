using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Subject
    {
        public string Name { get; set; }
        public string TeacherName { get; set; }
        public string Prerequisites { get; set; }
        public int Credits { get; set; }
        public int MaxStudents { get; set; }

        //public double GradePoint { get; set; } 

        public Subject()
        {
        }
     /*   public Subject(string name, string prerequisites, int credits, int maxStudents)
        {
            Name = name;
            Prerequisites = prerequisites;
            Credits = credits;
            MaxStudents = maxStudents;
        }
*/


        public Subject(string name, string teacherName, string prerequisites, int credits, int maxStudents)
        {
            Name = name;
            TeacherName = teacherName;
            Prerequisites = prerequisites;
            Credits = credits;
            MaxStudents = maxStudents;
        }

        public Subject(string name, string teacherName, int credits, int maxStudents)
        {
            Name = name;
            TeacherName = teacherName;
            Credits = credits;
            MaxStudents = maxStudents;
        }

        public void AddPrerequisite(string prerequisite)
        {
            Prerequisites += prerequisite + ";";
        }

        
        public string GetPrerequisites()
        {
            return Prerequisites;
        }



        public override string ToString()
        {
            return $"Subject name: {Name}, Prerequisites: {Prerequisites}, Credits: {Credits}, Max Students: {MaxStudents}";
        }
    }
}
