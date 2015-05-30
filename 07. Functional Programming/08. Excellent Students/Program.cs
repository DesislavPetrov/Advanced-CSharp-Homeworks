using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _08.Excellent_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();
            var excellentStudents = from student in data.Students
                                    where student.Marks.Contains(6)
                                    // here we'll select all students that have at least one mark Excellent (6) into a new anonymous class that holds { FullName + Marks}
                                    select new { FullName = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(", ", student.Marks) };

            // print the result
            foreach (var student in excellentStudents)
            {
                Console.WriteLine("Name: {0}, Grades: {{{1}}},",
                    student.FullName, student.Marks);
            }
        }
    }
}
