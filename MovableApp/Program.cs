
using System;

namespace MovableApp
{
    // Define the interface
    interface IMovable
    {
        void Move();
    }

    // Class that implements IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class that implements IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Movable Interface Demo ===");

            IMovable myCar = new Car();
            IMovable myBike = new Bicycle();

            myCar.Move();
            myBike.Move();

            Console.WriteLine("Thank you for using the MovableApp.");
        }
    }
}
