using System;
using IFizzBuzzServiceNS;

namespace FizzBuzzService
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly string _fizz = "Fizz";
        private readonly string _buzz = "Buzz";

        private readonly int _fizzDenominator;
        private readonly int _buzzDenominator;
        private readonly int _maxFizzBuzzCount = 9999;

        public FizzBuzzService(int fizzDenominator = 3, int buzzDenominator = 5)
        {
            _fizzDenominator = fizzDenominator;
            _buzzDenominator = buzzDenominator;
        }

        public string GetFizzBuzz(int nominator)
        {
            string fizzBuzz = string.Empty;
            fizzBuzz += IsFizz(nominator) ? _fizz : string.Empty;
            fizzBuzz += IsBuzz(nominator) ? _buzz : string.Empty;

            if (fizzBuzz.Length == 0)
                fizzBuzz = nominator.ToString();

            return fizzBuzz;
        }

        public bool IsFizz(int nominator)
        {
            return DivisibleBy(nominator, _fizzDenominator) ? true : false;
        }

        public bool IsBuzz(int nominator)
        {
            return DivisibleBy(nominator, _buzzDenominator) ? true : false;
        }

        public string[] RunFizzBuzz(int count)
        {
            if (count <= 0 || count > _maxFizzBuzzCount)
            {
                Console.WriteLine("Count out of bounds. (1 - " + _maxFizzBuzzCount + ")");
                return new string[0];
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
            if (denominator == _fizzDenominator || denominator == _buzzDenominator)
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

