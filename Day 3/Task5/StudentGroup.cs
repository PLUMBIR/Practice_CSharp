using System.Collections.Generic;

namespace Task5
{
    class StudentGroup
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public Student FindStudentByLastName(string lastName)
        {
            return students.Find(s => s.LastName == lastName);
        }

        public void SortStudentsByName()
        {
            students.Sort((s1, s2) => string.Compare(s1.FirstName, s2.FirstName));
        }

        public Student GetStudentByIndex(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];
            else
                return null;
        }
    }
}
