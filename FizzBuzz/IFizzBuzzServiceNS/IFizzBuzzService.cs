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
            return (numerator % denominator) == 0 ? true : false;
        }
    }
}
