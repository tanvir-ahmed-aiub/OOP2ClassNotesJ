using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Lamborgini : Car, IBasicCar, IRacingCar
    {
        public Lamborgini() { }
        public Lamborgini(string name, string chassis, string year) : base(name, chassis, year)
        {

        }
        public void Brake()
        {
            Console.WriteLine("Lamborgini is braking");
        }

        public void EmergencyBrake()
        {
            Console.WriteLine("Lamborgini is emergency braking");
        }

        public void ExtraSpeed()
        {
            Console.WriteLine("Lamborgini is extra speeding");
        }

        public void GearUp()
        {
            Console.WriteLine("Lamborgini is gearing up");
        }

        public void NOS()
        {
            Console.WriteLine("Lamborgini is providing NOS");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Lamborgini is normal speeding");
        }

        public void Start()
        {
            Console.WriteLine("Lamborgini is staring ");
        }

        public void StopWatch(string starttime)
        {
            Console.WriteLine("Lamborgini is counting");
        }
    }
}
