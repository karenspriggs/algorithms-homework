using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAlgorithmDemo
{
    public class SortingAlgorithms
    {
        // Bubble sort has an average and worst case complexity of O(n^2) and a best case of O(n)
        // It is the simplest sorting algorithm that swaps two adjacent elements until they are all in the same order
        // It has two nested loops, and the inner loop gets shorter
        // The outer loop always runs n times
        public static void BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        int tempvalue = data[i];
                        data[i] = data[j];
                        data[j] = tempvalue;
                    }
                }
            }
        }

        // Insertion sort has a worse case complexity of O(n^2) and a best case of O(n)
        // It works by separating the items that have been sorted from the ones that have not
        // Once it finds an item in the list that has not been sorted, it goes to look for where the item
        // should be placed relative to the items already sorted
        // 
        public static void InsertionSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i - 1; j > 0; j--)
                {
                    if (data[j] < data[j - 1])
                    {
                        int tempvalue = data[j];
                        data[j - 1] = data[j];
                        data[j] = tempvalue;
                    } else
                    {
                        return;
                    }
                }
            }
        }

        // Selection sort has an average and worst case complexity of O(n^2) and a best case of O(n)
        // It is bad with longer lists and more inefficient than insertion sort
        // It finds the smallest (or largest, depending on the sorting order) item out of the non sorted elements
        // and swaps it with the element after the latest element that was sorted
        // In my example I am finding the smallest element out of the non sorted elements
        public static void SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int currentMinimum = data[i];
                int minimumIndex = i;

                for (int j = i + i; j < data.Length; j++)
                {
                    if (data[j] > currentMinimum)
                    {
                        currentMinimum = data[j];
                        minimumIndex = j;
                    }
                }

                if (currentMinimum != data[i])
                {
                    int tempvalue = data[i];
                    data[i] = currentMinimum;
                    data[minimumIndex] = tempvalue;
                }
            }
        }

        // Heap sort has an average complexity of O(n log n) 
        // Kind of like selectionsort but it keeps the unsorted values in a heap for faster element finding
        // In a heap the largest value is the parent node for all of the nodes in the tree, which means it is found
        // right away, and then once put in the sorted nodes it is removed from the heap
        // Implementation is referenced from : https://www.geeksforgeeks.org/heap-sort/
        public static void HeapSort(int[] data)
        {
            //Build the max heap
            for (int i = data.Length / 2 - 1; i >= 0; i--)
            {
                Heapify(data, data.Length, i);
            }

            for (int i = data.Length - 1; i >= 0; i--)
            {
                int tempvalue = data[i];
                data[i] = data[0];
                data[0] = tempvalue;

                Heapify(data, i, 0);
            }
        }

        public static void Heapify(int[] data, int size, int i)
        {
            int currentlargestindex = i;

            int leftnode = 2 * i + 1;
            int rightnode = 2 * i + 2;

            if (leftnode < size && data[leftnode] > data[currentlargestindex])
            {
                currentlargestindex = leftnode;
            }

            if (rightnode < size && data[rightnode] > data[currentlargestindex])
            {
                currentlargestindex = rightnode;
            }

            if (currentlargestindex != i)
            {
                int tempvalue = data[i];
                data[i] = data[currentlargestindex];
                data[currentlargestindex] = tempvalue;

                Heapify(data, size, currentlargestindex);
            }
        }

        // Quick sort has a best case complexity of O(n log n) and a worst case of O(n2)
        // It uses a divide and conquer approach by dividing the original array into two 
        // arrays, the smallest and lowest values
        // It looks through the array and places all values smaller than the pivot before it
        // and all values larger than the pivot after it
        // This version uses recursion to divide the array into smaller and smaller arrays
        // around the central pivot to sort
        // Referenced from: https://www.geeksforgeeks.org/quick-sort/
        public static void QuickSort(int[] data, int lowvalue, int highvalue)
        {
            if (lowvalue < highvalue)
            {
                int pivotIndex = PickPivot(data, lowvalue, highvalue);

                QuickSort(data, lowvalue, pivotIndex - 1);
                QuickSort(data, pivotIndex + 1, highvalue);
            }
        }

        public static int PickPivot(int[] data, int lowvalue, int highvalue)
        {
            int startingPivot = highvalue;
            int smallindex = lowvalue - 1;

            for (int i = lowvalue; i <= highvalue; i++)
            {
                if (data[i] < startingPivot)
                {
                    smallindex++;

                    int tempvalue = data[i];
                    data[i] = data[smallindex];
                    data[smallindex] = tempvalue;
                }
            }

            int newtempvalue = data[smallindex+1];
            data[smallindex + 1] = data[highvalue];
            data[highvalue] = newtempvalue;

            return smallindex + 1;
        }

        // Merge sort has an average complexity of O(n log n) 
        public static void MergeSort(int[] data)
        {

        }
    }
}
