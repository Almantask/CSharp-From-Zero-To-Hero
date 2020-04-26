using System;
using System.IO;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class ProgramTests : IDisposable
    {
        private const string ValidTransactionsFile = "Input/Transactions.csv";
        private readonly string OutputFile = Guid.NewGuid().ToString();

        [Theory]
        [InlineData("Input/Empty.csv")]
        [InlineData("nonExisting.csv")]
        public void Main_When_Transactions_File_Empty_Or_Not_Found_Throws_NoTransactionsException(string input)
        {
            const string cmd = "time";

            Action action = () => Program.Main(new[] { input, cmd, OutputFile });

            action.Should().Throw<NoTransactionsFoundException>();
        }

        [Fact]
        public void Main_When_Too_Few_Arguments_Throws_InvalidCommandException()
        {
            Action action = () => Program.Main(new[] { ValidTransactionsFile });

            action.Should().Throw<InvalidCommandException>();
        }

        [Fact]
        public void Main_When_Command_Invalid_Throws_InvalidCommandException()
        {
            const string cmd = "blablabla";

            Action action = () => Program.Main(new[] { ValidTransactionsFile, cmd, OutputFile });

            action.Should().Throw<InvalidCommandException>();
        }

        [Fact]
        public void Main_When_Valid_Time_Command_Creates_File_And_Writes_Stats_For_Every_Hour()
        {
            const string cmd = "time";

            Program.Main(new[] { ValidTransactionsFile, cmd, OutputFile });

            const string expectedOutput = "Expected/FullDay.csv";
            AssertMatchingContents(expectedOutput, OutputFile);
        }

        [Fact]
        public void Main_When_Valid_Time_Command_With_Range_Creates_File_And_Writes_Stats_For_Every_Hour_Belonging_To_Range()
        {
            const string cmd = "time 20:00-00:00";

            Program.Main(new[] { ValidTransactionsFile, cmd, OutputFile });

            const string expectedOutput = "Expected/Night.csv";
            AssertMatchingContents(expectedOutput, OutputFile);
        }

        [Fact]
        public void Main_When_Valid_DailyRevenue_Command_Creates_File_And_Writes_Revenue_For_Each_Day_Of_Week()
        {
            const string cmd = @"Daily ""Kwiki Mart""";

            Program.Main(new[] { ValidTransactionsFile, cmd, OutputFile });

            const string expectedOutput = "Expected/DailyKwiki.csv";
            AssertMatchingContents(expectedOutput, OutputFile);
        }

        [Theory]
        [InlineData("city -money -max", "Expected/CityMoneyMax.csv")]
        [InlineData("city -money -min", "Expected/CityItemsMin.csv")]
        [InlineData("city -items -max", "Expected/CityMoneyMin.csv")]
        [InlineData("city -items -min", "Expected/CityItemsMax.csv")]
        public void Main_When_Valid_MinMax_Command_With_Returns_Expected_Cities_With_Min_Max(string cmd, string expectedOutput)
        {
            Program.Main(new[] { ValidTransactionsFile, cmd, OutputFile });

            AssertMatchingContents(expectedOutput, OutputFile);
        }

        [Fact]
        public void Main_When_Valid_Full_Command_Creates_Files_Based_On_Shop_With_All_Transactions()
        {
            const string cmd = "full";

            Program.Main(new[] { ValidTransactionsFile, cmd });

            using (new AssertionScope())
            {
                AssertMatchingContents("Expected/Aibe.csv", "Aibe.csv");
                AssertMatchingContents("Expected/Kwiki Mart.csv", "Kwiki Mart.csv");
                AssertMatchingContents("Expected/Wallmart.csv", "Wallmart.csv");
            }
        }

        private void AssertMatchingContents(string expected, string actual)
        {
            File.ReadAllText(actual).Should()
                .Be(File.ReadAllText(expected));
        }

        public void Dispose()
        {
            if (File.Exists(OutputFile))
            {
                File.Delete(OutputFile);
            }
        }
    }
}