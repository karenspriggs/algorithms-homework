using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FisherYatesShuffle
{
    // Referenced from : https://www.geeksforgeeks.org/basics-of-file-handling-in-c-sharp/
    public static class FileReader
    {
        public static string fileName;

        public static List<string> ReadDataFromFile()
        {
            List<string> output = new List<string>();

            StreamReader streamReader = new StreamReader(fileName);
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

            string element = streamReader.ReadLine();

            while (element != null)
            {
                output.Add(element);
                element = streamReader.ReadLine();
            }

            return output;
        }
    }
}
