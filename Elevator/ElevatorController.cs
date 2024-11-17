using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    internal class ElevatorController
    {
        public Elevator elevator { get; set; }
        public List<Floor> floors { get; set; }
        public Queue<Passenger> passengerQueue;

        public ElevatorController(int numFloors)
        {
            elevator = new Elevator();
            floors = new List<Floor>();
            passengerQueue = new Queue<Passenger>();

            //create floor instances
            for (int i = 1; i <= numFloors; i++) {
                floors.Add(new Floor(i));
            }
        }

        public void requestElevator(int sourceFloor, int destinationFloor) {
            Floor source = floors[sourceFloor - 1];
            Floor destination = floors[destinationFloor - 1];
            Passenger passenger = new Passenger(destinationFloor);
            passengerQueue.Enqueue(passenger);

            // Check elevator direction if it's not moving
            if (elevator.direction == Direction.NONE)
            {
                if (sourceFloor > elevator.currentFloor)
                {
                    elevator.direction = Direction.UP;
                }
                else
                {
                    elevator.direction = Direction.DOWN;
                }
            }
        }

        public void processRequest() {
            while (passengerQueue.Count!=0) {
                Passenger passenger = passengerQueue.Dequeue();
                int destinationFloor = passenger.destinationFloor;

                //Move the elevator to the request floor
                if (destinationFloor > elevator.currentFloor)
                {
                    elevator.moveFloor(destinationFloor);
                }
                else if (destinationFloor < elevator.currentFloor){ 
                    elevator.moveFloor(destinationFloor);
                }
            }
        }
    }
}
