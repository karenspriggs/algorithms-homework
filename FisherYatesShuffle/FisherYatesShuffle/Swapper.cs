using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffle
{
    // Abstracted out the method that switches the placement of two strings in a list to its own class
    public static class Swapper
    {
        public static void SwitchStringsAt(List<string> shuffledList, int firstIndex, int secondIndex)
        {
            string firstElement = shuffledList[firstIndex];
            string secondElement = shuffledList[secondIndex];

            shuffledList[firstIndex] = secondElement;
            shuffledList[secondIndex] = firstElement;
        }
    }
}
