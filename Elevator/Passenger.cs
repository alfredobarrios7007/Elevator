using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Passenger
    {
        public int destinationFloor { get; set; }

        public Passenger(int destinationFloor)
        {
            this.destinationFloor = destinationFloor;
        }
    }
}
