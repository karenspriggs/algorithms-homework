using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TreeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.fileName = "scores.txt";
            int[] dataArray = FileReader.ReadDataFromFileToArray();

            SortingAlgorithm.InsertionSort(dataArray);

            new BinaryTree(dataArray);
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

        public static class SortingAlgorithm
        {
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
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
