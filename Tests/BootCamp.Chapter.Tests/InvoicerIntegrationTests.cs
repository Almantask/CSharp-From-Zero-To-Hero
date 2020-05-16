using BootCamp.Chapter.Examples.InvoiceSender;
using Moq;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class InvoicerIntegrationTests
    {
        private readonly Invoicer _invoicer;

        public InvoicerIntegrationTests()
        {
            var logger = new Logger("dummyPlace");
            var emailer = new MailingClient();

            _invoicer = new Invoicer(emailer, logger);
        }

        [Fact]
        public void Send_SendsEmailsToRecipient_WithTheRightAmount()
        {
            var amount = It.IsAny<decimal>();
            var to = "Tom";

            _invoicer.SendInvoice(amount, to);

            // How to check if it was sent?
            // Read the logs?
        }
    }
}
