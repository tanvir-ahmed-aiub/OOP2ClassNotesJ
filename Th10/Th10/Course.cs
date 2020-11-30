using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th10
{
    class Course
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Course() { }
        public Course(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public void Show() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
}
