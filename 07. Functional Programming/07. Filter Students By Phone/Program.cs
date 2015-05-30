using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _07.Filter_Students_By_Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            var studentsByPhone = from student in data.Students
                                  where student.Phone.StartsWith("02")
                                  || student.Phone.StartsWith("+359")
                                  || student.Phone.StartsWith("+359 2")
                                  select student;

            // print the result
            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}",
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
