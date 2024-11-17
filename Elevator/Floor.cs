using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class Floor
    {
        public int floorNumber { set; get; }
        public Floor(int floorNumber)
        {
            this.floorNumber = floorNumber;
        }
    }
}
