using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericsExamples;

namespace GenericSwapClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SwapMethodTestInt()
        {
            //setup
            GenericSwapClass swap = new GenericSwapClass();
            int firstInt = 333;
            int secondInt = 666;
            //act
            swap.SwapFunction<int>(ref firstInt, ref secondInt);
            //assert
            Assert.AreEqual(firstInt, 666);
            Assert.AreEqual(secondInt, 333);

        }
        [TestMethod]

        public void SwapMethodTestVeryLargeNumbers()
        {
            GenericSwapClass swap = new GenericSwapClass();
            int maxPositive = 2147483647;
            int maxNegitive = -2147483647;
            //Act
            swap.SwapFunction<int>(ref maxPositive, ref maxNegitive);
            //Asset
            Assert.AreEqual(maxPositive, -2147483647);
            Assert.AreEqual(maxNegitive, 2147483647);



        }
    }
}
