using System;
using Xunit;

namespace XUnitTestFizzBuzz
{
    public class UnitTest1
    {
        //Fake method
        static string GetFizzBuzz(uint num)
        {
            switch (num)
            {
                case 1:
                    return "1";
                case 3:
                    return "Fizz";
                case 5:
                    return "Buzz";
                case 13:
                    return "13";
                case 15:
                    return "FizzBuzz";
                default:
                    return "";
            }
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(13, "13")]
        [InlineData(15, "FizzBuzz")]
        public void TestFizzBuzz(uint num, string expected)
        {
            string actual = GetFizzBuzz(num);
            Assert.Equal(expected, actual);
        }
        
    }
}
