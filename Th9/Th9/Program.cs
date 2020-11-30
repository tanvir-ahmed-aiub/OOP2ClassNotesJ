using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th9
{
    class Demo {
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply: " + (x * y));
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine("Division: " + (x / y));
        }
    }
    class Program
    {
        public delegate void Calc(int x, int y);

        public static void Add(int a, int c) {
            Console.WriteLine("Sum: " + (a + c));
        }
        public static void Sub(int a, int c) {
            Console.WriteLine("Sub: " + (a - c));
        }
        
        static void Main(string[] args)
        {
            Calc handler = Add;
            //handler(12, 10);
            handler = handler + Sub ;
            //handler(12, 10);

            Calc handler2 = Demo.Multiply;
            handler2 += Demo.Div;

            //handler2(13, 5);

            Calc all = handler + handler2;
     
            //all(15,5);

            //all -= handler;
            all -= Add;
            all(15, 5);

       
        }
    }
}
