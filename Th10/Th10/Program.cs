using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Th10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MyStack<int> st = new MyStack<int>();
            st.Push(10);
            st.Push(13);

            // st.PrintStack();
            Console.WriteLine(st.Top());
            MyStack<string> st2 = new MyStack<string>();
            st2.Push("Tanvir");
            st2.Push("Karim");
            st2.Push("Rahim");

            st2.PrintStack();
            Console.WriteLine();
            ArrayList list = new ArrayList();
            Student s1 = new Student("Tanvir", "465456");
            list.Add("Tanvir Ahmed");
            list.Add(s1);
            list.Add(10);

            var temp = list.Contains(13);
            var temp2 = list.IndexOf("Tanvir h");

            //list.Remove(s1); // index 1
            list.RemoveAt(0);
            var s = (Student)list[0];
            s.ShowInfo();
            
            Console.WriteLine(temp + " " + temp2);
            Console.WriteLine("------------------------------");
            Hashtable hash = new Hashtable();
            hash["2568"] = "Rahim";
            hash["1425"] = "Tanvir Ahmed";
            hash["1426"] = "Karim Ahmed";

            Console.WriteLine(hash["1425"]);
            foreach (DictionaryEntry entry in hash) {
                Console.WriteLine("Key: {0} ==> Value: {1}",entry.Key,entry.Value);
            }

            SortedList language = new SortedList();
            language["en-us"] = "English: United States";
            language["en-uk"] = "English: United Kingodm";
            language["bn"] = "Bangladesh";
            language["hn"] = "Hindi";

            foreach (DictionaryEntry entry in language) {
                Console.WriteLine("Key: {0} ==> Value: {1}", entry.Key, entry.Value);
            }*/

            Course c = new Course("Pl1", "CSC01");
            Course c2 = new Course("Pl2", "CSC02");

            Department d = new Department("CS", "1");
            d.AddCourse(c, c2);
            d.ShowAllCourses();
            var course = d.SearchCourse("CSC01");
            if (course != null) {
                d.DeleteCourse(course);
            }
            Console.WriteLine("----------------------");
            d.ShowAllCourses();



        }
    }
}
