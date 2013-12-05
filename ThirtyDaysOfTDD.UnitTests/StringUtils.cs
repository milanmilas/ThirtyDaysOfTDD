using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThirtyDaysOfTDD.UnitTests
{
    class StringUtils
    {
        internal int FindNumberOfOccurences(string sentenceToScan, string charecterToCount)
        {
                if (charecterToCount.Length != 1)
                {
                    throw new ArgumentException();
                }

                var stringToCheckAsCharacterArray = sentenceToScan.ToCharArray();
                var characterToCheck = Char.Parse(charecterToCount);

                var numberOfOccurences = 0;

                for (int charIdx = 0; charIdx < stringToCheckAsCharacterArray.Length; charIdx++)
                {
                    if (stringToCheckAsCharacterArray[charIdx] == characterToCheck)
                    {
                        numberOfOccurences++;
                    }
                }

                return numberOfOccurences;
        }
    }
}
