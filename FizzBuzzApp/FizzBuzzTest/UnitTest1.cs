using FizzBuzzApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzz _fizzBuzz;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz(); 
        }

        [TestMethod]
        public void MultipleOfThreeAsFizz_Return_Fizz_For_Muliple_Of_Three()
        {
            //Arrange
            const int value = 9;

            //Act
            var result = _fizzBuzz.MultipleOfThreeAsFizz(value);

            //Assert 
            Assert.IsTrue(result.Contains("Fizz"));
        }

        [TestMethod]
        public void MultipleOfThreeAsFizz_Return_Value_For_Non_Multiple_Three()
        {
            //Arrange
            const int value = 10;

            //Act
            var result = _fizzBuzz.MultipleOfThreeAsFizz(value);

            //Assert
            Assert.IsTrue(result.Contains(string.Empty));
        }

        [TestMethod]
        public void MultipleOfFiveAsBuzz_Return_Buzz_For_Multiple_Of_Five()
        {
            //Arrange
            const int value = 10;

            //Act
            var result = _fizzBuzz.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result.Contains("Buzz"));
        }

        [TestMethod]
        public void MultipleOfFiveAsBuzz_Return_Value_Non_Multiple_Five()
        {
            //Arrange
            const int value = 9;

            //Act
            var result = _fizzBuzz.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result.Contains(string.Empty));
        }

        [TestMethod]
        public void MultipleOfFiveAndThreeAsFizzBuzz_Return_FizzBuzz_For_Multiple_Five_And_Three()
        {
            //Arrange
            const int value = 15;
            
            //Act
            var result = _fizzBuzz.MultipleOfThreeAsFizz(value);
            result += _fizzBuzz.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result.Contains("FizzBuzz"));
        }

        [TestMethod]
        public void MultipleOfFiveAndThreeAsFizzBuzz_Return_EmptyString_For_Non_Multiple_Three_And_Five()
        {
            //Arrange
            const int value = 8;

            //Act
            var result = _fizzBuzz.MultipleOfThreeAsFizz(value);
            result += _fizzBuzz.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(string.IsNullOrWhiteSpace(result));
        }
    }
}
