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
        // 
        public static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                
            }
        }

        // Selection sort has an average and worst case complexity of O(n^2) and a best case of O(n)
        // It is bad with longer lists and more inefficient than insertion sort
        // It finds the smallest item out of the non sorted elements and swaps it with the element
        // after the latest element that was sorted
        public static void SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {

            }
        }

        // Heap sort has an average complexity of O(n log n) 
        public static void HeapSort(int[] data)
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
