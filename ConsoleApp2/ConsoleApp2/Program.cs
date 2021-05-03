//Loop statements, arrays
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //If statement example
            int valueIf = 11;
            if (valueIf < 10)
            {
                Console.WriteLine("Value is less than 10")
; }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }

            //Switch statement example
            int valueSwit = 3;
            switch (valueSwit)
            {
                case 1: Console.WriteLine("Value is 1");
                    break;
                case 2: Console.WriteLine("Value is 2");
                    break;
                default: Console.WriteLine("Value is difference");
                    break;
            }

            //While loop example
            int valueWh = 4;
            int i = 0;
            while (i < valueWh)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            //For loop
            int valueF = 3;
            for (int x = 0; x < valueF; x++)
            {
                Console.WriteLine(x);
            }

            //Arrays
            //Int array
            int[] valueArray;
            valueArray = new int[4];
            valueArray[0] = 1;
            valueArray[1] = 2;
            valueArray[2] = 3;
            valueArray[3] = 4;
            for (int xArray = 0; xArray < 4; xArray++)
            {
                Console.WriteLine(valueArray[xArray]);
            }
            //char array
            char[] valueArrayCh;
            valueArrayCh = new char[2];
            valueArrayCh[0] = 'a';
            valueArrayCh[1] = 'b';
            Console.WriteLine(valueArrayCh[0]);
            Console.WriteLine(valueArrayCh[1]);

            Console.ReadKey();
        }
    }
}
