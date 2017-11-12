using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*/

namespace Project_Euler___10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64
                sum = 1;

            for (Int64 x = 0; x < 2000000; x++)
            {
                if(isPrime(x))
                {
                    sum += x;
                }
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }

        static bool isPrime(Int64 x)
        {
            Int64 upper = (Int64)(Math.Floor(Math.Sqrt(x)));

            for (Int64 y = 2; y <= upper + 1; y++)
            {
                if (x % y == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
