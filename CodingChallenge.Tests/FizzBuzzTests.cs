using CodingChallenge.BusinessLogic;
using CodingChallenge.BusinessLogic.Calculators;

namespace CodingChallenge.Tests
{
    public class FizzBuzzTests
    {

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        [InlineData(4, "4")]
        [InlineData(5, "Buzz")]
        [InlineData(6, "Fizz")]
        [InlineData(7, "7")]
        [InlineData(8, "8")]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(11, "11")]
        [InlineData(12, "Fizz")]
        [InlineData(13, "13")]
        [InlineData(14, "14")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(16, "16")]
        [InlineData(17, "17")]
        [InlineData(18, "Fizz")]
        [InlineData(19, "19")]
        [InlineData(20, "Buzz")]
        [InlineData(21, "Fizz")]
        [InlineData(22, "22")]
        [InlineData(23, "23")]
        [InlineData(24, "Fizz")]
        [InlineData(25, "Buzz")]
        [InlineData(26, "26")]
        [InlineData(27, "Fizz")]
        [InlineData(28, "28")]
        [InlineData(29, "29")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(31, "31")]
        [InlineData(32, "32")]
        [InlineData(33, "Fizz")]
        [InlineData(34, "34")]
        [InlineData(35, "Buzz")]
        [InlineData(36, "Fizz")]
        public void CalculateFizzBuzzForNumber_HappyPath(int value, string result)
        {
            var actual = new FizzBuzz().CalculateFizzBuzzFornumber(value);
            Assert.Equal(result, actual);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void CalculateFizzBuzzForNumber_OutOfRangeNumberValue_DisplaysCorrectErrorMessage(double value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new FizzBuzz().Calculate(value.ToString()));
        }

        [Theory]
        [InlineData(1.2)]
        public void CalculateFizzBuzzForNumber_ArgumentException_DisplaysCorrectErrorMessage(double value)
        {
            Assert.Throws<ArgumentException>(() => new FizzBuzz().Calculate(value.ToString()));
        }
    }
}
