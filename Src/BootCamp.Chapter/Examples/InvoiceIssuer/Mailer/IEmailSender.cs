namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public interface IEmailSender
    {
        void Send(string text, string recipient);
    }
}