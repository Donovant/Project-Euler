using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
The first known prime found to exceed one million digits was discovered in 1999, and is a Mersenne prime of the form (2^6972593)−1; it contains 
exactly 2,098,960 digits. Subsequently other Mersenne primes, of the form 2p−1, have been found which contain more digits.

However, in 2004 there was found a massive non-Mersenne prime which contains 2,357,207 digits: 28433×(2^7830457)+1.

Find the last ten digits of this prime number.
*/

namespace Project_Euler___97
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            BigInteger
                count = 0,
                current = 28433;

            current = 28433 * BigInteger.Pow(2, 7830457) + 1;


            Console.WriteLine(current % 10000000000);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadLine();
        }
    }
}
