//Geometric calculate
//Perimeter, Area 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_calculate
{
    //Declare a shape interface for retangular, right triangle
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

    class Square
    {
        public void perimeterCal(double a)
        {
            double Peri = a * 4;
            Console.WriteLine("Square Perimeter: " + Peri);
        }

        public void areaCal(double a)
        {
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
        public void perimeterCal(double a, double b, double c)
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
    class RightCircularCylinder
    {
        public void volumeCal(double r, double h)
        {
            double Volume = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("Volume of right circular cylinder: " + Volume);
        }

        public void surfaceAreaCal(double r, double h)
        {
            double SurfaceArea = (2 * Math.PI * r * h) + (2 * Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Surface area of right circular cylinder: " + SurfaceArea);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            double r;
            double h;
            string userInput;
            string input1, input2, input3;
            int choice;
            //Console.WriteLine("x = {0}, y = {1}", x, y);
            //Declare shape object
            Retangular myRetangular = new Retangular();
            Square mySquare = new Square();
            RightTriangle myRightTriangle = new RightTriangle();
            RegularTriangle myRegularTriangle = new RegularTriangle();
            Circle myCircle = new Circle();
            RightCircularCylinder myCylinder = new RightCircularCylinder();

            //User input
            Console.WriteLine("What shape you want to calculate?");
            Console.WriteLine("1: Retangular       2: Square     3: Right Triangle");
            Console.WriteLine("4: Regular Triangle 5: Circle     6: Right Circular Cylinder");
            //User inputs a string
            userInput = Console.ReadLine();
            //Convert userInput to an int for loop
            choice = Convert.ToInt32(userInput);
            Console.WriteLine("Your input: " + choice);

            //Calculation
            //Use switch loop
            switch (choice)
            {
                //Retangular
                case 1:
                    Console.WriteLine("Input length and width");
                    Console.Write("length = ");
                    input1 = Console.ReadLine();
                    Console.Write("Width = ");
                    input2 = Console.ReadLine();

                    x = Convert.ToDouble(input1);
                    y = Convert.ToDouble(input2);

                    myRetangular.perimeterCal(x, y);
                    myRetangular.areaCal(x, y);
                    break;
                //Square
                case 2:
                    Console.WriteLine("Input length");
                    Console.Write("length = ");
                    input1 = Console.ReadLine();

                    x = Convert.ToDouble(input1);

                    mySquare.perimeterCal(x);
                    mySquare.areaCal(x);
                    break;
                //Right Triangle
                case 3:
                    Console.WriteLine("Input a and b");
                    Console.Write("a = ");
                    input1 = Console.ReadLine();
                    Console.Write("b = ");
                    input2 = Console.ReadLine();

                    x = Convert.ToDouble(input1);
                    y = Convert.ToDouble(input2);

                    myRightTriangle.perimeterCal(x, y);
                    myRightTriangle.areaCal(x, y);
                    break;
                //Regular Triangle
                case 4:
                    Console.WriteLine("Input a, b, and c");
                    Console.Write("a = ");
                    input1 = Console.ReadLine();
                    Console.Write("b = ");
                    input2 = Console.ReadLine();
                    Console.Write("c = ");
                    input3 = Console.ReadLine();

                    x = Convert.ToDouble(input1);
                    y = Convert.ToDouble(input2);
                    z = Convert.ToDouble(input3);

                    myRegularTriangle.perimeterCal(x, y, z);
                    myRegularTriangle.areaCal(x, y, z);
                    break;
                //Circle
                case 5:
                    Console.WriteLine("Input radius");
                    Console.Write("r = ");
                    input1 = Console.ReadLine();
                    
                    r = Convert.ToDouble(input1);

                    myCircle.diameterCal(r);
                    myCircle.circumferenceCal(r);
                    myCircle.areaCal(r);
                    break;
                //Right Circular Cylinder
                case 6:
                    Console.WriteLine("Input radius and height");
                    Console.Write("r = ");
                    input1 = Console.ReadLine();
                    Console.Write("h = ");
                    input2 = Console.ReadLine();

                    r = Convert.ToDouble(input1);
                    h = Convert.ToDouble(input2);

                    myCylinder.volumeCal(r, h);
                    myCylinder.surfaceAreaCal(r, h);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }

            Console.ReadKey();
        }
    }
}