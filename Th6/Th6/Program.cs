using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Snake s1 = new Snake();
            Horse h1 = new Horse();
            Whale w1 = new Whale();
            Human hum1 = new Human();

            hum1.Eat();
            hum1.Move();
            hum1.Sleep();
            hum1.Express();

            s1.Move();
            s1.Eat();

            h1.Sleep();
            h1.Move();*/
            Animal a1 = new Snake();
            Snake s1 = new Snake();

            s1.Move();
            s1.Eat();
            Console.WriteLine();
            a1.Move();
            a1.Eat();

            Human h = new Human();
            a1.Death();
            h.Death();


        }
    }
}
