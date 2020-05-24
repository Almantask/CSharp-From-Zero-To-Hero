using System;
using System.IO;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace SeleniumTests.Tests
{
    public class ApiumDriverFixture : IDisposable
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private string pathToAppUnderTest = $@"C:\CleanCodeSeries.Workshop\src\CleanCodeSeries.Workshop.Lesson8.DummyApp.Desktop\CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk\bin\Debug\CleanCodeSeries.Workshop.Lesson8.DummyApp.Desk.exe";
        public WindowsDriver<WindowsElement> Driver;

        public ApiumDriverFixture()
        {
            LaunchAppAndListen();
        }

        private void LaunchAppAndListen()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", pathToAppUnderTest);
            Driver = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
        }

        public void Dispose()
        {
            Driver.Dispose();
        }
    }
}
