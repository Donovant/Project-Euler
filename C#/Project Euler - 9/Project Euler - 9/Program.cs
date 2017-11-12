using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a^2 + b^2 = c^2

For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/

namespace Project_Euler___9
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = GetProduct();
            if(product != -1)
            {
                Console.WriteLine("Product: {0}", product);
            }
            Console.ReadLine();
        }

        static int GetProduct()
        {
            for (int a = 1; a < 500; a++)
            {
                for (int b = a + 1; b < 500; b++)
                {
                    for (int c = b + 1; c < 500; c++)
                    {
                        if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) && a + b + c == 1000)
                        {
                            Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
                            return (a) * (b) * (c);
                        }
                    }
                }
            }
            return -1;
        }
    }
}
