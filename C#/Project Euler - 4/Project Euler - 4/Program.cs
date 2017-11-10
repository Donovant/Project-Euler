using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
 */
namespace Project_Euler___4
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                current,
                largest = 0,
                max = 0,
                rem,
                reverse = 0;

            for(int x = 999; x > 100; x--)
            {
                for(int y = 999; y > 100; y--)
                {
                    current = x * y;
                    max = x * y;

                    while (max > 0)
                    {
                        rem = max % 10;
                        reverse = (reverse * 10) + rem;
                        max = max / 10;
                    }
                    if (current == reverse && current > largest)
                    {
                        largest = current;
                        break;
                    }
                    reverse = 0;
                }
            }
            Console.WriteLine("{0}", largest);
            Console.ReadLine();
        }
    }
}
