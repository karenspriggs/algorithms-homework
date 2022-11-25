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
                for (int j = i+1; j < data.Length; j++)
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
            for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = i-1; j > 0; j--)
                {
                    if (data[j]< data[j - 1])
                    {
                        int tempvalue = data[j];
                        data[j-1] = data[j];
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

                for (int j = i+i; j<data.Length; j++)
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

        public static void HeapSort(int[] data)
        {

        }

        public void MakeHeap(int[] data)
        {

        }

        // Quick sort has a best case complexity of O(n log n) and a worst case of O(n2)
        public static void QuickSort(int[] data)
        {

        }

        // Merge sort has an average complexity of O(n log n) 
        public static void MergeSort(int[] data)
        {

        }
    }
}
