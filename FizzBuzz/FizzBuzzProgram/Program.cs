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
            FizzBuzzService.FizzBuzzService fizzBuzzService = new FizzBuzzService.FizzBuzzService(3,5);

            int count = 100;

            while(true)
            {
                foreach (string result in fizzBuzzService.RunFizzBuzz(count))
                {
                    Console.WriteLine(result);
                }

                string line = Console.ReadLine();
                count = int.TryParse(line, out int val) ? val : 100;
            }
          
        }
    }
}
