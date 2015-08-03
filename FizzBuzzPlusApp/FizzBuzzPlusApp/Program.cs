using System;

namespace FizzBuzzPlusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzPluss = new FizzBuzzPlus();
            for (int value = 1; value < 100; value++)
            {
                var result = fizzBuzzPluss.MultipleOfThreeAsFizz(value);
                result += fizzBuzzPluss.MultipleOfFiveAsBuzz(value);
                if(string.IsNullOrWhiteSpace(result)) { result = value.ToString(); }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
