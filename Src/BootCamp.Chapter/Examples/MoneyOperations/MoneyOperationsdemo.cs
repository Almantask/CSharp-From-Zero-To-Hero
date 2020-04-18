using System;
using System.Globalization;

namespace BootCamp.Chapter.Examples.MoneyOperations
{
    public enum Currency
    {
        EUR,
        LTU,
        GBP,
        DOL,
        Undefined
    }

    public readonly struct Money
    {
        public readonly decimal Amount;
        public readonly Currency Currency;

        public Money(decimal amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money money1, Money money2)
        {
            if (money1.Currency != money2.Currency)
            {
                throw new MissmatchingCurrencyException(money1.Currency, money2.Currency);
            }

            return new Money(money1.Amount + money2.Amount, money1.Currency);
        }

        public static Money operator -(Money money) => money.ToNegative();

        // You don't have to implement minus operator.
        public static Money operator -(Money money1, Money money2) => money1 + -money2;

        // Auto cast: decimal amount = money;
        public static implicit operator decimal(Money money) => money.Amount;

        // Explicit cast: Money money = (Money)15.0m;
        public static explicit operator Money(decimal amount) => new Money(amount, Currency.Undefined);

        public Money ToNegative() => new Money(Amount * -1, Currency);

        public override string ToString()
        {
            var culture = Currency switch
            {
                Currency.GBP => "en-GB",
                Currency.LTU => "lt-LT",
                Currency.EUR => "de-DE",
                Currency.DOL => "en-US",
                Currency.Undefined => ""
            };
            
            return Amount.ToString("C2", CultureInfo.CreateSpecificCulture(culture));
        } 
    }

    public class MissmatchingCurrencyException : Exception
    {
        public MissmatchingCurrencyException(Currency money1Currency, Currency money2Currency) : base($"Cannot add {money1Currency} to {money2Currency}. Currencies need to match.")
        {
        }
    }

    public static class DemoAddOrSubstractMoney
    {
        public static void Run()
        {
            var euro10 = new Money(10, Currency.EUR);
            var euro15 = new Money(15, Currency.EUR);

            // 10 EUR + 15 EUR = 25 EUR
            Console.WriteLine($"{euro10} + {euro15} = {euro10 + euro15}");
            // 10 EUR - 15 EUR = -5 EUR
            Console.WriteLine($"{euro10} - {euro15} = {euro10 - euro15}");

            // Cannot add DOL to EUR. Currencies need to match.
            try
            {
                var dollars1 = new Money(1, Currency.DOL);
                var sum = dollars1 + euro15;
            }
            catch(MissmatchingCurrencyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            decimal amount = euro15;
            // 15 EUR as decimal = 15
            Console.WriteLine($"{euro15} as decimal = {amount}");

            Money dollar = new Money(15, Currency.DOL);
            Console.WriteLine(dollar.ToString());

            Money euroLt = new Money(15, Currency.LTU);
            Console.WriteLine(euroLt.ToString());

            Money undefined20 = (Money) 20.02m;
            // 20.02, because implicit cast takes precedence
            // In order for ToString to be called, Money needs to be explicitly cast to object (object)undefined20;
            Console.WriteLine(undefined20);
        }
    }
}
