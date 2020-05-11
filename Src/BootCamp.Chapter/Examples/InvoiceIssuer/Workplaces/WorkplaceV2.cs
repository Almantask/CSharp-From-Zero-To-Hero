using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.InvoiceIssuer
{
    public class WorkplaceV2
    {
        private readonly LegacyEmailSender _emailSender = new LegacyEmailSender();

        public void PaySalary(Person person, decimal amount)
        {
            var taxMultiplier = GovernmentV1.GetTaxesMultipler(person);

            var toPay = amount * taxMultiplier;
            person.BankAccount.Balance += toPay;

            SendInvoice(person, toPay);
        }

        private void SendInvoice(Person person, decimal toPay)
        {
            var invoice = new Invoice(person.Name, toPay);
            _emailSender.Send(invoice.ToString(), person.Email);
        }
    }

    public static class GovernmentV1
    {
        public static decimal GetTaxesMultipler(Person person)
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
