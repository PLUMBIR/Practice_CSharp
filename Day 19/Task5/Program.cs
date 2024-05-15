using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentGroup();

            group.AddStudent(new Student("Иван", "Иванов", new DateTime(2000, 5, 10)));
            group.AddStudent(new Student("Петр", "Петров", new DateTime(2001, 8, 15)));

            var foundStudent = group.FindStudentByLastName("Иванов");
            if (foundStudent != null)
                Console.WriteLine($"Найден студент: {foundStudent.FirstName} {foundStudent.LastName}");

            group.SortStudentsByName();

            var studentAtIndex = group.GetStudentByIndex(1);
            if (studentAtIndex != null)
            {
                Console.WriteLine($"Студент по индексу 1: {studentAtIndex.FirstName} {studentAtIndex.LastName}");
            }

            Console.ReadLine();
        }
    }
}
