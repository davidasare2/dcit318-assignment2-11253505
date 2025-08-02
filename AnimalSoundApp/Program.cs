using System;

namespace AnimalSoundApp
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class: Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class: Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Animal Sound App ===");

            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.Write("Animal says: ");
            genericAnimal.MakeSound();

            Console.Write("Dog says: ");
            dog.MakeSound();

            Console.Write("Cat says: ");
            cat.MakeSound();

            Console.WriteLine("Thank you for using the Animal Sound App.");
        }
    }
}

