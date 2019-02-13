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

            int count = 9;
            int divider = 3;

            Assert.IsTrue(fizzBuzzService.DivisibleBy(count, divider));
        }

      
    }
}
