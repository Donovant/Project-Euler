using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

Evaluate the sum of all the amicable numbers under 10000.
 */

namespace Project_Euler___21
{
    public static class Globals
    {
        public static int grand_total = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int
                current = 1,
                sum_of_proper_divisors = 0,
                sum_of_proper_divisors2 = 0,
                sum_of_all_amicable = 0;

            while (current < 10001)
            {
                sum_of_proper_divisors = find_sum(current);
                sum_of_proper_divisors2 = find_sum(sum_of_proper_divisors);

                if (sum_of_proper_divisors2 == current && current != sum_of_proper_divisors)
                {
                    sum_of_all_amicable += current;
                }
                current++;
            }

            Console.WriteLine(sum_of_all_amicable);
            Console.ReadLine();
        }

        static int find_sum(int incoming)
        {
            int
                sum = 1;

            for (int x = 2; x < incoming; x++)
            {
                if(incoming % x == 0)
                {
                    sum += x;
                }
            }
            
            return sum;
        }
    }
}
