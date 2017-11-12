using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*
The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.

7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450
Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
*/

namespace Project_Euler___8
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger
                big = BigInteger.Parse("7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450"),
                current = 0,
                largest = 0,
                rem = 0,
                max = big;

            BigInteger[]
                BIarray,
                product_array;
            BIarray = new BigInteger[1000];
            product_array = new BigInteger[13];
            Int64
                cursor = 999;
            Int64[] 
                array;
            array = new Int64[1001];
            
            while(max > 0)
            {
                rem = max % 10;
                BIarray[cursor] = rem;
                max = max / 10;
                cursor--;
            }

            for (int x = 0; x < 986; x++)
            {
                current = (BIarray[x] * BIarray[x + 1] * BIarray[x + 2] * BIarray[x + 3] * BIarray[x + 4] * BIarray[x + 5] * BIarray[x + 6] * BIarray[x + 7] * BIarray[x + 8] * BIarray[x + 9] * BIarray[x + 10] * BIarray[x + 11] * BIarray[x + 12]);
                if(current > largest)
                {
                    largest = current;
                    product_array[0] = BIarray[x];
                    product_array[1] = BIarray[x + 1];
                    product_array[2] = BIarray[x + 2];
                    product_array[3] = BIarray[x + 3];
                    product_array[4] = BIarray[x + 4];
                    product_array[5] = BIarray[x + 5];
                    product_array[6] = BIarray[x + 6];
                    product_array[7] = BIarray[x + 7];
                    product_array[8] = BIarray[x + 8];
                    product_array[9] = BIarray[x + 9];
                    product_array[10] = BIarray[x + 10];
                    product_array[11] = BIarray[x + 11];
                    product_array[12] = BIarray[x + 12];
                }
            }

            Console.WriteLine("{0} x {1} x {2} x {3} x {4} x {5} x {6} x {7} x {8} x {9} x {10} x {11} x {12} = {13}", product_array[0],
                product_array[1],
                product_array[2],
                product_array[3],
                product_array[4],
                product_array[5],
                product_array[6],
                product_array[7],
                product_array[8],
                product_array[9],
                product_array[10],
                product_array[11],
                product_array[12],
                largest);

                Console.ReadLine();
        }
    }
}
