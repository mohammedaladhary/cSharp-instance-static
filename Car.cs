using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instance_static
{
    internal class Car
    {
        string engine;
        int numberOfTyres;
        int numberOfDoors;
        string gearType;
        string color;

        public Car(string engine , int numberOfTyres , int numberOfDoors , string gearType, string color) {
            this.engine = engine;
            this.numberOfTyres = numberOfTyres;
            this.numberOfDoors = numberOfDoors;
            this.gearType = gearType;
            this.color = color;
        }
    }
}
