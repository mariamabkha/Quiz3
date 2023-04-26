using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {

        private string _personalNumber;
        private double _gpa;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PersonalNumber
        {
            get { return _personalNumber; }
            set
            {
                if (value.Length <= 11)
                {
                    _personalNumber = value;
                }
                else
                {
                    Console.WriteLine("Personal Number should not exceed 11 digits.");
                }
            }
        }

        public List<Semester> Semesters { get; set; }

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value <= 35)
                {
                    _gpa = value;
                }
                else
                {
                    Console.WriteLine("GPA should not exceed 35.");
                }
            }
        }

        public List<Subject> Subjects { get; } = new List<Subject>();
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

       // public double GPA => Math.Min(CalculateGPA(), 35);

        public Student()
        {
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName, string personalNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
        }



        public void AddSemester(Semester semester)
        {
            Semesters.Add(semester);
        }

        public void AddSubjectToSemester(int semesterId, Subject subject)
        {
            Semester semester = Semesters.Find(s => s.Id == semesterId);
            if (semester != null)
            {
                semester.Subjects.Add(subject);
            }
            else
            {
                Console.WriteLine("Invalid semester id");
            }
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

       


        public List<string> GetCoursesForSemester(int semesterId)
        {
            Semester semester = Semesters.FirstOrDefault(s => s.Id == semesterId);
            if (semester != null)
            {
                return semester.Subjects.Select(s => s.Name).ToList();
            }
            else
            {
                Console.WriteLine("Semester not found");
                return null;
            }
        }

 

  



        public List<string> GetTeachersInfo()
        {
            List<string> teachersInfo = new List<string>();

            foreach (Semester semester in Semesters)
            {
                foreach (Subject subject in semester.Subjects)
                {
                    string teacherInfo = $"{subject.TeacherName}: {subject.Name} ({semester.Id})";
                    teachersInfo.Add(teacherInfo);
                }
            }

            return teachersInfo;
        }



    }

}

