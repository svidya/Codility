using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public static class FrogLeap
    {
        public static int GetMinimalNumberOfSteps(int X,int Y,int D)
        {
            if(D==0)
            {
                return 0;
            }

            double difference = Y - X;
            double distance = D;

            int jumps = (int)Math.Ceiling(difference / distance);
            return jumps;
        }

    }
}
