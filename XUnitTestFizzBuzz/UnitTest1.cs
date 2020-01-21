using FizzBuzz;
using System;
using Xunit;

namespace XUnitTestFizzBuzz
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(13, "13")]
        [InlineData(15, "FizzBuzz")]
        public void TestFizzBuzz(uint num, string expected)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            string[] actualArray = fizzBuzzService.GetFizzBuzz(num);
            string actual = actualArray[num - 1];
            Assert.Equal(expected, actual);
        }
        
    }
}
