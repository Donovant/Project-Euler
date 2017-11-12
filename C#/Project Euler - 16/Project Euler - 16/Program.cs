using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?
*/
 
namespace Project_Euler___16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger
                number = (BigInteger)Math.Pow(2, 1000),
                sum = 0,
                temp = number;

            while(temp > 0)
            {
                sum += temp % 10;
                temp = temp / 10;
            }
            Console.WriteLine("{0}", sum);
            Console.ReadLine();
        }
    }
}
