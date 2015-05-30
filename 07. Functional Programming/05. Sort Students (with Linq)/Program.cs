using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _05.Sort_Students__with_Lambda_
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            var sortStudents = from student in data.Students
                               orderby student.FirstName descending
                               orderby student.LastName descending
                               select student;

            // print the result
            foreach (var student in sortStudents)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
