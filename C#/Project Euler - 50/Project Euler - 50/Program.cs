using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The prime 41, can be written as the sum of six consecutive primes:

41 = 2 + 3 + 5 + 7 + 11 + 13
This is the longest sum of consecutive primes that adds to a prime below one-hundred.

The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.

Which prime, below one-million, can be written as the sum of the most consecutive primes?
*/

namespace Project_Euler___50
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                count = 0,
                largest = 1000000,
                largest_count = 1,
                sum = 0,
                target = 0;
            List<int>
                list = new List<int>();

            for(int x = 1; x < largest; x++)
            {
                if(is_prime(x))
                {
                    list.Add(x);
                }
            }

            for (int x = 0; x < list.Count; x++)
            {
                if (sum + list[x] < 1000000 && sum == 0)
                {
                    count++;
                    sum = list[x];
                }
                else
                {
                    break;
                }
                for (int y = x+1; y < list.Count; y++)
                {
                    if (sum + list[y] < 1000000)
                    {
                        count++;
                        sum += list[y];
                    }
                    else
                    {
                        break;
                    }
                }
                if(count > largest_count && is_prime(sum))
                {
                    largest_count = count;
                    target = sum;
                }
                count = 0;
                sum = 0;
            }
            
            Console.WriteLine(target);
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
