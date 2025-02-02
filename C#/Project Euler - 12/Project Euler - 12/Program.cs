﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The sequence of triangle numbers is generated by adding the natural numbers.
So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

Let us list the factors of the first seven triangle numbers:

 1: 1
 3: 1,3
 6: 1,2,3,6
10: 1,2,5,10
15: 1,3,5,15
21: 1,3,7,21
28: 1,2,4,7,14,28
We can see that 28 is the first triangle number to have over five divisors.

What is the value of the first triangle number to have over five hundred divisors?
*/

namespace Project_Euler___12
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64
                current = 4,
                triangle_number = 10,
                divisor_count = 0;

            while (divisor_count < 500)
            {
                current++;
                triangle_number += current;
                Int64 sqrt = (Int64)Math.Sqrt((double)triangle_number);
                divisor_count = 2;
                for (Int64 x = sqrt; x > 1; x--)
                {
                    if (triangle_number % x == 0)
                    {
                        divisor_count += 2;
                    }

                    if (x * x == triangle_number)
                    {
                        divisor_count--;
                    }
                }
            }
            Console.WriteLine("tn: {0}", triangle_number);
            Console.ReadLine();
        }
    }
}
