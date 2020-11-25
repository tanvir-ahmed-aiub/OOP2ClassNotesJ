using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota t = new Toyota("X-Corolloa","34645768","2009");
            t.ShowInfo();
            t.SpeedUp();

            Lamborgini l = new Lamborgini("Venon", "465475675676", "2018");
            l.ShowInfo();
            l.SpeedUp();
            l.EmergencyBrake();

            IRacingCar c = new Lamborgini();
            
            

        }
    }
}
