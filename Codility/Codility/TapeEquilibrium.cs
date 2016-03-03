using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class TapeEquilibrium
    {
        private const int maxLenght = 100000;
        public static int GetMinimalDifferenceFromArray(int[] A)
        {

            int arrayLength = A.Length;
            int[] partialSums = new int[maxLenght];

            // calculate partial sums
            for (int i = 0; i < arrayLength; i++)
            {
                partialSums[i] = i > 0 ? A[i] + partialSums[i - 1] : A[i];
            }

            int minimalValue = int.MaxValue;

            // get minimal value
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int difference = Math.Abs(partialSums[i] - (partialSums[arrayLength - 1] - partialSums[i]));

                minimalValue = difference < minimalValue ? difference : minimalValue;
            }
            return minimalValue;

        }
    }
}
