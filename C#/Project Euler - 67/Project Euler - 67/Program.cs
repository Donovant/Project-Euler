using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

            3
        7       4
    2       4       6
8       5       9       3

That is, 3 + 7 + 4 + 9 = 23.

Find the maximum total from top to bottom in triangle.txt (right click and 'Save Link/Target As...'), a 15K text file containing a triangle with one-hundred rows.

NOTE: This is a much more difficult version of Problem 18. It is not possible to try every route to solve this problem, as there are 299 altogether! 
If you could check one trillion (1012) routes every second it would take over twenty billion years to check them all. There is an efficient algorithm to solve it. ;o)
*/

namespace Project_Euler___67
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0,
                lines = 0;
            int[] sums;
            int[,] tree;
            string line;
            string[] linePieces;


            StreamReader sr = new StreamReader("triangle.txt");
            while ((line = sr.ReadLine()) != null)
            {
                lines++;
            }

            sums = new int[lines];
            tree = new int[lines, lines];

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            while ((line = sr.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int y = 0; y < linePieces.Length; y++)
                {
                    tree[x, y] = int.Parse(linePieces[y]);
                }
                x++;
            }
            sr.Close();

            for (int m = lines - 2; m >= 0; m--)
            {
                for (int n = 0; n <= m; n++)
                {
                    tree[m, n] += Math.Max(tree[m + 1, n], tree[m + 1, n + 1]);
                }
            }

            Console.WriteLine("sum: {0}", tree[0, 0]);
            Console.ReadLine();
        }

    }
}

