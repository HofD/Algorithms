using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Numeric
    {
        /// <summary>
        /// Нахождение наибольшего общего делителя (Алгоритм Евклида)
        /// </summary>
        /// <param name="a">Число а</param>
        /// <param name="b">Число b</param>
        /// <returns>НОД</returns>
        public static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        public static void RandomizeArray(int[] array)
        {
            int max_i = array.Length;
            Random rand = new Random();

            for (int i = 0; i < max_i - 1; i++)
            {
                int j = rand.Next(i, max_i);
                int t = array[j];
                array[j] = array[i];
                array[i] = t;
            }
        }
    }
}
