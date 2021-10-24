using System;
using System.IO;
using BootCamp.Chapter.Tests.Input;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson7Tests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("", "a")]
        [InlineData("a", "")]
        [InlineData(null, "a")]
        [InlineData("a", null)]
        [InlineData(null, null)]
        public void FileCleaner_Clean_Given_Invalid_Parameters_Throws_ArgumentException(string dirtyFile, string cleanFile)
        {
            Action action = () => FileCleaner.Clean(dirtyFile, cleanFile);

            action.Should().Throw<ArgumentException>();
        }


        [Theory]
        [InlineData(@"Input/Files/In/BalancesCharBalance.Invalid")]
        [InlineData(@"Input/Files/In/BalancesNotAName1.Invalid")]
        [InlineData(@"Input/Files/In/BalancesNotAName2y.Invalid")]
        public void FileCleaner_Clean_Given_Invalid_Balances_Throws_InvalidBalances_Exception(string file)
        {
            Action action = () => FileCleaner.Clean(file, "AnyFile");

            action.Should().Throw<InvalidBalancesException>();
        }

        [Theory]
        [InlineData(@"Input/Files/In/Balances.corrupted", @"Input/Files/Expected/Balances.clean")]
        [InlineData(@"Input/Files/In/Balances1.corrupted", @"Input/Files/Expected/Balances1.clean")]
        [InlineData(@"Input/Files/In/Balances2.corrupted", @"Input/Files/Expected/Balances2.clean")]
        public void FileCleaner_Clean_Given_Corrupted_File_Creates_Clean_File(string dirtyFile, string expectedCleanFile)
        {
            string cleanFile = $@"Balances{Guid.NewGuid()}.clean";
            FileCleaner.Clean(dirtyFile, cleanFile);

            var expectedCleanContents = File.ReadAllText(expectedCleanFile);
            var actualCleanContents = File.ReadAllText(cleanFile);
            actualCleanContents.Should().Be(expectedCleanContents);

            File.Delete(cleanFile);
        }

        [Theory]
        [InlineData(@"Input/Files/In/Balances.clean")]
        [InlineData(@"Input/Files/In/Balances.empty")]
        public void FileCleaner_Clean_Given_Empty_Or_Clean_File_Duplicates_File(string file)
        {
            string outputFile = $@"Balances{Guid.NewGuid()}.clean";
            FileCleaner.Clean(file, outputFile);

            var dirtyContents = File.ReadAllText(file);
            var cleanContents = File.ReadAllText(outputFile);
            cleanContents.Should().Be(dirtyContents, "The file has no corruption- there is nothing to clean up.");
            
            File.Delete(outputFile);
        }

        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void BuildTabledMessage_With_Message_Hello_AndPadding_0_Returns_Message_In_Table(string message, int padding, string expectation)
        {
            var result = TextTable.Build(message, padding);

            result.Should().Be(expectation);
        }

        [Theory]
        [ClassData(typeof(HighestHistoricBalanceExpectations))]
        public void FindHighestBalanceEver_With_ArrayOf_People_And_Balances_Returns_HighestHistoricBalance_Or_Balances(string[] peopleAndBalances, string expectedHighestBalance)
        {
            var highestHistoricBalance = BalanceStats.FindHighestBalanceEver(peopleAndBalances);

            highestHistoricBalance.Should().Be(expectedHighestBalance);
        }

        [Theory]
        [ClassData(typeof(PersonWithBiggestLossExpectations))]
        public void FindPersonWithBiggestLoss_With_ArrayOf_People_And_Balances_Returns_Person_Or_People_With_BiggestLoss(string[] peopleAndBalances, string expectedBiggestLoss)
        {
            var personWithBiggestLoss = BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances);

            personWithBiggestLoss.Should().Be(expectedBiggestLoss);
        }

        [Theory]
        [ClassData(typeof(RichestPersonExpectations))]
        public void FindRichestPerson_With_ArrayOf_People_And_Balances_Returns_Richest_Person_Or_People_And_Their_Balance(string[] peopleAndBalances, string expectedRichestPerson)
        {
            var richestPerson = BalanceStats.FindRichestPerson(peopleAndBalances);

            richestPerson.Should().Be(expectedRichestPerson);
        }

        [Theory]
        [ClassData(typeof(MostPoorPersonExpectations))]
        public void FindMostPoorPerson_With_ArrayOf_People_And_Balances_Returns_MostPoor_Person_Or_People_And_Their_Blaance(string[] peopleAndBalances, string expectedMostPoorPerson)
        {
            var mostPoorPerson = BalanceStats.FindMostPoorPerson(peopleAndBalances);

            mostPoorPerson.Should().Be(expectedMostPoorPerson);
        }
    }
}
