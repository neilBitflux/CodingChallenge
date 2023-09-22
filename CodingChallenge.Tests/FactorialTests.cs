using CodingChallenge.BusinessLogic;
using CodingChallenge.BusinessLogic.Calculators;

namespace CodingChallenge.Tests
{
    public class FactorialTests
    {
        [Theory]
        [InlineData("0", "1")]
        [InlineData("6", "720")]
        [InlineData("7", "5040")]
        [InlineData("8", "40320")]
        [InlineData("99", "933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000")]
        public void Calculate_HappyPath(string value, string result)
        {
            var actual = new Factorial().Calculate(value);
            Assert.Equal(result, actual);
        }
      
        [Theory]
        [InlineData("-1")]
         public void Calculate_When_ArgumentOutOfRangeException_ThrowsCorrectError(string value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Factorial().Calculate(value));
        }

        [Theory]
        [InlineData("1.2")]
        [InlineData("test")]
        public void Calculate_When_ArgumentException_ThrowsCorrectError(string value)
        {
            Assert.Throws<ArgumentException>(() => new Factorial().Calculate(value));
        }
    }

   
}
