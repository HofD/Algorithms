using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find GCD for 233 and 23");
            Console.WriteLine($"Result is: {Numeric.Gcd(233, 23)}");

            Console.WriteLine("Randomize array 0 1 2 3 4 5 6 7 8 9");
            int[] randArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Numeric.RandomizeArray(randArray);
            Console.WriteLine($"Result is: {randArray[0]} {randArray[1]} {randArray[2]} {randArray[3]} {randArray[4]} {randArray[5]} {randArray[6]} {randArray[7]} {randArray[8]} {randArray[9]}");
        }
    }
}
