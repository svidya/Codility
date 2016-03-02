using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class OddOccurancesInArray
    {
       public static int GetTheOddNumberFromArray(int[] A)
        {   
            return A.Aggregate((x, y) => x ^ y);
        }
    }
}
