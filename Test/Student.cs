using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Student : Person
    {
        public string StudentID { get; set; }
        public double Score { get; set; }

        public Student(string name, string id, double score) : base(name)
        {
            StudentID = id;
            Score = score;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student Name: {Name}, ID: {StudentID}, Score: {Score}, Grade: {Grade.GetGrade(Score)}");
        }
    }
}
