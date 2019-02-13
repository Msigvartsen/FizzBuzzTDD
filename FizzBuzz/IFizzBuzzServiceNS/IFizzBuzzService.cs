namespace IFizzBuzzServiceNS
{
    public interface IFizzBuzzService
    {
        string[] RunFizzBuzz(int count);
        string GetFizzBuzz(int nominator);

        bool IsFizz(int nominator);
        bool IsBuzz(int nominator);
        bool DivisibleBy(int nominator, int denominator);
    }
}
