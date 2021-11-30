using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Transactions
    {
        //Shop,City,Street,Item,DateTime,Price
        private string shop;
        public string Shop
        {
            get { return this.shop; }
        }

        private string city;
        public string City
        {
            get { return this.city; }
        }

        private string street;
        public string Street
        {
            get { return this.street; }
        }

        private string item;
        public string Item
        {
            get { return this.item; }
        }

        private DateTime time;
        public DateTime Time
        {
            get { return this.time;}
        }

        private decimal price;
        public decimal Price
        {
            get { return this.price; }
        }

        //private List<Transactions> transactionList = new List<Transactions>();
        //public List<Transactions> TransactionList
        //{
        //    get { return this.transactionList; }
        //    //set { this.transactionList = value; }
        //}

        public Transactions(string shop, string city, string street, string item, string dateTime,  string price)
        {
            this.shop = shop;
            this.city = city;
            this.street = street;
            this.item = item;

            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(dateTime, culture);
            this.time = tempDate;

            bool ok = decimal.TryParse(price, out decimal result);
            this.price = ok ? result : -1;

            //AddTransaction(this);
        }

        //public void AddTransaction(Transactions items)
        //{
        //    TransactionList.Add(items);
        //}

        public override string ToString()
        {
            return string.Format($"Name: {shop}\n City: {city}\n Street: {street}\n Item: {item}\n Time: {time}\n Price: {price}\n\n");
        }
    }
}
