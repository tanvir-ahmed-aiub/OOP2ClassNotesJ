using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Toyota : Car, IBasicCar
    {
        public Toyota() { }
        public Toyota(string name, string chassis, string year) : base(name, chassis, year) {

        }
        public void Brake()
        {
            Console.WriteLine("Toyota is braking");
        }

        public void GearUp()
        {
            Console.WriteLine("Toyota is gearing up");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Toyota is speeding up");
        }

        public void Start()
        {
            Console.WriteLine("Toyota is starting");
        }
    }
}
