using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class CyclicRotation
    {   
        public static int[] Solution(int[] A,int k)
        {
            int arrayLength = A.Length; 

            int[] tempArray = A.Skip(k-1).ToArray();

            int[] remainingArray = A.Take(k - 1).ToArray();

            tempArray = tempArray.Concat(remainingArray).ToArray();

            return tempArray;    
        }   
    }
}
