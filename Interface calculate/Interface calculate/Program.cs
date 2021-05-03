//Geometric calculate
//Perimeter, Area 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_calculate
{
    //Declare a shape interface
    interface IShape
    {
        void perimeterCal(double a, double b);
        void areaCal(double a, double b);
    }

    //Class retangular
    class Retangular : IShape
    {
        public void perimeterCal(double a,double b)
        {
            double Peri = (a + b) * 2;
            Console.WriteLine("Retangular perimeter is: " + Peri);
        }

        public void areaCal(double a, double b)
        {
            double Area = (a * b);
            Console.WriteLine("Retangular area is: " + Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;

            Console.WriteLine("x = {0}, y = {1}", x, y);
            //Declare shape object
            Retangular myRetangular = new Retangular();


            //Calculation
            myRetangular.perimeterCal(x, y);
            myRetangular.areaCal(x, y);

            Console.ReadKey();
        }
    }
}
