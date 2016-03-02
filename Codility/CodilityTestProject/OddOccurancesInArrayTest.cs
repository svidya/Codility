using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility;

namespace CodilityTestProject
{
    [TestClass]
    public class OddOccurancesInArrayTest
    {
        [TestMethod]
        public void Get_The_Odd_Number_OutOfArray()
        {
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            int returnValue = 0;
            returnValue = OddOccurancesInArray.GetTheOddNumberFromArray(A); 
            Assert.AreEqual(7, returnValue);
        }
    }
}
