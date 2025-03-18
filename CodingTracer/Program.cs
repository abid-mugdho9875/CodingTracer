using System;
//try to practice overide 
namespace MyApplication
{
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()// use virtual in main class to define base class
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Car //Base class (parent 2)
    {
        public virtual void carSpeed()// use virtual in main class to define base class
        {
            Console.WriteLine("The car speed should n't be more than 60kph");
        }

    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() /// use override class to override the base class
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    //child class of car 
    class Audi : Car  //Derived class (child -car)
    {
        public override void carSpeed()
        {
            Console.WriteLine("Audi Speed");
        }

    }
    //child class of car 
    class Parado : Car  //Derived class (child -car)
    {
        public override void carSpeed()
        {
            Console.WriteLine("Parado Speed");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object
            Car myCar = new Car();//create a Car object
            Car audiCar = new Audi();//create an audi project
            Car paradoCar = new Parado();//create a parado project

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            myCar.carSpeed();
            audiCar.carSpeed();
            paradoCar.carSpeed();


        }
    }
}