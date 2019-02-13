using System;
using System.Collections.Generic;
using IFizzBuzzServiceNS;

namespace FizzBuzzService
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly string _fizz = "Fizz";
        private readonly string _buzz = "Buzz";


        public string GetFizzBuzz(int nominator)
        {
            string fizzBuzz = "";

            if (DivisibleBy(nominator, 3))
            {
                fizzBuzz += _fizz;
            }
            if (DivisibleBy(nominator, 5))
            {
                fizzBuzz += _buzz;
            }

            if(fizzBuzz.Length == 0)
                fizzBuzz = nominator.ToString();

            return fizzBuzz;
        }

        public string[] RunFizzBuzz(int count)
        {
            if(count <= 0 || count > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Count out of bounds. (1 - " + int.MaxValue + ")");
            }

            string[] fizzBuzzValues = new string[count];

            for (int i = 1; i <= count; i++)
            {
                fizzBuzzValues[i - 1] = GetFizzBuzz(i);
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

