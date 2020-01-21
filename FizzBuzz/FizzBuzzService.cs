using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface IFizzBuzzService
    {
        string[] GetFizzBuzz(uint number);
    }

    public class FizzBuzzService : IFizzBuzzService
    {
        public string[] GetFizzBuzz(uint number)
        {
            string[] result = new string[number];
            for (int i = 0; i < number; i++)
            {
                if ((i + 1) % 15 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if ((i + 1) % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else if ((i + 1) % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else
                {
                    result[i] = (i + 1).ToString();
                }
            }
            return result;
        }
    }
}
