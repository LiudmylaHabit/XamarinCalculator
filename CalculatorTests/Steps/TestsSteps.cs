using CalculatorTests.Screens;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace CalculatorTests.Steps
{
    [Binding]
    public class TestsSteps
    {
        MainScreen calc;

        [Given(@"calculator app is initialized")]
        public void GivenCalculatorAppIsInitialized()
        {
            AppInitializer.StartApp();
            calc = new MainScreen();
        }
        
        [When(@"The (.*) number typed at the calculator")]
        public void WhenTheNumberTypedAtTheCalculator(int operand)
        {
            calc.TapOnButton(operand.ToString());
        }
        
        [When(@"I select a sign like plus")]
        public void WhenISelectASignLikePlus()
        {
            calc.TapOnPlus();
        }
        
        [When(@"I tap on equal button")]
        public void WhenITapOnEqualButton()
        {
            calc.TapOnEquel();
        }
        
        [Then(@"I see the (.*) of operation at the input field")]
        public void ThenISeeTheOfOperationAtTheInputField(int result)
        {
            Assert.AreEqual(result.ToString(), calc.CalcViewText);
        }
    }
}
