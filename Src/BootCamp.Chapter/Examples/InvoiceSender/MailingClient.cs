namespace BootCamp.Chapter.Examples.InvoiceSender
{
    public interface IMailingClient
    {
        void Send(Email email);
    }

    public class MailingClient : IMailingClient
    {
        public void Send(Email email)
        {

        }
    }

    public class Email
    {
        public string To { get; }
        public string From { get; }

        public string Context { get; }

        public Email(string to, string @from, string context)
        {
            To = to;
            From = @from;
            Context = context;
        }
    }
}
