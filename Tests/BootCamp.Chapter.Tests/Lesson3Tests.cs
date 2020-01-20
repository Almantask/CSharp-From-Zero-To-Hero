using System;
using System.IO;
using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // Is your code working?
    public class Lesson3Tests
    {
        // Dummy prompt message with which input will be asked. (your specific message won't be tested)
        private const string PromptMessage = "Testing";

        [Theory]
        [InlineData(100, -100, "Height cannot be less than zero, but was -100.")]
        [InlineData(100, 0, "Height cannot be less than zero, but was 0.")]
        [InlineData(50, 50, "Weight cannot be more or equal to height. Height= 50, Weight= 50.")]
        [InlineData(0, 50, "Weight cannot be less than zero, but was 0.")]
        [InlineData(-100, 50, "Weight cannot be less than zero, but was -100.")]
        [InlineData(0, 0, "Weight cannot be less than zero, but was 0.Height cannot be less than zero, but was 0.")]
        public void CalculateBmi_With_InvalidInput_Returns_MinusOne_And_PrintsErrorInConsole(float weightKg, float heightM, string fault)
        {
            var testKey = Guid.NewGuid().ToString();
            var consoleOutput = ConsoleStub.StubConsole("", testKey);
            var bmi = Checks.CalculateBmi(weightKg, heightM);

            consoleOutput.Dispose();
            var errorMessage = ConsoleStub.ReadAllText(testKey);
            ConsoleStub.Cleanup(testKey);

            fault = fault.Replace(".", $".{Environment.NewLine}");
            errorMessage.Should().Be($"Failed calculating BMI. Reason:{Environment.NewLine}{fault}");

            const float invalid = -1;
            bmi.Should().Be(invalid);
        }

        [Theory]
        [InlineData(100, 2, 25)]
        [InlineData(100, 10, 1)]
        public void CalculateBmi_With_ValidInput_Returns_Expected(float weightKg, float heightM, float expectedBmi)
        {
            // This is being tested
            var bmi = Checks.CalculateBmi(weightKg, heightM);

            // This is being expected
            bmi.Should().Be(expectedBmi);
        }

        [Theory]
        [InlineData("Tom")]
        [InlineData("X")]
        public void PromptName_PrintsMessage_And_ReturnsName(string input)
        {
            // Setup
            var consoleOutput = ConsoleStub.StubConsole(input);

            // This is being tested
            var convertedInput = Checks.PromptString(PromptMessage);

            // Verify that prompted message is as expected
            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            // Verify that input was parsed correctly
            convertedInput.Should().Be(input);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("10", 10)]
        public void PromptInt_PrintsMessage_And_ReturnsInt(string input, int expectedConvertedInput)
        {
            // Setup
            var consoleOutput = ConsoleStub.StubConsole(input);

            // This is being tested
            var convertedInput = Checks.PromptInt(PromptMessage);

            // Verify that prompted message is as expected
            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            // Verify that input was parsed correctly
            convertedInput.Should().Be(expectedConvertedInput);
        }

        [Theory]
        [InlineData("a", "\"a\" is not a valid number.")]
        [InlineData("10b", "\"10b\" is not a valid number.")]
        public void PromptInt_InvalidInput_Returns_MinusOne_And_PrintsErrorMessage(string input, string errorMessage)
        {

            var consoleOutput = ConsoleStub.StubConsole(input);

            var convertedInput = Checks.PromptInt(PromptMessage);

            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage + errorMessage);

            const int invalid = -1;
            convertedInput.Should().Be(invalid);
        }

        [Theory]
        [InlineData("1.0", 1f)]
        [InlineData("10.0", 10f)]
        public void PromptFloat_PrintsMessage_And_ReturnsFloat(string input, float expectedConvertedInput)
        {
            // Setup
            var consoleOutput = ConsoleStub.StubConsole(input);

            // This is being tested
            var convertedInput = Checks.PromptFloat(PromptMessage);

            // Verify that prompted message is as expected
            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            // Verify that input was parsed correctly
            convertedInput.Should().Be(expectedConvertedInput);
        }

        [Theory]
        [InlineData("a", "\"a\" is not a valid number.")]
        [InlineData("10b", "\"10b\" is not a valid number.")]
        public void PromptFloat_InvalidInput_Returns_MinusOne_And_PrintsErrorMessage(string input, string errorMessage)
        {
            var consoleOutput = ConsoleStub.StubConsole(input);

            var convertedInput = Checks.PromptFloat(PromptMessage);

            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage + errorMessage);

            const float invalid = -1;
            convertedInput.Should().Be(invalid);
        }
    }
}
