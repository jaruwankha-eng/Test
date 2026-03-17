using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Course
    {
        public string CourseName { get; set; }
        public string CourseID { get; set; }
        public Teacher Instructor { get; set; }

        private List<Student> students = new List<Student>();

        public Course(string name, string id, Teacher teacher)
        {
            CourseName = name;
            CourseID = id;
            Instructor = teacher;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students.");
                return;
            }

            foreach (var s in students)
            {
                s.ShowInfo();
            }
        }

        public void ShowStatistics()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students.");
                return;
            }

            Console.WriteLine($"Max Score: {students.Max(s => s.Score)}");
            Console.WriteLine($"Min Score: {students.Min(s => s.Score)}");
            Console.WriteLine($"Average Score: {students.Average(s => s.Score)}");
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine($"\nCourse: {CourseName} ({CourseID})");
            Console.WriteLine($"Teacher: {Instructor.Name}");
            ShowStudents();
            ShowStatistics();
        }
    }
}
