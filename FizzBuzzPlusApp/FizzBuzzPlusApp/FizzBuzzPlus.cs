namespace FizzBuzzPlusApp
{
    public class FizzBuzzPlus
    {
        public string MultipleOfThreeAsFizz(int value)
        {
            return (value % 3 == 0 || value.ToString().Contains("3")) ? "Fizz" : "";
        }

        public string MultipleOfFiveAsBuzz(int value)
        {
            return (value % 5 == 0 || value.ToString().Contains("5")) ? "Buzz" : "";
        }
    }
}
