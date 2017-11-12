using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: 
    (i) each of the three terms are prime, and,
    (ii) each of the 4-digit numbers are permutations of one another.

There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.

What 12-digit number do you form by concatenating the three terms in this sequence?
*/

namespace Project_Euler___49
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                temp = 0,
                temp1 = 0,
                temp2 = 0,
                temp3 = 0;
            int[]
                tmp1,
                tmp2,
                tmp3;
            tmp1 = new int[4];
            tmp2 = new int[4];
            tmp3 = new int[4];

            List<int> list = new List<int>();
            
            for(int x = 1001; x < 10000; x += 2)
            {
                if(is_prime(x))
                {
                    list.Add(x);
                }
            }

            for (int x = 0; x < list.Count; x++)
            {
                for(int y = 0; y < 10000; y++)
                {
                    temp1 = list[x];
                    temp2 = temp1 + y;
                    temp3 = temp2 + y;

                    if((temp3 < 10000) && (temp2 < 10000) && (temp1 < 10000) && 
                        (is_prime(temp1) && is_prime(temp2) && is_prime(temp3)) &&
                        temp1 != temp2 &&
                        temp2 != temp3 &&
                        temp1 != temp3)
                    {
                        temp = temp1;
                        tmp1[0] = temp / 1000;
                        temp = temp - (tmp1[0] * 1000);
                        tmp1[1] = temp / 100;
                        temp = temp - (tmp1[1] * 100);
                        tmp1[2] = temp / 10;
                        temp = temp - (tmp1[2] * 10);
                        tmp1[3] = temp;

                        temp = temp2;
                        tmp2[0] = temp / 1000;
                        temp = temp - tmp2[0] * 1000;
                        tmp2[1] = temp / 100;
                        temp = temp - tmp2[1] * 100;
                        tmp2[2] = temp / 10;
                        temp = temp - tmp2[2] * 10;
                        tmp2[3] = temp;

                        temp = temp3;
                        tmp3[0] = temp / 1000;
                        temp = temp - tmp3[0] * 1000;
                        tmp3[1] = temp / 100;
                        temp = temp - tmp3[1] * 100;
                        tmp3[2] = temp / 10;
                        temp = temp - tmp3[2] * 10;
                        tmp3[3] = temp;

                        if ((tmp2.Contains(tmp1[0]) && tmp2.Contains(tmp1[1]) && tmp2.Contains(tmp1[2]) && tmp2.Contains(tmp1[3])) &&
                            (tmp3.Contains(tmp1[0]) && tmp3.Contains(tmp1[1]) && tmp3.Contains(tmp1[2]) && tmp3.Contains(tmp1[3])) &&
                            (tmp1.Contains(tmp2[0]) && tmp1.Contains(tmp2[1]) && tmp1.Contains(tmp2[2]) && tmp1.Contains(tmp2[3])) &&
                            (tmp3.Contains(tmp2[0]) && tmp3.Contains(tmp2[1]) && tmp3.Contains(tmp2[2]) && tmp3.Contains(tmp2[3])) &&
                            (tmp1.Contains(tmp3[0]) && tmp1.Contains(tmp3[1]) && tmp1.Contains(tmp3[2]) && tmp1.Contains(tmp3[3])) &&
                            (tmp2.Contains(tmp3[0]) && tmp2.Contains(tmp3[1]) && tmp2.Contains(tmp3[2]) && tmp2.Contains(tmp3[3])))
                        {
                            if(temp1 != 1487)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}", tmp1[0], tmp1[1], tmp1[2], tmp1[3], tmp2[0], tmp2[1], tmp2[2], tmp2[3], tmp3[0], tmp3[1], tmp3[2], tmp3[3]);
                            }
                            

                        }
                    }
                }
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
