using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithmDemo
{
    public class SearchingAlgorithms
    {
        public static int[] data;

        // Linear search has a best case complexity of O(1) and a worst case of O(n)
        // It works by sequentially checking every element of a data set
        // It is the slowest because it does not attempt to break up the data set in any way
        // or use complex logic to find out where to look next
        public static int LinearSearch(int _valueToFind)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == _valueToFind)
                {
                    return i;
                }
            }

            Console.WriteLine($"Linear search took {timer.ElapsedMilliseconds} milliseconds to finish");

            // Case for if the value is not found
            return -1;
        }

        // Binary search has a worst case complexity of O(log n) and a best case of O(1)
        // It requires the data set to be sorted prior to the search
        // It checks the middle element of the data set, and then determines if the value it is looking for
        // is greater or less than the middle element and then looks at that half of the set only
        // It does this recursively/iteratively until it finds the value it is looking for
        public static int BinarySearch(int _valueToFind)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            int lowIndex = 0;
            int highIndex = 0;
            int midIndex = 0;

            while (lowIndex != highIndex)
            {
                midIndex = ((lowIndex + highIndex) / 2);

                if (_valueToFind > data[midIndex])
                {
                    lowIndex = midIndex + 1;
                } else
                {
                    highIndex = midIndex - 1;
                }
            }

            Console.WriteLine($"Binary search took {timer.ElapsedMilliseconds} milliseconds to finish");

            // Case for if the value is not found
            return -1;
        }

        // Interpolation search has a best case complexity of O(log log n) and a worst case of O(n)
        // It has the fastest best case complexity score out of the three searching algorithms
        // It works similarly to binary search, but uses keys instead of splitting the array in half
        // and discarding half of the array that is not needed
        // This is better for data sets that are uniformly distributed
        // The key location is calculated based off of the value being searched for
        public static int InterpolationSearch(int _valueToFind, int lowIndex, int highIndex)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            int position;

            if (lowIndex <= highIndex && _valueToFind >= data[lowIndex] && _valueToFind <= data[highIndex])
            {
                position = lowIndex = ((highIndex - lowIndex) / (data[highIndex] - data[lowIndex])) * (_valueToFind - data[lowIndex]);

                if (data[position] == _valueToFind)
                {
                    return position;
                }

                if (data[position] < _valueToFind)
                {
                    return InterpolationSearch(_valueToFind, position + 1, highIndex);
                }

                if (data[position] > _valueToFind)
                {
                    return InterpolationSearch(_valueToFind, lowIndex, position - 1);
                }
            }

            Console.WriteLine($"Interpolation search took {timer.ElapsedMilliseconds} milliseconds to finish");

            // Case for if the value is not found
            return -1;
        }
    }
}
