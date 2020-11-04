using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    class Horse:Animal
    {
        new public void Sleep()
        {
            Console.WriteLine("sleeps by standing");
        }
    }
}
