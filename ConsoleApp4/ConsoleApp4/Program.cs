//Inheritance, polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of child class
            Guru99Tutorial pTutor = new Guru99Tutorial();
            //Child class method
            pTutor.RenameTutorial(".Net by Guru99");
            //Child class method
            Console.WriteLine(pTutor.GetTutorial());

            //Polymorphism
            Tutorial1 pTutor1 = new Tutorial1();
            //Call the first method
            pTutor1.SetTutorial1(1, "First tutorial");
            Console.WriteLine(pTutor1.GetTutorial1());
            Console.WriteLine(pTutor1.GetTutorialID1());
            //Call the second method
            pTutor1.SetTutorial1("Second Tutorial");
            Console.WriteLine(pTutor1.GetTutorial1());
            Console.WriteLine(pTutor1.GetTutorialID1());

            Console.ReadKey();
        }
    }
}
