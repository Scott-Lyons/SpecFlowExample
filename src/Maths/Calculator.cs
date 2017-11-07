using System.Collections.Generic;
using System.Linq;

namespace Maths
{
    public class Calculator
    {
        private List<int> _numbers = new List<int>();

        public void AddNumber(int number) => _numbers.Add(number);
        public void AddNumbers(List<int> numbers) => _numbers = numbers;

        public int Add() => _numbers.Sum();
    }
}
