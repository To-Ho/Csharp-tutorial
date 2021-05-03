//c# Begginer: output, datatype, enum, variables.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            int numI = 30;
            double numD = 30.33;
            Boolean status = true;
            String message = "Hello, Cruel World";
            int myNum = (int)Days.Sat;
            String message1 = "The value is ";
            int val = 6;
            int val1 = 10, val2 = 20;
            bool status1 = true; //bool = Boolean

            Console.WriteLine("Hello World!");
            Console.WriteLine(numI);
            Console.WriteLine(numD);
            Console.WriteLine(status);
            Console.WriteLine(message);
            Console.WriteLine(Days.Sat);
            Console.WriteLine(myNum);
            Console.WriteLine(message1 + val);
            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!status);

            Console.ReadKey();
        }
    }
}
