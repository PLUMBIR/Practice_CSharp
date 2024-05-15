using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс, представляющий группу студентов.
    /// </summary>
    class StudentGroup
    {
        private List<Student> students = new List<Student>();

        /// <summary>
        /// Добавляет студента в группу.
        /// </summary>
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        /// <summary>
        /// Удаляет студента из группы.
        /// </summary>
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        /// <summary>
        /// Ищет студента по фамилии.
        /// </summary>
        public Student FindStudentByLastName(string lastName)
        {
            return students.Find(s => s.LastName == lastName);
        }

        /// <summary>
        /// Сортирует студентов по имени.
        /// </summary>
        public void SortStudentsByName()
        {
            students.Sort((s1, s2) => string.Compare(s1.FirstName, s2.FirstName));
        }

        /// <summary>
        /// Возвращает студента по индексу.
        /// </summary>
        public Student GetStudentByIndex(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];
            else
                return null;
        }
    }
}
