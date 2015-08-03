using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzPlusApp;

namespace FizzBuzzPlusTest
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzzPlus _fizzBuzzPlus;

        [TestInitialize]
        public void Setup()
        {
            _fizzBuzzPlus = new FizzBuzzPlus();
        }

        [TestMethod]
        public void Multiple_Of_Three_Return_Fizz()
        {
            //Arrange
            const int value = 9;
            
            //Act
            var result = _fizzBuzzPlus.MultipleOfThreeAsFizz(value);

            //Assert
            Assert.IsTrue(result.Contains("Fizz"));
        }

        [TestMethod]
        public void Non_Multiple_Of_Three_Return_Empty()
        {
            //Arrange
            const int value = 10;

            //Act
            var result = _fizzBuzzPlus.MultipleOfThreeAsFizz(value);

            //Assert
            Assert.IsTrue(result == string.Empty);
        }

        [TestMethod]
        public void Replace_Three_With_Fizz_Return_Fizz()
        {
            //Arrange
            const int value = 33;

            //Act
            var result = _fizzBuzzPlus.MultipleOfThreeAsFizz(value);

            //Assert
            Assert.IsTrue(result.Contains("Fizz"));
        }

        [TestMethod]
        public void Value_Not_Three_Return_Empty()
        {
            //Arrange
            const int value = 20;

            //Act
            var result = _fizzBuzzPlus.MultipleOfThreeAsFizz(value);

            //Assert
            Assert.IsTrue(result == string.Empty);
        }

        [TestMethod]
        public void Multiples_Of_Five_Return_Buzz()
        {
            //Arrange
            const int value = 15;

            //Act
            var result = _fizzBuzzPlus.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result.Contains("Buzz"));
        }

        [TestMethod]
        public void Non_Multiple_Of_Five_Return_Empty()
        {
            //Arrange
            const int value = 8;

            //Act
            var result = _fizzBuzzPlus.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result == string.Empty);
        }

        [TestMethod]
        public void Replace_Five_With_Buzz_Return_Buzz()
        {
            //Arrange
            const int value = 55;

            //Act
            var result = _fizzBuzzPlus.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result.Contains("Buzz"));
        }

        [TestMethod]
        public void Value_Not_Five_Return_Empty()
        {
            //Arrange
            const int value = 17;

            //Act
            var result = _fizzBuzzPlus.MultipleOfFiveAsBuzz(value);

            //Assert
            Assert.IsTrue(result == string.Empty);
        }
    }
}
