//Private access example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Tutorial2
    {
        int TutorialID2;
        string TutorialName2;

        private void SetTutorial2(int pID2, string pName2)
        {
            TutorialID2 = pID2;
            TutorialName2 = pName2;
        }

        private string GetTurorial2()
        {
            return TutorialName2;
        }
    }
}
