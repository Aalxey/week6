using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class StudentOperations
    {
        public static IEnumerable<Student> SortStudentsByName(List<Student> students)
        {
            return students.OrderBy(s => s.Name);
        }
    }
    internal class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}
