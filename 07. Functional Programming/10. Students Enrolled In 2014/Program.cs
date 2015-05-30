using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;
using System.Text.RegularExpressions;

namespace _10.Students_Enrolled_In_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            string pattern = @"(?<=\d{4})(14)";
            Regex reg = new Regex(pattern);

            var studentsEnrolled = from student in data.Students
                                   where reg.IsMatch(student.FacultyNumber.ToString())
                                   select student;

            foreach (var student in studentsEnrolled)
            {
                Console.WriteLine("Name: {0} {1}, , Faculty Number: {2}, Grades: {{{3}}}",
                    student.FirstName, student.LastName, student.FacultyNumber, string.Join(", ", student.Marks));
            }
        }
    }
}
