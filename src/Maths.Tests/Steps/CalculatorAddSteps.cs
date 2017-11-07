using System.Collections.Generic;
using System.Linq;
using Maths.Tests.Entities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Maths.Tests.Steps
{
    [Binding]
    public class CalculatorAddSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private int _actualResult;
        private IEnumerable<Number> _numbers;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            _calculator.AddNumber(number);
        }

        [Given(@"a list of numbers")]
        public void GivenAListOfNumbers(IEnumerable<Number> numbers)
        {
            _numbers = numbers;
        }

        [Given(@"the numbers are entered into the calculator")]
        public void GivenTheNumbersAreEnteredIntoTheCalculator()
        {
            _calculator.AddNumbers(_numbers.Select(number => number.Value).ToList());
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _actualResult = _calculator.Add();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.That(_actualResult, Is.EqualTo(expectedResult));
        }
    }
}
