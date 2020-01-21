using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface IFizzBuzzService
    {
        string[] GetFizzBuzz(uint number);
    }

    class FizzBuzzService : IFizzBuzzService
    {
        public string[] GetFizzBuzz(uint number)
        {
            throw new NotImplementedException();
        }
    }
}
