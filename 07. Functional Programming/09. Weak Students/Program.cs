using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace;

namespace _09.Weak_Students
{
    public static class WeakStudents // an extension method must be defined in a non-generic static class
    {
        static void Main(string[] args)
        {
            StudentsData data = new StudentsData();

            var weakStudentsList = data.Students.WeakStudentsList();

            // here we'll use the PrintStudentsInfo - the extended method from the first project in this solution
            Print.PrintStudentsInfo(weakStudentsList);
        }

        
        // here we'll create an extended method as is written in the condition
        public static List <Student> WeakStudentsList (this List<Student> students)
        {
            var weakStudents = from student in students
                               where (student.Marks.Count(item => item == 2) == 2)
                               select student;

            return weakStudents.ToList();
        }
    }
}
