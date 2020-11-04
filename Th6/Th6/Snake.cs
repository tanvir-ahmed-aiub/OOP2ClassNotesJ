using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    class Snake:Animal
    {
        new public void Move()
        {
            Console.WriteLine("moves with chest");
        }
        override public void Eat()
        {
            Console.WriteLine("eats with tongue");
        }
    }
}
