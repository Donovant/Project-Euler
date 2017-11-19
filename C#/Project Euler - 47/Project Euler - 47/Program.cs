using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The first two consecutive numbers to have two distinct prime factors are:

14 = 2 × 7
15 = 3 × 5

The first three consecutive numbers to have three distinct prime factors are:

644 = 2² × 7 × 23
645 = 3 × 5 × 43
646 = 2 × 17 × 19.

Find the first four consecutive integers to have four distinct prime factors. What is the first of these numbers?
*/

namespace Project_Euler___47
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                num1 = 0,
                num2 = 0,
                num3 = 0,
                num4 = 0,
                count = 0; 
            List<int> list = new List<int>();

            for(int x = 1; x < 100000; x++)
            {
                if(is_prime(x))
                {
                    list.Add(x);
                }
            }

            for (int x = 1; x < 1000000; x++)
            {
                for(int y = 0; list[y] < list.Count; y++)
                {
                    if(x % list[y] == 0)
                    {
                        count++;
                        if(count == 4)
                        {
                            num4 = num3;
                            num3 = num2;
                            num2 = num1;
                            num1 = x;

                            if(num1 - 1 == num2 && num2 - 1 == num3 && num3 - 1 == num4)
                            {
                                Console.WriteLine("{0}", num4);
                                x = 1000000;
                                break;
                            }
                        }
                    }
                }
                count = 0;
            }
            
            Console.ReadLine();
        }

        static bool is_prime(int inc)
        {
            bool is_prime = true;

            if (inc == 1) return false;
            if (inc == 2) return true;
            if (inc % 2 == 0) return false;

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
