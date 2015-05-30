using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0; //set total counter

            for (int i = 1; i < 1000; i++) 
            {
                if ((i % 3 == 0) || (i % 5 == 0)) // test if i divides by 3 or 5 with no remainder
                {
                    total = total + i; // add to total
                }
            }
            Console.WriteLine(total); //get answer
            Console.ReadLine();
        }
    }
}
