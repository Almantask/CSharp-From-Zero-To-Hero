namespace BootCamp.Chapter.Examples.InvoiceSender
{
    public class Invoicer
    {
        private readonly IMailingClient _mailerClient;
        private readonly ILogger _logger;

        public Invoicer(IMailingClient mailerClient, ILogger logger)
        {
            _mailerClient = mailerClient;
            _logger = logger;
        }

        public void SendInvoice(decimal amount, string to)
        {
            _logger.Log("Preping invoice to: " + to);

            var email = new Email(
                to, 
                "Invoicer@invoices.com",
                $"You need to pay: {amount}");

            _mailerClient.Send(email);

            _logger.Log("Sent invoice to: " + to);
        }
    }
}
