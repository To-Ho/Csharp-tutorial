//Interface
//Interface is a completely "abstract class"
//which can only contain abstract methods and properties
//with empty bodies
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //Declare interface
        public interface Guru99Interface
        {
            void SetTutorial(int pID, string pName);
            string GetTutorial();
        }

        //Class extends the interface
        public class Guru99Tutorial : Guru99Interface
        {
            protected int TutorialID;
            protected string TutorialName;

            public void SetTutorial(int pID, string pName)
            {
                TutorialID = pID;
                TutorialName = pName;
            }

            public string GetTutorial()
            {
                return TutorialName;
            }
        }

        //Multiple interfaces example
        interface IFirstInterface
        {
            void myMethod();
        }

        interface ISecondInterface
        {
            void myOtherMethod();
        }

        //Implement interfaces above
        class Demo : IFirstInterface, ISecondInterface
        {
            public void myMethod()
            {
                Console.WriteLine("First Method here");
            }

            public void myOtherMethod()
            {
                Console.WriteLine("Second Method here");
            }
        }

        static void Main(string[] args)
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.SetTutorial(1, ".Net by Guru99");
            Console.WriteLine(pTutor.GetTutorial());

            //Run interface example
            Demo myDemo = new Demo();
            myDemo.myMethod();
            myDemo.myOtherMethod();

            Console.ReadKey();
        }
    }
}
