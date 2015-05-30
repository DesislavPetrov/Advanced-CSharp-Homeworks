using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _06.Filter_Students_By_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            var studentsByMail = from student in data.Students
                                 where student.Email.Contains("@abv.bg")
                                 select student;

            // print the result
            foreach (var student in studentsByMail)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
