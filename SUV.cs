using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instance_static
{
    internal class SUV : Car
    {
        string specialTyre;
        string foldableSeats;
        int extandableSeats;

        public SUV(string engine, int numberOfTyres, int numberOfDoors, string gearType, string color, int legSpace) : base(engine, numberOfTyres, numberOfDoors, gearType, color)
        {
            this.specialTyre = specialTyre;
            this.foldableSeats = foldableSeats;
            this.extandableSeats = legSpace;
        }
    }
}
