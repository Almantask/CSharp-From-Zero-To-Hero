using System.Data.SqlTypes;
using System.Globalization;
using BootCamp.Chapter.Examples.InvoiceIssuer;
using BootCamp.Chapter.Examples.InvoiceIssuer.Workplaces;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class WorkplaceTests
    {
        private const decimal DummyTaxes = 0.9m;

        private readonly Mock<IEmailSender> _emailSenderMock;
        private readonly Mock<ITaxesPicker> _taxesPickerMock;
        public WorkplaceTests()
        {
            _emailSenderMock = new Mock<IEmailSender>();
            
            _taxesPickerMock = new Mock<ITaxesPicker>();
            _taxesPickerMock.Setup(t =>
                    t.GetTaxesMultipler(It.IsAny<Person>()))
                .Returns(DummyTaxes);
        }

        [Fact]
        public void Pay_AddsPay_AfterTaxes_ToBalance_And_NotifiesThem()
        {
            // Arrange
            var workplace = BuildWorkplace();
            var person = BuildPerson();

            // Act
            workplace.PaySalary(person);

            // Assert
            var salaryAfterTaxes = person.Salary * DummyTaxes;
            Assert.Equal(salaryAfterTaxes, person.BankAccount.Balance);
            _emailSenderMock.Verify(e => e.Send(It.IsAny<string>(), person.Email));
        }

        [Fact]
        public void Pay_AddsPay_AfterTaxes_ToBalance_And_NotifiesThem2()
        {
            // Arrange
            var workplace = new WorkplaceV3(_emailSenderMock.Object, _taxesPickerMock.Object);
            var person = new Person("Tom", 18, 600, "dummy@man.com", new BankAccount("dummy", 0));

            // Act
            workplace.PaySalary(person);

            // Assert
            var salaryAfterTaxes = person.Salary * DummyTaxes;
            Assert.Equal(salaryAfterTaxes, person.BankAccount.Balance);
            _emailSenderMock.Verify(e => e.Send(It.IsAny<string>(), person.Email));
        }

        private WorkplaceV3 BuildWorkplace() => new WorkplaceV3(_emailSenderMock.Object, _taxesPickerMock.Object);

        private Person BuildPerson()
            => new Person("Tom", 18, 600, "dummy@man.com", new BankAccount("dummy", 0) );

    }
}
