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

        public string[] GetFizzBuzz(int count)
        {
            if(count <= 0 || count > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Count out of bounds. (1 - " + int.MaxValue + ")");
            }

            string[] fizzBuzzValues = new string[count];
            
            for(int i = 1; i <= count; i++)
            {
                if (DivisibleBy(i, 15))
                {
                    fizzBuzzValues[i - 1] = "FizzBuzz";
                }
                else if (DivisibleBy(i, 5))
                {
                    fizzBuzzValues[i - 1] = "Buzz";
                }
                else if(DivisibleBy(i, 3))
                {
                    fizzBuzzValues[i - 1] = "Fizz";
                }
                else
                {
                    fizzBuzzValues[i - 1] = i.ToString();
                }
            }

            return fizzBuzzValues;
        }


        public bool DivisibleBy(int numerator, int denominator)
        {
            if (denominator == 3 || denominator == 5 || denominator == 15)
            {
                return (numerator % denominator) == 0 ? true : false;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Denominator Out Of Range: (3, 5, 15) For FizzBuzz Program");
            }
        }
    }
}

