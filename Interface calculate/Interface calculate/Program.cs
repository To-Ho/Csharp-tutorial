//Geometric calculate
//Perimeter, Area 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_calculate
{
    //Declare a shape interface for retangular, square, right triangle
    interface IShape
    {
        void perimeterCal(double a, double b);
        void areaCal(double a, double b);
    }

    //Class retangular
    class Retangular : IShape
    {
        public void perimeterCal(double a, double b)
        {
            double Peri = (a + b) * 2;
            Console.WriteLine("Retangular perimeter: " + Peri);
        }

        public void areaCal(double a, double b)
        {
            double Area = (a * b);
            Console.WriteLine("Retangular area: " + Area);
        }
    }

    class Square : IShape
    {
        public void perimeterCal(double a, double b)
        {
            b = a;
            double Peri = a * 4;
            Console.WriteLine("Square Perimeter: " + Peri);
        }

        public void areaCal(double a, double b)
        {
            b = a;
            double Area = a * a;
            Console.WriteLine("Square Area: " + Area);
        }
    }

    class RightTriangle : IShape
    {
        public void perimeterCal(double a, double b)
        {
            //double c = Math.Sqrt(a * a + b * b);
            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double Peri = a + b + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Right triangle perimeter: " + Peri);
        }

        public void areaCal(double a, double b)
        {
            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double Area = (a + b) / 2;
            Console.WriteLine("Area of right triagle: " + Area);
        }

    }

    class RegularTriangle
    {
        public void perimeterCal( double a, double b, double c)
        {
            double Perimeter = a + b + c;
            Console.WriteLine("Perimeter of regular triagle: " + Perimeter);
        }

        public void areaCal(double a, double b, double c)
        {
            //Find semi-perimeter of the triangle
            double SemiPerimeter = (a + b + c) / 2;
            double Area = Math.Sqrt(SemiPerimeter * (SemiPerimeter - a) * (SemiPerimeter - b) * (SemiPerimeter - c));
            Console.WriteLine("Area of regulet triangle: " + Area);
        }
    }
    class Circle
    {
        public void diameterCal(double r)
        {
            double Diameter = 2 * r;
            Console.WriteLine("Diameter of circle: " + Diameter);
        }

        public void circumferenceCal(double r)
        {
            //r = pi * d
            double Circumference = 2 * Math.PI * r;
            Console.WriteLine("Circumference of circle: " + Circumference);
        }

        public void areaCal(double r)
        {
            double Area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area of circle: " + Area);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;
            double z = 7;
            double r = 4;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            //Declare shape object
            Retangular myRetangular = new Retangular();
            Square mySquare = new Square();
            RightTriangle myRightTriangle = new RightTriangle();
            RegularTriangle myRegularTriangle = new RegularTriangle();
            Circle myCircle = new Circle();


            //Calculation
            //Retangular
            myRetangular.perimeterCal(x, y);
            myRetangular.areaCal(x, y);
            //Square
            mySquare.perimeterCal(x, y);
            mySquare.areaCal(x, y);
            //Right Triangle
            myRightTriangle.perimeterCal(x, y);
            myRightTriangle.areaCal(x, y);
            //Regular Triangle
            myRegularTriangle.perimeterCal(x, y, z);
            myRegularTriangle.areaCal(x, y, z);
            //Circle
            myCircle.diameterCal(r);
            myCircle.circumferenceCal(r);
            myCircle.areaCal(r);

            Console.ReadKey();
        }
    }
}
