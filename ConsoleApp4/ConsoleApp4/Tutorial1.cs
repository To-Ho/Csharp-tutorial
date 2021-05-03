//Polymorphism
//Definition: is a OOPs concept where one name can have many forms
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Tutorial1
    {
        public int TutorialID1;
        public string TutorialName1;

        //Both methods have the same name, they only have different parameters passed to them
        //Have both ID and name
        public void SetTutorial1(int pID1, string pName1)
        {
            TutorialID1 = pID1;
            TutorialName1 = pName1;
        }

        //Only have name
        public void SetTutorial1(string pName1)
        {
            TutorialName1 = pName1;
        }

        public string GetTutorial1()
        {
            return TutorialName1;
        }

        public int GetTutorialID1()
        {
            return TutorialID1;
        }
    }
}
