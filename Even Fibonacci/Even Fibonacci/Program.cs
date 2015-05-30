using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int total = 0;

            do
            {
                a = a + b; // add the numbers in sequence
                if (a % 2 == 0) // check even number
                {
                    total = total + a; // add to sum
                }
                Console.Write(a + " ");

                b = a + b; // same but for b
                if (b % 2 == 0)
                {
                    total = total + b;
                }
                Console.Write(b + " ");
            }
            while (total < 4000000);
            Console.WriteLine("\n" +total);
            Console.ReadLine();
        }
    }
}
