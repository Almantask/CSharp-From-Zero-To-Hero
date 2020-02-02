using BootCamp.Chapter.Tests.Input;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson7Tests
    {
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
