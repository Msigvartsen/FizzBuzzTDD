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
            if(count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count out of bounds. (1 - " + int.MaxValue + ")");
            }
            string[] temp = new string[count];
            
            for(int i = 1; i <= count; i++)
            {
                if (DivisibleBy(i, 15))
                    temp[i] = "FizzBuzz";
                else if (DivisibleBy(i, 5))
                    temp[i] = "Buzz";
                else if (DivisibleBy(i, 3))
                    temp[i] = "Fizz";
                else
                    temp[i] = i.ToString();
            }

            return temp;
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

