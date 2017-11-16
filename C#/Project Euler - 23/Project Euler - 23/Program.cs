using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of the 
proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant 
numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two 
abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest 
number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
*/

namespace Project_Euler___23
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                current = 1,
                current_sum = 0,
                largest = 28123,
                sum = 0,
                tmp_sum = 0;
            List<int>
                abundant_numbers = new List<int>(),
                sums_of_abundants = new List<int>();

            for (int x = current; x < largest; x++)
            {
                if(!is_prime(x))
                {
                    current_sum = sum_of_proper_divisors(x);

                    if (current_sum > x)
                    {
                        abundant_numbers.Add(x);
                    }
                }
            }

            for (int y = 0; abundant_numbers[y] < largest/2; y++)
            {
                for(int z = 0; z < abundant_numbers.Count; z++)
                {
                    tmp_sum = abundant_numbers[y] + abundant_numbers[z];
                    sums_of_abundants.Add(tmp_sum);
                }
            }

            List<int> noDupes = sums_of_abundants.Distinct().ToList();

            for (int x = 0; x < largest; x++)
            {
                if(!noDupes.Contains(x))
                {
                    sum += x;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int sum_of_proper_divisors(int inc)
        {
            int sum = 0;

            for (int x = 1; x < inc; x++)
            { 
                if(inc % x == 0)
                {
                    sum += x;
                }
            
            }
            
            return sum;
        }

        static bool is_prime(int inc)
        {
            bool is_prime = true;

            if (inc % 2 == 0)
                is_prime = false;

            for (int x = 3; x <= Math.Sqrt(inc); x += 2)
            {
                if (inc % x == 0)
                {
                    is_prime = false;
                    break;
                }
            }
            return is_prime;
        }
    }
}
