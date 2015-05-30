using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// here we'll make a studentNamespace, that we'll add as reference in the other projects in this solution
namespace StudentsNamespace
{
    // here we'll create a new class Student, that will be used in the other projects in this solution
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        // here we'll create a method that return students data
        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        }
    }
