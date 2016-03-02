using System;
using Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodilityTestProject
{
    [TestClass]
    public class FrogLeapTest
    {
        [TestMethod]
        public void Get_Minimal_Number_OfSteps_ByFrog()
        {
            int numberOfSteps = 0;
            int X = 10, Y = 85, D = 30;

            numberOfSteps = FrogLeap.GetMinimalNumberOfSteps(X, Y, D);

            Assert.AreEqual(3, numberOfSteps);
        }
    }
}
