using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Solution
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 8, 9, 7, 6 };
            //int k = 3;
            //int[] tempArray = { };
            //tempArray = CyclicRotation.Solution(array, k);



            int number = 0;
            int solutionResult = 0;
            Console.WriteLine("Please enter a number");
            number = Convert.ToInt32(Console.ReadLine());
           

            solutionResult = solutionForBinary(number);

          

            if (solutionResult > 0)
            {
                Console.WriteLine(string.Format("The longest binary gap for the given number is : {0}", solutionResult));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The given number does not have a binary gap.");
                Console.ReadLine();
            }
        }

        public static int solutionForBinary(int number)
        {
            string binaryRepresentation = Convert.ToString(number, 2);

            // search max binary gap
            int longestBinaryGap = 0;
            int binaryGapLenght = 0;
            for (int i = 1; i < binaryRepresentation.Length; i++)
            {
                if (binaryRepresentation[i - 1] == '1' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght = 1;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '0')
                {
                    binaryGapLenght++;
                }
                else if (binaryRepresentation[i - 1] == '0' && binaryRepresentation[i] == '1')
                {
                    longestBinaryGap = Math.Max(longestBinaryGap, binaryGapLenght);
                }
            }

            return longestBinaryGap;
        }


    }
}

