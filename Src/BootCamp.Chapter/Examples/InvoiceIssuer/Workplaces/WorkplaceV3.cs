namespace BootCamp.Chapter.Examples.InvoiceIssuer.Workplaces
{
    public class WorkplaceV3
    {
        private readonly IEmailSender _emailSender;
        private readonly ITaxesPicker _taxesPicker;

        public WorkplaceV3(IEmailSender emailSender, ITaxesPicker taxesPicker)
        {
            _emailSender = emailSender;
            _taxesPicker = taxesPicker;
        }

        public void PaySalary(Person person)
        {
            var taxMultiplier = _taxesPicker.GetTaxesMultipler(person);

            var toPay = person.Salary * taxMultiplier;
            person.BankAccount.Balance += toPay;

            SendInvoice(person, toPay);
        }

        private void SendInvoice(Person person, decimal toPay)
        {
            var invoice = new Invoice(person.Name, toPay);
            _emailSender.Send(invoice.ToString(), person.Email);
        }
    }

    public interface ITaxesPicker
    {
        decimal GetTaxesMultipler(Person person);
    }

    // Our code, so we could add an interface
    public class GovernmentV2 : ITaxesPicker
    {
        public decimal GetTaxesMultipler(Person person)
        {
            var taxMultiplier = 1m;
            const int chargeableAgeTreshold = 18;
            if (person.Age < chargeableAgeTreshold)
            {
                taxMultiplier *= 1;
            }
            else
            {
                taxMultiplier *= 1.1m;
            }

            const decimal minimumSalary = 500;
            if (person.Salary > minimumSalary)
            {
                taxMultiplier *= 1.1m;
            }

            return taxMultiplier;
        }
    }
}
