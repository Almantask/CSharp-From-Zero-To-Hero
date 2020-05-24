using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace SeleniumTests.Tests
{

    public class DummyAppTest:IClassFixture<SeleniumDriverFixture>
    {
        private IWebDriver _driver;
        public const int Port = 52701;
        readonly string homeUrl = $"http://localhost:{Port}";
        readonly string aboutPageUrl = $"http://localhost:{Port}/Home/Contact";

        public DummyAppTest(SeleniumDriverFixture fixture)
        {
            _driver = fixture.Driver;
        }

        [Fact]
        public void MarkettingContact_Ok()
        {
            _driver.Url = aboutPageUrl;

            const string markettingRefXpath = @"/html/body/div[2]/address[2]/a[2]";
            var marketingField = _driver.FindElement(By.XPath(markettingRefXpath));
            Assert.NotNull(marketingField);
            Assert.Equal("Marketing@example.com", marketingField.Text);
        }

        [Fact]
        public void TestButtonAlertPops_TextEmpty_Ok()
        {
            _driver.Url = aboutPageUrl;
            var testButton = _driver.FindElement(By.Id("TestButton"));

            testButton.Click();
            var alertText = GetAlertText();

            Assert.True(string.IsNullOrEmpty(alertText));
        }

        [Fact]
        public async void TestButtonTestButtonClick_TextFilled_Ok()
        {
            _driver.Url = aboutPageUrl;

            var textBox = _driver.FindElement(By.Id("YourNameText"));
            const string name = "Almantas";
            await SimulateTyping(name, textBox, 0);

            var testButton = _driver.FindElement(By.Id("TestButton"));
            testButton.Click();

            var alertText = GetAlertText();
            textBox.Clear();
            Assert.Equal("Almantas", alertText);
        }

        private string GetAlertText()
        {
            var currentWindow = _driver.CurrentWindowHandle;
            var alert = _driver.SwitchTo().Alert();
            var text = alert.Text;
            alert.Accept();
            return text;
        }

        private async Task SimulateTyping(string word, IWebElement element, int waitTimeMs)
        {
            var sb = new StringBuilder();
            foreach (var letter in word)
            {
                await Task.Run(() => Thread.Sleep(waitTimeMs));
                element.SendKeys(letter.ToString());
            }
        }
    }
}
