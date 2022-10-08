using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffle
{
    // referenced from: https://www.youtube.com/watch?v=H5LGwDanx2U
    public static class Shuffler
    {
        // Made this work with a list instead of an array
        // Works with strings instead of the generic object to work with the strings read in from a file
        // This method applies the Fisher-Yates shuffle by going from the highest-index element first down
        // to the lowest-index element
        public static void FisherYatesShuffle(this List<string> stringsToShuffle)
        {
            for (int i = stringsToShuffle.Count - 1; i > 0; i--)
            {
                int newIndex = RandomHandler.GetNextRandomUpTo(i);
                Swapper.SwitchStringsAt(stringsToShuffle, i, newIndex);
            }
        }

        // This method uses an opposite approach to the Fisher-Yates shuffle where it goes from the value at the 
        // lowest index to the value at the highest index
        public static void FisherYatesAlternativeShuffle(this List<string> stringsToShuffle)
        {
            // Saved this to a variable since multiple things in this method use it
            int listCount = stringsToShuffle.Count;

            for (int i = 0; i < listCount - 2; i++)
            {
                int newIndex = RandomHandler.GetNextRandomUpTo((listCount - i)-1);
                Swapper.SwitchStringsAt(stringsToShuffle, i, i+newIndex);
            }
        }
    }
}
