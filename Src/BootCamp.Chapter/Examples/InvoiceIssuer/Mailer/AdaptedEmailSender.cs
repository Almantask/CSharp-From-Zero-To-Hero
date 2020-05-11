namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public class AdaptedEmailSender : IEmailSender
    {
        private readonly LegacyEmailSender _emailSender;

        public AdaptedEmailSender(LegacyEmailSender emailSender) => _emailSender = emailSender;

        public void Send(string text, string recipient) => _emailSender.Send(text, recipient);
    }
}