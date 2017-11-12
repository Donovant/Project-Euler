using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although 
it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.
 */

namespace Project_Euler___14
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64
                count = 0,
                current = 13,
                highest_count = 0,
                best_starting_number = 0,
                starting_number = 13;

            while(starting_number < 1000000)
            {
                while (current > 1)
                {
                    if (current % 2 == 0)
                    {
                        current = current / 2;
                    }
                    else
                    {
                        current = 3 * current + 1;

                    }
                    count++;
                    if(count > highest_count)
                    {
                        highest_count = count;
                        best_starting_number = starting_number;
                    }
                }
                count = 0;
                starting_number++;
                current = starting_number;
            }
            Console.WriteLine("{0} count:{1}", best_starting_number, highest_count);
            Console.ReadLine();
        }
    }
}
