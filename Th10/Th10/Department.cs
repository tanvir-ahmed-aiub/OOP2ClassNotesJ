using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Th10
{
    class Department
    {
        public string Name { get; set; }
        public string Id { get; set; }

        ArrayList courses;


        public Department() {
            courses = new ArrayList();
        }
        public Department(string name, string id) {
            Name = name;
            Id = id;
            courses = new ArrayList();
        }
        public void AddCourse(params Course[] courses) {
            foreach (Course c in courses) {
                this.courses.Add(c);
            }
        }
        public Course SearchCourse(string id) {
            Course temp = null;
            foreach (Course c in courses)
            {
                if (c.Id.Equals(id)) {
                    temp = c;
                }
            }
            return temp;
        }
        public void DeleteCourse(Course c) {
            courses.Remove(c);
        }

        public void ShowAllCourses() {
            foreach (Course c in this.courses) {
                c.Show();
            }
        }


    }
}
