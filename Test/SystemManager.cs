using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class SystemManager
    {
        private List<Course> courses = new List<Course>(); 

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n===== >>> MENU <<< =====");
                Console.WriteLine("1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Show Data");
                Console.WriteLine("4. Exit");
                Console.Write("Select: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddCourse(); break;
                    case 2: AddStudent(); break;
                    case 3: ShowData(); break;
                    case 4: return;
                }
            }
        }

        private void AddCourse()
        {
            Console.Write("Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Course ID: ");
            string id = Console.ReadLine();

            Console.Write("Teacher Name: ");
            string teacherName = Console.ReadLine();

            Teacher teacher = new Teacher(teacherName);

            courses.Add(new Course(name, id, teacher));

            Console.WriteLine("Course added!");

        }

        private void AddStudent()
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No course.");
                return;
            }

            Console.WriteLine("\nCourses:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i}. {courses[i].CourseName}");
            }

            Console.Write("Select course: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Student ID: ");
            string id = Console.ReadLine();

            Console.Write("Score: ");
            double score = double.Parse(Console.ReadLine());

            courses[index].AddStudent(new Student(name, id, score));

            Console.WriteLine("Student added!");
        }

        private void ShowData()
        {
            foreach (var c in courses)
            {
                c.ShowCourseInfo();
            }
        }
    }
}
