//Abstract class
//Definition: can never be instantiated and is marked by the 
//keyword abstract
//It contains 0 or more astract methods in it. Acts as a base
//class and is designed to be inherited by subclasses that 
//either implement or override its method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //Define an abstract class Tutorial
    abstract public class Tutorial
    {
        public virtual void Set()
        {

        }
    }

    //Child class of class Tutorial
    public class Guru99Tutorial : Tutorial
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
    class Program
    {
        static void Main(string[] args)
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.SetTutorial(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());

            Console.ReadKey();
        }
    }
}
