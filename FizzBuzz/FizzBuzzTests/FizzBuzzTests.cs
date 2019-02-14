using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            for (int count = 0; count < 100; count += divider)
            {
                Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
            }
        }

        [TestMethod]
        public void DivisibleBy_DivideByFive_ModulusEqualZero()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            int divider = 5;
            for(int count=0; count < 100; count+=divider)
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
        public void DivisibleBy_DenominatorNotDivisibleByThreeOrFive_OutOfRangeException()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            fizzBuzzService.DivisibleBy(10, 2);
        }

        [TestMethod]
        public void RunFizzBuzz_NegativeCount_ShouldReturnZeroLength()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            string[] fizzBuzz = fizzBuzzService.RunFizzBuzz(-1);
            Assert.AreEqual(0, fizzBuzz.Length);
        }

        [TestMethod]
        public void IsFizz_DenominatorEqualsThree_ShouldReturnTrue()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            Assert.IsTrue(fizzBuzzService.IsFizz(9));
        }

        [TestMethod]
        public void IsBuzz_DenominatorEqualsFive_ShouldReturnTrue()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            Assert.IsTrue(fizzBuzzService.IsBuzz(5));
        }

        [TestMethod]
        public void GetFizzBuzz_DenominatorAsFive_ShouldReturnBuzz()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            Assert.AreEqual(fizzBuzzService.GetFizzBuzz(5), "Buzz");
        }

        [TestMethod]
        public void GetFizzBuzz_DenominatorAsThree_ShouldReturnFizz()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            Assert.AreEqual(fizzBuzzService.GetFizzBuzz(3), "Fizz");
        }

        [TestMethod]
        public void GetFizzBuzz_DenominatorAsFifteen_ShouldReturnFizzBuzz()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            Assert.AreEqual(fizzBuzzService.GetFizzBuzz(15), "FizzBuzz");
        }

        [TestMethod]
        public void GetFizzBuzz_NotFizzBuzz_ShouldReturnNumbersOnly()
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            for (int i = 1; i < 15; i++)
            {
                string result = string.Empty;
                result = fizzBuzzService.GetFizzBuzz(i);

                if(int.TryParse(result, out int x))
                {
                    Assert.AreEqual(i.ToString(), result);
                }
            }
        }
    }
}
