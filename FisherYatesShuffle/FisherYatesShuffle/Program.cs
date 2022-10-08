using System;
using System.Collections.Generic;

namespace FisherYatesShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader.fileName = "data.txt";
            List<string> itemsToShuffle = FileReader.ReadDataFromFile();

            Shuffler.FisherYatesAlternativeShuffle(itemsToShuffle);

            Console.WriteLine("Shuffled items:\n");

            foreach(string str in itemsToShuffle)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
