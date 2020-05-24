using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests.Tests
{
    // Initialize and reuse heavy components across the test suite.
    public class SeleniumDriverFixture:IDisposable
    {
        public IWebDriver Driver { get; }
        public string homeUrl = $"http://localhost:{DummyAppTest.Port}";
        public string aboutPageUrl = $"http://localhost:{DummyAppTest.Port}/Home/Contact";

        public SeleniumDriverFixture()
        {
            var dir = Directory.GetCurrentDirectory();

            Driver = new ChromeDriver(dir) { Url = homeUrl };
        }

        // Clean up afte the test suite is done running.
        public void Dispose()
        {
            Driver.Dispose();
        }

    }
}
