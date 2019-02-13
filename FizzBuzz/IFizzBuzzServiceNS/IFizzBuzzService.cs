using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFizzBuzzServiceNS
{
    public class IFizzBuzzService
    {
        public IFizzBuzzService()
        {
        }

        public bool DivisibleBy(int numerator, int denominator)
        {
            if (denominator == 3 || denominator == 5 || denominator == 15)
                return (numerator % denominator) == 0 ? true : false;
            else
                throw new ArgumentOutOfRangeException("Denominator Out Of Range: (3, 5, 15) For FizzBuzz Program");

        }
    }
}

