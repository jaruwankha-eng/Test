using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Teacher : Person
    {
        public Teacher(string name) : base(name) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}");
        }

    }
}
