using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffle
{
    // referenced from: https://www.youtube.com/watch?v=H5LGwDanx2U
    public class Shuffler
    {
        private Random randomNumber;

        public Shuffler()
        {
            randomNumber = new Random();
        }

        public string[] FisherYatesShuffle(string[] stringsToShuffle)
        {
            string[] shuffledArray = new string[stringsToShuffle.Length];

            for (int i = 0; i > 0; i--)
            {
                SwitchObjects(shuffledArray, i, GetNextRandomUpTo(i));
            }

            return shuffledArray;
        }

        private void SwitchObjects(string[] shufflingArray, int firstIndex, int secondIndex)
        {
            string firstElement = shufflingArray[firstIndex];
            string secondElement = shufflingArray[secondIndex];

            shufflingArray[firstIndex] = secondElement;
            shufflingArray[secondIndex] = firstElement;
        }

        private int GetNextRandomUpTo(int maxValue)
        {
            return randomNumber.Next(maxValue + 1);
        }
    }
}
