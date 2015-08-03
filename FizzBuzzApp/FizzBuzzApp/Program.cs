using System;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            
            for (int index = 1; index <= 100; index++)
            {
                var result = fizzBuzz.MultipleOfThreeAsFizz(index);
                result += fizzBuzz.MultipleOfFiveAsBuzz(index);
                if (string.IsNullOrWhiteSpace(result)) { result = index.ToString(); }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
