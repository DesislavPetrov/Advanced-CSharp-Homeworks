using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _03.StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            // here we'll create an instance of the StudentsData class, so we'll use its IList <Student>
            StudentsData data = new StudentsData();

            // here we'll use LINQ query
            var studentsByName = from student in data.Students
                                 where student.FirstName.CompareTo(student.LastName) < 0
                                 select student;

            // print the result
            foreach (var student in studentsByName)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }

        }
    }
}
