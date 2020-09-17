using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing_17_9_20
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double x = 1.2345443542454324d;
            Console.WriteLine("d.p: {0:0.0000000}", x);

            Console.WriteLine("{0}  {1, 12}", "Decimal", "Hexadecimal");

            Console.WriteLine("Number: {0:N}", 5.5676);

            double myDouble = 9.786;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            int Int = 10;
            double Double = 5.25;
            bool Bool = true;

            Console.WriteLine(Convert.ToString(Int));    // convert int to string
            Console.WriteLine(Convert.ToDouble(Int));    // convert int to double
            Console.WriteLine(Convert.ToInt32(Double));  // convert double to int
            Console.WriteLine(Convert.ToString(Bool));   // convert bool to string

            Console.ReadLine();

        }
    }
}
