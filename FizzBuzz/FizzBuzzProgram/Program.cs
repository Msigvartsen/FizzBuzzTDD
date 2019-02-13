using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzService;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService();

            foreach(string result in fizzBuzzService.RunFizzBuzz(100))
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
