using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
You are given the following information, but you may prefer to do some research for yourself.

1 Jan 1900 was a Monday.
Thirty days has September,
April, June and November.
All the rest have thirty-one,
Saving February alone,
Which has twenty-eight, rain or shine.
And on leap years, twenty-nine.
A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
*/

namespace Project_Euler___19
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                count = 1,
                day_of_week = 0,
                days = 1,
                first_year = 1,

                year = 1900;

            while(year < 2001)
            {
                for(int x = 1; x < 13; x++)
                {
                    if(x == 2 && year % 4 == 0 && year % 400 != 0)
                    {
                        if(year == 1900)
                        {
                            first_year += 29;
                        }
                        days += 29;
                    }
                    else if (x == 2)
                    {
                        if (year == 1900)
                        {
                            first_year += 28;
                        }
                        days += 28;
                    }
                    else if(x == 4 || x == 6 || x == 9 || x == 11)
                    {
                        if (year == 1900)
                        {
                            first_year += 30;
                        }
                        days += 30;
                    }
                    else
                    {
                        if (year == 1900)
                        {
                            first_year += 31;
                        }
                        days += 31;
                    }
                    day_of_week = days % 7;
                    if(day_of_week == 0 && year != 1900)
                    {
                        count++;
                    }
                }
                year++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
