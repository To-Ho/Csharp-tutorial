//Class example, also public access example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tutorial
    {
        //Properties
        int TutorialID;
        string TutorialName;

        //Methods
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
}
