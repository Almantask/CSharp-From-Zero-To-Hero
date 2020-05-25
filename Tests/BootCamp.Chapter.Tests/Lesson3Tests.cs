using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson3Tests
    {
        private const string PromptMessage = "Testing";

        [Theory]
        [InlineData(100, 2, 25)]
        [InlineData(100, 10, 1)]
        public void CalculateBmi_With_ValidInput_Returns_Expected(float weightKg, float heightM, float expectedBmi)
        {
            var bmi = Checks.CalculateBmi(weightKg, heightM);

            bmi.Should().Be(expectedBmi);
        }

        [Theory]
        [InlineData("Tom")]
        [InlineData("X")]
        public void PromptName_PrintsMessage_And_ReturnsName(string input)
        {
            var consoleOutput = ConsoleStub.StubConsole(input);

            var convertedInput = Checks.PromptString(PromptMessage);

            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            convertedInput.Should().Be(input);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("10", 10)]
        public void PromptInt_PrintsMessage_And_ReturnsInt(string input, int expectedConvertedInput)
        {
            var consoleOutput = ConsoleStub.StubConsole(input);

            var convertedInput = Checks.PromptInt(PromptMessage);

            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            convertedInput.Should().Be(expectedConvertedInput);
        }

        [Theory]
        [InlineData("1.0", 1f)]
        [InlineData("10.0", 10f)]
        public void PromptFloat_PrintsMessage_And_ReturnsFloat(string input, float expectedConvertedInput)
        {
            var consoleOutput = ConsoleStub.StubConsole(input);

            var convertedInput = Checks.PromptFloat(PromptMessage);

            var promptedMessage = consoleOutput.ToString().Trim();
            promptedMessage.Should().Be(PromptMessage);
            convertedInput.Should().Be(expectedConvertedInput);
        }
    }
}