//Inheritance
//Parent Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Set class Tutorial to public for accessibility
    public class Tutorial
    {
        //Protected access modifier enable the child class to use
        //the fields of the parent class
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
    //Define the Child class
    public class Guru99Tutorial : Tutorial
    {
        //Child class method
        public void RenameTutorial(String pNewName)
        {
            //Set the field TutorialName to a new name
            TutorialName = pNewName;
        }
    }
}
