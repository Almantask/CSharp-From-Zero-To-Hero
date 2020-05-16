using BootCamp.Chapter.Examples.InvoiceSender;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class InvoicerUnitTests
    {
        private readonly Invoicer _invoicer;
        private Mock<MailingClient> _emailerMock;

        public InvoicerUnitTests()
        {
            _emailerMock = new Mock<MailingClient>();

            _invoicer = new Invoicer(_emailerMock.Object, Mock.Of<ILogger>());
        }

        [Fact]
        public void Send_SendsEmail_ToPersonWithInvoiceAmount()
        {
            var amount = It.IsAny<decimal>();
            var to = "Tom";
            var exptectedEmail = new Email(
                to, 
                "Invoicer@invoices.com",
                $"You need to pay: {amount}");

            _invoicer.SendInvoice(amount, to);

            _emailerMock.Verify(e => e.Send(exptectedEmail));
        }
    }
}
