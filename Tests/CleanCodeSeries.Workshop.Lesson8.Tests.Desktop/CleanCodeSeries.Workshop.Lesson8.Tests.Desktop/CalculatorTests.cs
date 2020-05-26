using System;
using OpenQA.Selenium.Appium.Windows;
using System.Threading;
using Xunit;

namespace CleanCodeSeries.Workshop.Lesson8.Tests.Desktop
{
    public class CalculatorTests:IClassFixture<ApiumDriverFixture>, IDisposable
    {
        private WindowsDriver<WindowsElement> _driver;

        // Single setup for all
        public CalculatorTests(ApiumDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }
             
        [Fact]
        public void Add_TwoNumbers_Returns_Expected()
        {
            TestMathOperation(1, 2, "+", 3);
        }

        [Fact]
        public void Subtract_TwoNumbers_Returns_Expected()
        {
            TestMathOperation(1, 2, "-", -1);
        }

        [Fact]
        public void Multiple_TwoNumbers_Returns_Expected()
        {
            TestMathOperation(1, 2, "x", 2);
        }

        [Fact]
        public void Divide_TwoNumbers_Returns_Expected()
        {
            TestMathOperation(1, 2, "/", 0.5m);
        }

        private void TestMathOperation(int number1, int number2, string operation, decimal expectedResult)
        {
            // Finds element by text rendered.
            _driver.FindElementByName(number1.ToString()).Click();
            _driver.FindElementByName(operation).Click();
            _driver.FindElementByName(number2.ToString()).Click();
            _driver.FindElementByName("=").Click();

            // Finds element by control id.
            var result = _driver.FindElementByAccessibilityId("TextBoxResult");

            Assert.Equal(expectedResult.ToString(), result.Text);
        }

        // Teardown per test
        public void Dispose()
        {
            _driver.FindElementByName("C").Click();
        }
    }
}
