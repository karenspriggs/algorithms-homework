using System;
using System.Collections.Generic;
using System.Text;

namespace FisherYatesShuffle
{
    // Abstracted out the random number generation to a separate class
    public static class RandomHandler
    {
        private static Random randomNumber = new Random();

        public static int GetNextRandomUpTo(int maxValue)
        {
            return randomNumber.Next(maxValue + 1);
        }
    }
}
