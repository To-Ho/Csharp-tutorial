//Class, Object
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Object for the Tutorial class
            Tutorial pTutor = new Tutorial();
            pTutor.SetTutorial(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());

            //Private Access for class
            //SetTutorial2() and GetTutorial2() will not work because of no access
            //Tutorial2 pTutor2 = new Tutorial2();
            //pTutor2.SetTutorial2(1, ".Net");
            //Console.WriteLine(pTutor2.GetTutorial2());

            //Constructor
            Tutorial3 pTutor3 = new Tutorial3();
            Console.WriteLine(pTutor3.GetTutorial3());
            pTutor3.SetTutorial3(1, "ABC.Net");
            Console.WriteLine(pTutor3.GetTutorial3());

            Console.ReadKey();
        }
    }
}
