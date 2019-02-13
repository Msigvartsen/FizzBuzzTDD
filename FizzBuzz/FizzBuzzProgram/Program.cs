using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFizzBuzzServiceNS;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new IFizzBuzzService();

            foreach(string result in fizzBuzzService.GetFizzBuzz(100))
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
