namespace FizzBuzzApp
{
    public class FizzBuzz
    {
        public string MultipleOfThreeAsFizz(int value)
        {
            return (value % 3 == 0)? "Fizz": string.Empty;
        }

        public string MultipleOfFiveAsBuzz(int value)
        {
            return (value%5 == 0) ? "Buzz" : string.Empty;
        }

        public string MultipleOfFiveAndThreeAsFizzBuzz(int value)
        {
            return (value %3 == 0 && value % 5 == 0) ? "FizzBuzz" : string.Empty;
        }
        
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
