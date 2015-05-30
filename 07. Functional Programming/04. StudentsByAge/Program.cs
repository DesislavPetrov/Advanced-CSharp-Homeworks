using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _04.StudentsByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            var studentsByAge = from student in data.Students
                                where student.Age > 18
                                where student.Age < 24
                                select student;

            // print the result
            foreach (var student in studentsByAge)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}",
                    student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
