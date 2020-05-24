using System;
using OpenQA.Selenium.Appium.Windows;
using SeleniumTests.Tests;
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
        public void TwoNumbers_Addition_Ok()
        {
            TestMathOperation(1, 2, "+", 3);
        }

        [Fact]
        public void TwoNumbers_Substraction_Ok()
        {
            TestMathOperation(1, 2, "-", -1);
        }

        [Fact]
        public void TwoNumbers_Multiplication_Ok()
        {
            TestMathOperation(1, 2, "x", 2);
        }

        [Fact]
        public void TwoNumbers_Division_Ok()
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
