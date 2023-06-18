using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instance_static
{
    internal class SportCar : Car
    {
        string nitros;
        string specialSeatBelts;
        public SportCar(string engine, int numberOfTyres, int numberOfDoors, string gearType, string color) : base(engine, numberOfTyres, numberOfDoors, gearType, color)
        {
            this.nitros = nitros;
            this.specialSeatBelts = specialSeatBelts;
        }
    }
}
