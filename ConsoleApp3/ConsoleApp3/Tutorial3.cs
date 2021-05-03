//Constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tutorial3
    {
        int TutorialID3;
        string TutorialName3;
        //Constructor
        public Tutorial3()
        {
            TutorialID3 = 0;
            TutorialName3 = "Default";
        }

        public void SetTutorial3(int pID3, string pName3)
        {
            TutorialID3 = pID3;
            TutorialName3 = pName3;
        }
        public string GetTutorial3()
        {
            return TutorialName3;
        }
    }
}
