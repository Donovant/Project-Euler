using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100!
*/

namespace Project_Euler___20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger
                number = 100,
                rem = 1,
                sum = 0,
                total = 1;
            for(BigInteger x = number; x > 1; x--)
            {
                total *= x;
            }

            while(total > 0)
            {
                rem = total % 10;
                total = total / 10;
                sum += rem;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
