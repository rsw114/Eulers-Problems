using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            const long num1 = 999; // number to test
            int q = 0; //array index point
            long[] factors = new long[1000]; //array to store factors of num1
            

            for (long i = 1; i < num1 / 2; i++)
            {
                if (num1 % i == 0) // is the number a factor of num1
                {
                    factors[q] = i;
                    Console.WriteLine(factors[q]);
                    if (isPrime(factors[q])) // call to method to test for prime
                    {
                        Console.WriteLine(factors[q] + " is prime");
                    }
                    else
                    {
                        Console.WriteLine(factors[q] + " is not prime");
                    }
                    q++;                    
                }
                
                
                               
            }                 

            Console.WriteLine("Done");
            Console.ReadLine();           

        }

        public static bool isPrime(long number)
        {
            double boundary = Math.Floor(Math.Sqrt(number)); // rounds the square root

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i) // test for remainders return not prime if no remainders present
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
