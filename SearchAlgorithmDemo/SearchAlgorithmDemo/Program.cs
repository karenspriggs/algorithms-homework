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
            Searches.data = FileReader.ReadDataFromFileToArray();


        }
    }

    public static class Searches
    {
        public static string[] data;

        public static int LinearSearch(string _valueToFind)
        {
            return 0;
        }

        public static int BinarySearch(string _valueToFind)
        {
            return 0;
        }

        public static int InterpolationSearch(string _valueToFind)
        {
            return 0;
        }
    }

    public static class FileReader
    {
        public static string fileName;

        public static string[] ReadDataFromFileToArray()
        {
            List<string> output = new List<string>();
            string[] ArrayOutput;
            int arraySize = 0;

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Add(element);
                element = streamReader.ReadLine();
                arraySize++;
            }

            ArrayOutput = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                ArrayOutput[i] = output[i];
            }

            return ArrayOutput;
        }
    }
}
