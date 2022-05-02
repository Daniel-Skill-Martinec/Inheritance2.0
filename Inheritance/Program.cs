using System;

namespace Inheritance
{
    //SuperClass
    class Animal
    {
        public string name;

        public void display()
        {
            Console.WriteLine("I am a Farm Animal");
        }
    }

    //The derived class from Animal
    //Subclass
    class Cow : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    //Using the previous Class to add a name to the Subclass above
    class Program
    {

        static void Main(string[] args)
        {
            Cow farm = new Cow();

            farm.name = "Betsy";
            farm.display();

            farm.getName();

            Console.ReadLine();
        }

    }
}
