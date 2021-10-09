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
        /*
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
        */

        [Theory]
        [InlineData("1.0", 1f)]
        [InlineData("10.0", 10f)]
        public void PromptFloat_PrintsMessage_And_ReturnsFloat(string input, float expectedConvertedInput)
        {

            var consoleOutput = ConsoleStub.StubConsole(input);
            // This is being tested
            var convertedInput = Checks.PromptFloat(input);
                     
            // Verify that input was parsed correctly
            convertedInput.Should().Be(expectedConvertedInput);
        }

    }
}
