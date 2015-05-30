using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNamespace
{
    public static class Print
    {
        // here we'll create a method that will print students data
        public static void PrintStudentsInfo (this IEnumerable <Student> data)
        {
            foreach (var student in data)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " + 
                    "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}, Group: {7}", 
                    student.FirstName, student.LastName, student.Age, student.FacultyNumber,
                    student.Phone, student.Email, string.Join(", ", student.Marks), student.GroupNumber);
            }
        }
    }
}
