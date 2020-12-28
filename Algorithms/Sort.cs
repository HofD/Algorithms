using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sort
    {
        public static void QuickSort(int[] values, int start, int end)
        {
            // Если в массиве не более одного элемента, значит, он отсортирован
            if (start >= end) return;
            // Используем первый элемент как разделяющий
            int divider = values[start];
            int lo = start;
            int hi = end;

            while (true)
            {
                while (values[hi] >= divider)
                {
                    hi = hi - 1;
                    if (hi <= lo) break;
                }
                if (hi <= lo)
                {
                    values[lo] = divider;
                    break;
                }
                values[lo] = values[hi];
                lo += 1;
                while (values[lo] < divider)
                {
                    lo = lo + 1;
                    if (lo >= hi) break;
                }
                if (lo >= hi)
                {
                    lo = hi;
                    values[hi] = divider;
                    break;
                }
                values[hi] = values[lo];
            }

            QuickSort(values, start, lo - 1);
            QuickSort(values, lo + 1, end);
        }

        public static void MergeSort(int[] values, int[] scratch, int start, int end)
        {
            if (start == end) return;
            int midpoint = (start + end) / 2;
            MergeSort(values, scratch, start, midpoint);
            MergeSort(values, scratch, midpoint + 1, end);
            int leftIndex = start;
            int rightIndex = midpoint + 1;
            int scrathIndex = leftIndex;
            while((leftIndex <= midpoint) && (rightIndex <= end))
            {
                if (values[leftIndex] <= values[rightIndex])
                {
                    scratch[scrathIndex] = values[leftIndex];
                    leftIndex++;
                }
                else
                {
                    scratch[scrathIndex] = values[rightIndex];
                    rightIndex++;
                }
                scrathIndex++;
            }

            for (int i = leftIndex; i <= midpoint; i++)
            {
                scratch[scrathIndex] = values[i];
                scrathIndex++;
            }
            for (int i = rightIndex; i <= end; i++)
            {
                scratch[scrathIndex] = values[i];
                scrathIndex++;
            }
            for (int i = start; i <= end; i++)
            {
                values[i] = scratch[i];
            }
        }
    }
}
