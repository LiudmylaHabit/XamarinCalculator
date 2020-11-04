using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorTests.Screens;
using NUnit.Framework;

namespace CalculatorTests
{
    public class TestClass
    {
        MainScreen _mainScreen = new MainScreen();

        [SetUp]
        public void BeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        [Test]
        public void Test()
        {
            //MainScreen.Repl();
            _mainScreen.TapOnOne().TapOnPlus().TapOnTwo().TapOnEquel();
            Assert.AreEqual("3", _mainScreen.GetTextFromField());
        }

               
        [TestCase("0", "0")]
        [TestCase("12", "2")]
        [TestCase("9", "1.5")]
        [TestCase("2", "0.333333333333333")]
        public void DivisionTests(string operand, string result)
        {
            _mainScreen.DivisionOperand(operand);
            _mainScreen.TapOnDivision().TapOnSix().TapOnEquel();
            Assert.AreEqual(result, _mainScreen.GetTextFromField());
            //3/2=1.5 -3,25 = crash
        }

        [TestCase("+", "8")]
        [TestCase("-", "4")]
        [TestCase("x", "12")]
        [TestCase("÷", "3")]
        public void MainFunctionsTests(string sign, string result)
        {
            _mainScreen.TapOnSix().TapOnOperator(sign).TapOnTwo().TapOnEquel();
            Assert.AreEqual(result, _mainScreen.GetTextFromField());
        }

        [TestCase("input")]
        [TestCase("existing")]
        public void MultiplyOnZero(string operand)
        {
            if (operand == "input") _mainScreen.TapOnZero();
            _mainScreen.TapOnMultiply().TapOnNine().TapOnSeven().TapOnEquel();
            Assert.AreEqual("0", _mainScreen.GetTextFromField());
        }

        [Test(Description = "Checking reaction on zero division")]
        public void DivisionOnZero()
        {
            _mainScreen.TapOnFour().TapOnThree().TapOnZero()
                .TapOnDivision().TapOnZero().TapOnEquel();
            Assert.AreEqual("Wrong input!", _mainScreen.GetTextFromField());
        }

        [TestCase(2, "9.99999998E+17")]
        [TestCase(3, "9.99999997E+26")]
        [TestCase(4, "9.99999996E+35")]
        [TestCase(5, "9.99999995E+44")]
        [TestCase(6, "9.99999994E+53")]
        [TestCase(10, "9.9999999E+89")]
        public void WorkWithBigNumbers(int count, string result)
        {
            for (int i = 0; i < count; i++)
            {
                _mainScreen.TapOnNine().TapOnNine().TapOnNine().
                    TapOnNine().TapOnNine().TapOnNine()
                    .TapOnNine().TapOnNine().TapOnNine();
                if (i != (count - 1)) _mainScreen.TapOnMultiply();
            }
            _mainScreen.TapOnEquel();
            Assert.AreEqual(result, _mainScreen.GetTextFromField());
        }
    }
}
