using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler___1
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            for(int x = 0; x < 1000; x++)
            {
                if(x%3 == 0 || x%5 == 0)
                {
                    sum += x;
                }
            }
            Console.WriteLine("\nsum: {0}", sum);
            Console.ReadLine();
        }
    }
}
