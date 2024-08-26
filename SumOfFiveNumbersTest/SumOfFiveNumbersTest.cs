using SumOfFiveNumbers;
namespace SumOfFiveNumbersTest
{
    public class SumOfFiveNumbersTest
    {
        [Theory]
        [InlineData(1, 2, 3, 4, 5, 15)]
        public void Sum_WithInputNumbers_ShouldReturnCorrectSum(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber, int fifthNumber, int expectedSum)
        {
            int result = SumOfNumbers.Sum(firstNumber, secondNumber, thirdNumber, fifthNumber, fifthNumber);
            Assert.Equal(expectedSum, result);
        }
    }
}