using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IFizzBuzzServiceNS;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void DivisibleBy_DivideByThree_ModulusEqualZero()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            int divider = 3;
            for (int count = 0; count < 100; count += 3)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }

        [TestMethod]
        public void DivisibleBy_DivideByFive_ModulusEqualZero()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            int divider = 5;
            for(int count=0; count < 100; count+=5)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }
        [TestMethod]
        public void DivisibleBy_DivideByFifteen_ModulusEqualZero()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            int divider = 15;
            for (int count = 0; count < 100; count += 15)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_NegativeNumbers_ExpectedFail()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            fizzBuzzService.DivisibleBy(10, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_DivideByZero_ExpectedFail()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            fizzBuzzService.DivisibleBy(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_DenominatorThreeFiveFifteen_ExpectedFail()
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            for(int i = 1; i < 100; i++)
            {
                fizzBuzzService.DivisibleBy(10, i);
            }
        }
    }
}
