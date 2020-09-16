using System;
using BootCamp.Chapter.Tests.Utils;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson3Tests: ConsoleTests
    {
        private readonly string _promptMessage = $"Testing";

        [Theory]
        [InlineData(100, -100, "Height cannot be equal or less than zero, but was -100.")]
        [InlineData(100, 0, "Height cannot be equal or less than zero, but was 0.")]
        [InlineData(0, 50, "Weight cannot be equal or less than zero, but was 0.")]
        [InlineData(-100, 50, "Weight cannot be equal or less than zero, but was -100.")]
        [InlineData(0, 0, "Weight cannot be equal or less than zero, but was 0." +
                          "Height cannot be equal or less than zero, but was 0.")]
        public void CalculateBmi_With_InvalidInput_Returns_MinusOne_And_PrintsErrorInConsole(float weightKg, float heightM, string fault)
        {
            // Act
            var bmi = Checks.CalculateBmi(weightKg, heightM);

            // Assert
            var problems = fault.ToNewlineSentences();
            var output = ConsoleOutput;
            using (new AssertionScope())
            {
                output.Should().Contain("Failed calculating BMI. Reason:");
                output.Should().ContainAll(problems);
                const float invalid = -1;
                bmi.Should().Be(invalid);
            }
        }

        [Theory]
        [InlineData(100, 2, 25)]
        [InlineData(100, 10, 1)]
        public void CalculateBmi_With_ValidInput_Returns_Expected(float weightKg, float heightM, float expectedBmi)
        {
            // Act
            var bmi = Checks.CalculateBmi(weightKg, heightM);

            // Assert
            bmi.Should().Be(expectedBmi);
        }

        [Theory]
        [InlineData("Tom")]
        [InlineData("X")]
        public void PromptName_PrintsMessage_And_ReturnsName(string input)
        {
            // Arrange
            ConsoleInput = input;

            // Act
            var convertedInput = Checks.PromptString(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().Contain(_promptMessage);
                convertedInput.Should().Be(input);
            }
        }

        [Fact]
        public void PromptName_Empty_Returns_Dash_And_Prints_Error()
        {
            // Arrange
            ConsoleInput = "";
            
            // Act
            var convertedInput = Checks.PromptString(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().ContainAll(_promptMessage, "Name cannot be empty");
                const string invalid = "-";
                convertedInput.Should().Be(invalid);
            }
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("10", 10)]
        [InlineData("", -1)]
        public void PromptInt_PrintsMessage_And_ReturnsInt(string input, int expectedConvertedInput)
        {
            // Arrange
            ConsoleInput = input;

            // Act
            var convertedInput = Checks.PromptInt(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().Contain(_promptMessage);
                convertedInput.Should().Be(expectedConvertedInput);
            }
        }

        [Theory]
        [InlineData("a", "\"a\" is not a valid number.")]
        [InlineData("10b", "\"10b\" is not a valid number.")]
        public void PromptInt_InvalidInput_Returns_MinusOne_And_PrintsErrorMessage(string input, string errorMessage)
        {
            // Arrange
            ConsoleInput = input;

            // Act
            var convertedInput = Checks.PromptInt(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().ContainAll(_promptMessage, errorMessage);
                const int invalid = -1;
                convertedInput.Should().Be(invalid);
            }
        }

        [Theory]
        [InlineData("1.0", 1f)]
        [InlineData("10.0", 10f)]
        [InlineData("", -1)]
        public void PromptFloat_PrintsMessage_And_ReturnsFloat(string input, float expectedConvertedInput)
        {
            // Arrange
            ConsoleInput = input;

            // Act
            var convertedInput = Checks.PromptFloat(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().Contain(_promptMessage);
                convertedInput.Should().Be(expectedConvertedInput);
            }
        }

        [Theory]
        [InlineData("a", "\"a\" is not a valid number.")]
        [InlineData("10b", "\"10b\" is not a valid number.")]
        public void PromptFloat_InvalidInput_Returns_MinusOne_And_PrintsErrorMessage(string input, string errorMessage)
        {
            // Arrange
            ConsoleInput = input;

            // Act
            var convertedInput = Checks.PromptFloat(_promptMessage);

            // Assert
            using (new AssertionScope())
            {
                ConsoleOutput.Should().ContainAll(_promptMessage,errorMessage);
                const float invalid = -1;
                convertedInput.Should().Be(invalid);
            }
        }
    }
}
