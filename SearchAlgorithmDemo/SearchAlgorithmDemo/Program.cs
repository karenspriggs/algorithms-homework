using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SearchAlgorithmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.fileName = "scores.txt";
            int[] dataArray = FileReader.ReadDataFromFileToArray();

            SortingAlgorithms.BubbleSort(dataArray);
            SortingAlgorithms.InsertionSort(dataArray);
            SortingAlgorithms.SelectionSort(dataArray);
            SortingAlgorithms.HeapSort(dataArray);
            SortingAlgorithms.QuickSort(dataArray, 0, dataArray.Length-1);
            SortingAlgorithms.MergeSort(dataArray, 0, dataArray.Length - 1);

            Console.ReadKey();
        }
    }

    public static class FileReader
    {
        public static string fileName;

        public static int[] ReadDataFromFileToArray()
        {
            List<int> output = new List<int>();
            int[] ArrayOutput;
            int arraySize = 0;

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            int element = Convert.ToInt32(streamReader.ReadLine());

            while (element != null)
            {
                output.Add(element);
                element = Convert.ToInt32(streamReader.ReadLine());
                arraySize++;
            }

            ArrayOutput = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                ArrayOutput[i] = output[i];
            }

            return ArrayOutput;
        }
    }
}
