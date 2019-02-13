using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzService;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void DivisibleBy_DivideByThree_ModulusEqualZero()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            int divider = 3;
            for (int count = 0; count < 100; count += 3)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }

        [TestMethod]
        public void DivisibleBy_DivideByFive_ModulusEqualZero()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            int divider = 5;
            for(int count=0; count < 100; count+=5)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_NegativeNumbers_OutOfRangeException()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            fizzBuzzService.DivisibleBy(10, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_DivideByZero_OutOfRangeException()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            fizzBuzzService.DivisibleBy(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DivisibleBy_DenominatorThreeFiveFifteen_OutOfRangeException()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            for(int i = 1; i < 100; i++)
            {
                fizzBuzzService.DivisibleBy(10, i);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetFizzBuzz_NegativeCount_OutOfRangeException()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            fizzBuzzService.RunFizzBuzz(-1);
        }
    }
}
