using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class ContactCenterTests
    {
        [Fact]
        public void New_With_File_Not_Found_Throws_FileNotFoundException()
        {
            const string path = "This/is/made/up";

            Action action = () => new ContactsCenter(path);

            action.Should().Throw<FileNotFoundException>("file is made up");
        }

        [Fact]
        public void New_With_Empty_File_Throws()
        {
            const string path = "Input/Empty.txt";

            Action action = () => new ContactsCenter(path);

            // Leaving this up to a student to figure out.
            action.Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [ClassData(typeof(PersonPredicatesAndExpectations))]
        public void New_With_File_With_A_B_And_C_Cases_Given_Predicate_Returns_ExpectedPeopleCount(Predicate<Person> predicate, int expectedCount)
        {
            const string path = "Input/abc.txt";
            var contactsCenter = new ContactsCenter(path);

            var people = contactsCenter.Filter(predicate);

            people.Should().HaveCount(expectedCount);
        }
    }
}
