using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNamespace
{
    public class StudentsData
    {
        // here we'll create a list with the  students data
        public List<Student> Students = CreateStudentsData();

        // here we'll create a method that return the students in list
        public static List<Student> CreateStudentsData()
        {
            var students = new List<Student>()
            {
                new Student("Hristo", "Yanev", 25, 457154, "+3592 551435", "yanev@mail.bg",
                    new List<int>() {4, 2, 6, 5, 3}, 1),
                new Student("Toni", "Silva", 28, 457124, "0887215412", "toni95@abv.bg",
                    new List<int>() {6, 4, 6, 5, 6}, 2),
                new Student("Stoycho", "Mladenov", 23, 468714, "+359 2 641587", "mladenov-stoycho@gmail.com",
                    new List<int>() {2, 2, 6, 5, 3}, 3),
                new Student("Todor", "Yanchev", 29, 654114, "02 6123450", "toshko_yanchev@abv.bg",
                    new List<int>() {4, 2, 3, 5, 3}, 2),
                new Student("Sergiu", "Bus", 30, 324574, "02 456 254", "bus@mail.bg",
                    new List<int>() {2, 2, 3, 5, 3}, 3),
                new Student("Tonci", "Kukoc", 21, 457756, "0888545445", "tonci@mail.bg",
                    new List<int>() {4, 4, 4, 5, 3}, 1)
            };

            return students;
        }
    }
}
