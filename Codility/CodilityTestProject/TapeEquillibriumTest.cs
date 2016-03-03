using System;
using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTestProject
{
    [TestClass]
    public class TapeEquillibriumTest
    {
        [TestMethod]
        public void Get_Minimal_Difference_From_Array()
        {
            int[] A = { 3,1,2,4,3};

            int minimalDifference = TapeEquilibrium.GetMinimalDifferenceFromArray(A);

            Assert.AreEqual(1, minimalDifference);
        }
    }
}
