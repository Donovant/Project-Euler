using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
 */
namespace Project_Euler___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 x = 600851475143;
            Int64 nextFactor = 2;
            Int64 lpf = 0;
            
            while (x > 1)
            {
                if (x % nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (x % nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;
                    } while (nextFactor < x);
                }

                x /= nextFactor;
                if (nextFactor > lpf)
                {
                    lpf = nextFactor;
                }
            }


            Console.WriteLine("{0}", lpf);
            Console.ReadLine();
        }


    }
}
