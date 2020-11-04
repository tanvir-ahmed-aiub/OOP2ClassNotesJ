using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    class Animal
    {
        virtual public void Eat()
        {
            Console.WriteLine("eat with hand");
        }
        public void Sleep()
        {
            Console.WriteLine("sleeps by lying");
        }
        public void Move()
        {
            Console.WriteLine("move with legs");
        }
        public void Express()
        {
            Console.WriteLine("sounds with mouth");
        }
    }
}
