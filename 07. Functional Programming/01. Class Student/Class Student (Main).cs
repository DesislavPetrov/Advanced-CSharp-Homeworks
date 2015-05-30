using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentsNamespace // it will be used in the other project in this solution
{
    public class ClassStudent // it is the same as the project name
    {
        // it is the main method in this project
        static void Main(string[] args)
        {
            // here we'll create an instance of the StudentsData class
            StudentsData data = new StudentsData();

            data.Students.PrintStudentsInfo();
            
        }
    }
}
