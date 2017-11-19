using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

9 = 7 + 2×1^2
15 = 7 + 2×2^2
21 = 3 + 2×3^2
25 = 7 + 2×3^2
27 = 19 + 2×2^2
33 = 31 + 2×1^2

It turns out that the conjecture was false.

What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?
*/

namespace Project_Euler___46
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int
                max = 50000,
                result = 1;
            int[] prime_list = ESieve(max);
            bool
                notFound = true;
            List<int>
                comp_list = new List<int>(),
                squares_list = new List<int>();


            for (int x = 1; x < max; x++)
            {
                if ((2 * (int)Math.Pow(x, 2)) < max)
                {
                    squares_list.Add(2 * (int)Math.Pow(x, 2));
                }
            }

            while (notFound)
            {
                result += 2;

                int j = 0;
                notFound = false;
                while (result >= prime_list[j])
                {
                    if (squares_list.Contains(result - prime_list[j]))
                    {
                        notFound = true;
                        break;
                    }
                    j++;
                }
             }

            Console.WriteLine(result);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.ReadLine();
        }

        static int[] ESieve(int upperLimit)
        {
            int
                sieveBound = (int)(upperLimit - 1) / 2,
                upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;
            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int x = 1; x <= upperSqrt; x++)
            {
                if (PrimeBits.Get(x))
                {
                    for (int y = x * 2 * (x + 1); y <= sieveBound; y += 2 * x + 1)
                    {
                        PrimeBits.Set(y, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);
            for (int z = 1; z <= sieveBound; z++)
            {
                if (PrimeBits.Get(z))
                {
                    numbers.Add(2 * z + 1);
                }
            }

            return numbers.ToArray();
        }
    }
}
