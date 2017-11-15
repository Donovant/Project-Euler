using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE:   Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one 
        hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
 
*/

namespace Project_Euler___17
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundred = 0;
            string[] numbers =
            {
                "one",          // 0
                "two",          // 1
                "three",        // 2
                "four",         // 3
                "five",         // 4
                "six",          // 5
                "seven",        // 6
                "eight",        // 7
                "nine",         // 8
                "ten",          // 9
                "eleven",       // 10
                "twelve",       // 11
                "thirteen",     // 12
                "fourteen",     // 13
                "fifteen",      // 14
                "sixteen",      // 15
                "seventeen",    // 16
                "eighteen",     // 17
                "nineteen",     // 18
                "twenty",       // 19
                "thirty",       // 20
                "forty",        // 21
                "fifty",        // 22
                "sixty",        // 23
                "seventy",      // 24
                "eighty",       // 25
                "ninety",       // 26
                "hundred",      // 27
                "thousand",     // 28
                "and"};         // 29
            string
                word = "";
            for (int m = 0; m < 1000; m++)
            {
                if (m > 99 && m < 199)
                {
                    hundred = 0;
                }
                else if (m > 199 && m < 299)
                {
                    hundred = 1;
                }
                else if (m > 299 && m < 399)
                {
                    hundred = 2;
                }
                else if (m > 399 && m < 499)
                {
                    hundred = 3;
                }
                else if (m > 499 && m < 599)
                {
                    hundred = 4;
                }
                else if (m > 599 && m < 699)
                {
                    hundred = 5;
                }
                else if (m > 699 && m < 799)
                {
                    hundred = 6;
                }
                else if (m > 799 && m < 899)
                {
                    hundred = 7;
                }
                else if (m > 899 && m < 999)
                {
                    hundred = 8;
                }


                if (m < 20)
                {
                    for (int x = 0; x < 20; x++)
                    {
                        word += numbers[x];
                        m++;
                    }
                }
                if (m > 19 && m < 100)
                {
                    for (int y = 19; y < 27; y++)
                    {
                        for (int z = 0; z < 9; z++)
                        {
                            if(z == 0)
                            {
                                if(y == 20)
                                {
                                    word += numbers[20];
                                }
                                else if(y == 21)
                                {
                                    word += numbers[21];
                                }
                                else if (y == 22)
                                {
                                    word += numbers[22];
                                }
                                else if (y == 23)
                                {
                                    word += numbers[23];
                                }
                                else if (y == 24)
                                {
                                    word += numbers[24];
                                }
                                else if (y == 25)
                                {
                                    word += numbers[25];
                                }
                                else if (y == 26)
                                {
                                    word += numbers[26];
                                }
                                m++;
                            }
                            word += numbers[y];
                            word += numbers[z];
                            m++;
                            
                        }
                    }
                }

                if ((m > 99 && m < 199) || (m > 199 && m < 299) || (m > 299 && m < 399) || (m > 399 && m < 499) || (m > 499 && m < 599) || (m > 599 && m < 699) || (m > 699 && m < 799) || (m > 799 && m < 899) || (m > 899 && m < 999))
                {
                    word += numbers[hundred];
                    word += numbers[27];

                    if ((m > 99 && m < 120) || (m > 199 && m < 220) || (m > 299 && m < 320) || (m > 399 && m < 420) || (m > 499 && m < 520) || (m > 599 && m < 620) || (m > 699 && m < 720) || (m > 799 && m < 820) || (m > 899 && m < 920))
                    {
                        for (int x = 0; x < 20; x++)
                        {
                            word += numbers[hundred];
                            word += numbers[27];
                            word += numbers[29];
                            word += numbers[x];
                            m++;
                        }
                    }

                    for (int y = 19; y < 27; y++)
                    {
                        for (int z = 0; z < 9; z++)
                        {
                            if (z == 0)
                            {
                                if (y == 20)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[20];
                                }
                                else if (y == 21)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[21];
                                }
                                else if (y == 22)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[22];
                                }
                                else if (y == 23)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[23];
                                }
                                else if (y == 24)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[24];
                                }
                                else if (y == 25)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[25];
                                }
                                else if (y == 26)
                                {
                                    word += numbers[hundred];
                                    word += numbers[27];
                                    word += numbers[29];
                                    word += numbers[26];
                                }
                                m++;
                            }
                            word += numbers[hundred];
                            word += numbers[27];
                            word += numbers[29];
                            word += numbers[y];
                            word += numbers[z];
                            m++;
                        }
                    }
                }
            }
            word += "onethousand";
            Console.WriteLine("{0}", word);
            Console.WriteLine("{0}", word.Length);
            Console.ReadLine();
        }
    }
}
