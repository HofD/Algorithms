using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find GCD for 4851 and 3003");
            Console.WriteLine($"Result is: {Numeric.Gcd(4851, 3003)}");

            Console.WriteLine("Randomize array 0 1 2 3 4 5 6 7 8 9");
            int[] randArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Numeric.RandomizeArray(randArray);
            Console.WriteLine($"Result is: {randArray[0]} {randArray[1]} {randArray[2]} {randArray[3]} {randArray[4]} {randArray[5]} {randArray[6]} {randArray[7]} {randArray[8]} {randArray[9]}");

            Console.WriteLine("Find factors for 20");
            List<int> factors = Numeric.FindFactors(20);
            Console.WriteLine("Result is:");
            foreach (var factor in factors)
                Console.WriteLine(factor);

            Console.WriteLine("Find primes for 13");
            var primes = Numeric.FindPrimes(13);
            Console.WriteLine("Result is:");
            foreach (var prime in primes)
                Console.WriteLine(prime);

            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = 2;
                    array2[i, j] = 2;
                }
            }

            int[,] resultArray = Numeric.Matrix(array1, array2);

            Console.WriteLine("Quick sort array: 34 21 45 76 75 1 3 0 432 52");
            int[] quickSortArray = new int[] { 34, 21, 45, 76, 75, 1, 3, 0, 432, 52 };
            Sort.QuickSort(quickSortArray, 0, quickSortArray.Length - 1);
            Console.WriteLine($"Result is: {quickSortArray[0]} {quickSortArray[1]} {quickSortArray[2]} {quickSortArray[3]} {quickSortArray[4]} {quickSortArray[5]} {quickSortArray[6]} {quickSortArray[7]} {quickSortArray[8]} {quickSortArray[9]}");
        }
    }
}
