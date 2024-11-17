using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    enum Direction { 
        UP = 1, DOWN = 2, NONE = 0
    }
    internal class Elevator
    {
        public Direction direction { get; set; }
        public int currentFloor { get; set; }
        
        public Elevator() {
            currentFloor = 1;               //Starts on first floor
            direction = Direction.NONE;     //Initially, elevator is stationary
        }

        public void moveFloor(int targetFloor) { 
            currentFloor = targetFloor;
        }
    }
}
