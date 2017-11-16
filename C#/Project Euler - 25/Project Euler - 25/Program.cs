using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
The Fibonacci sequence is defined by the recurrence relation:

Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
Hence the first 12 terms will be:

F1 = 1
F2 = 1
F3 = 2
F4 = 3
F5 = 5
F6 = 8
F7 = 13
F8 = 21
F9 = 34
F10 = 55
F11 = 89
F12 = 144
The 12th term, F12, is the first term to contain three digits.

What is the first term in the Fibonacci sequence to contain 1000 digits?
*/

namespace Project_Euler___25
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger
                count = 0,
                first = 1,
                second = 1,
                term = 2,
                tmp = 0;

            while(count < 1000)
            {
                tmp = first + second;
                first = second;
                second = tmp;
                term++;
                while(tmp > 0)
                {
                    tmp = tmp / 10;
                    count++;
                }
                if(count == 1000)
                {
                    Console.WriteLine(term);
                    break;
                }
                count = 0;
            }

            Console.ReadLine();
        }
    }
}
