using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Tests;

namespace ICT3101_Calculator.Step_Definitions
{
    [Binding]
    public class CalculatorStepDefinition : Steps
    {
        private Calculator _calculator;
        private double _result;

        public CalculatorStepDefinition(Calculator _calculator)
        {
            this._calculator = _calculator;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void CalculateMeanTimeBetweenFailure(int p0, int p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void CalculateAvailability(int p0, int p1)
        {
            _result = _calculator.systemAvailability(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {                                                                           
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheResultShouldBeInfinity()
        { 
            Assert.That(Double.IsInfinity(_result), Is.EqualTo(true));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(int result)
        {
            Assert.That(_result, Is.EqualTo(result));
        }
    }
}
