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

            Console.ReadLine();

        }
    }
}
