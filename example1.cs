using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instance_static
{
    internal class example1
    {
        public int numberOfCars;
        public static int someInteger = 2;

        public example1(int tyres)
        {
            numberOfCars = tyres;
        }

        public int getDoubleSomeInteger()
        {
            someInteger = someInteger * 10;
            return numberOfCars * 2;
        }

        public static void getFloatSomeInteger()
        {
            Console.WriteLine("TEST");
        }
    }
}
