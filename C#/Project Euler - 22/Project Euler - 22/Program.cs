using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
Using names.txt, a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file?
*/

namespace Project_Euler___22
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                total = 0,
                x = 0;
            string
                line;
            string[]
                names = new string[1];

            StreamReader sr = new StreamReader("names.txt");

            while ((line = sr.ReadLine()) != null)
            {
                line = line.Replace("\"", string.Empty);
                names = line.Split(',');
            }
            sr.Close();

            Array.Sort(names);

            foreach(string s in names)
            {
                x++;
                int
                    tempSum = 0;
                char[] name = new char[s.Length];
                using(StringReader reader = new StringReader(s))
                {
                    reader.Read(name, 0, s.Length);
                    for(int y = 0; y < s.Length; y++)
                    {
                        tempSum += (int)name[y]-64;
                    }
                    total += tempSum * x;
                }
            }
            
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
