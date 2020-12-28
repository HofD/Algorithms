using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Numeric
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

        /// <summary>
        /// Нахождение простых множителей
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> FindFactors(int number)
        {
            List<int> factors = new List<int>();

            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            int i = 3;
            int maxFactor = (int)Math.Sqrt(number);

            while (i < maxFactor)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                    maxFactor = (int)Math.Sqrt(number);
                }

                i += 2;
            }

            if (number > 1)
                factors.Add(number);

            return factors;
        }

        /// <summary>
        /// Нахождение простых элементов
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static List<long> FindPrimes(long maxNumber)
        {
            // Определяем массив чисел
            bool[] isComposite = new bool[maxNumber + 1];

            // Исключаем числа, кратные 2
            for (long i = 4; i <= maxNumber; i += 2)
            {
                isComposite[i] = true;
            }

            // Исключаем числа, кратные найденным простым числам
            long nextPrime = 3;
            long stopAt = (long)Math.Sqrt(maxNumber);

            while (nextPrime <= stopAt)
            {
                // Исключаем числа, кратные найденным простым числам
                for (long i = nextPrime * 2; i <= maxNumber; i += nextPrime)
                {
                    isComposite[i] = true;
                }
                // Переходим к следующему простому числу, пропуская четные числа
                nextPrime += 2;
                while (nextPrime <= maxNumber && isComposite[nextPrime])
                {
                    nextPrime += 2;
                }
            }

            // Заносим простые числа в список
            List<long> primes = new List<long>();
            for (long i = 2; i <= maxNumber; i++)
            {
                if (!isComposite[i])
                    primes.Add(i);
            }

            // Возвращаем простые числа
            return primes;
        }

        public static int[,] Matrix(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(1), array2.GetLength(1)];
            for (int i = 0; i < array1.GetLength(1); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < array2.GetLength(1); k++)
                    {
                        result[i, j] = result[i, j] + array1[i, k] * array2[k, j];
                    }
                }
            }

            return result;
        }
    }
}
