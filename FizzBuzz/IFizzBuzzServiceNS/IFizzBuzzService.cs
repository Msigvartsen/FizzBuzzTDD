using System.Collections.Generic;

namespace IFizzBuzzServiceNS
{
    public interface IFizzBuzzService
    {
        string[] RunFizzBuzz(int count);
        string GetFizzBuzz(int nominator);
        bool DivisibleBy(int nominator, int denominator);
    }
}
