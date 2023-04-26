using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Subjects = new List<Subject>();
        }

        public void addSubject(Subject subject)
        {
            if(Subjects.Count < 3)
            {
                Subjects.Add(subject);
            }
            else
            {
                Console.WriteLine("One teacher can only teach 3 subjects max");
            }
        }

        public void changeSubject(Subject subject, Subject newSubject)
        {
            int index = Subjects.IndexOf(subject);
            Subjects[index] = newSubject;
        }

        public override string ToString()
        {
            return $"Teacher: {FirstName} {LastName}, Subjects: {Subjects.Count}";
        }
    }
}
