using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

namespace Project_Euler___6
{
    class Program
    {
        static void Main(string[] args)
        {
            double
                difference = 0,
                square_of_sums = 0,
                sum_of_squares = 0;

            for(double x = 1; x < 101; x++)
            {
                sum_of_squares += Math.Pow(x, 2);
                square_of_sums += x;
            }
            square_of_sums = Math.Pow(square_of_sums, 2);
            difference = square_of_sums - sum_of_squares;
            Console.WriteLine("{0}", difference);
            Console.ReadLine();
        }
    }
}
