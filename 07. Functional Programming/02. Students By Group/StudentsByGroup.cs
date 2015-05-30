using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsNamespace; // after adding the namespace of the first project, now we can use the data from this project

namespace _02.Students_By_Group
{
    class StudentsByGroup
    {
        static void Main()
        {
            StudentsData data = new StudentsData();
            
            // here we'll use LINQ query
            var studentsByGroup =
                from student in data.Students
                orderby student.FirstName
                group student by student.GroupNumber
                    into studentGroup
                    where studentGroup.Key == 2
                    select studentGroup;


            foreach (var student in studentsByGroup)
            {
                Console.WriteLine("All students from group {0}:", student.Key);
                foreach (var item in student)
                {
                    Console.WriteLine("Name: {0} {1}, Age: {2}, Faculty Number: {3} " +
                                  "\n\tPhone: {4}, Email: {5} \n\tGrades: {{{6}}}", item.FirstName, item.LastName, item.Age, item.FacultyNumber, item.Phone, item.Email, string.Join(", ", item.Marks));
                }
            }
        }
    }
}
