//Examples using interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    //Declare interface
    interface IAnimal
    {
        void animalISound();
        void animalIFood();
    }

    //Pig inplements the IAnimal interface
    class Pig : IAnimal
    {
        public void animalISound()
        {
            Console.WriteLine("oi oi");
        }

        public void animalIFood()
        {
            Console.WriteLine("Anything");
        }
    }

    //Horse class for IAnimal interface
    class Horse : IAnimal
    {
        public void animalISound()
        {
            Console.WriteLine("Neight!");
        }
        public void animalIFood()
        {
            Console.WriteLine("Grass, grain, and carrot");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); //Create a pig object
            Horse myHorse = new Horse(); //Create a horse object
            Console.Write("Pig sound:");
            myPig.animalISound();
            Console.Write("Pig eats: ");
            myPig.animalIFood();

            Console.Write("Horse sound: ");
            myHorse.animalISound();
            Console.Write("Horse eat: ");
            myHorse.animalIFood();

            Console.ReadKey();
        }
    }
}
