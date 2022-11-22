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
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == _valueToFind)
                {
                    return i;
                }
            }

            // Case for if the value is not found
            return data.Length + 1;
        }

        // Binary search has a best case complexity of O(log n) and a worst case of O(n)
        // It requires the data set to be sorted prior to the search
        // It checks the middle element of the data set, and then determines if the value it is looking for
        // is greater or less than the middle element and then looks at that half of the set only
        // It does this recursively until it finds the value it is looking for
        public static int BinarySearch(int _valueToFind)
        {
            return 0;
        }

        // Interpolation search has a best case complexity of O(log log n) and a worst case of O(n)
        public static int InterpolationSearch(int _valueToFind)
        {
            return 0;
        }
    }
}
