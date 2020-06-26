﻿using System;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Models.XML
{
    public class TransactionModel
    {
        [XmlRoot("Transactions")]
        public partial class Transactions
        {

            private TransactionsTransaction[] transactionField;

            [XmlElement("Transaction")]
            public TransactionsTransaction[] Transaction
            {
                get
                {
                    return this.transactionField;
                }
                set
                {
                    this.transactionField = value;
                }
            }
        }

        public partial class TransactionsTransaction
        {

            private string shopField;

            private string cityField;

            private string streetField;

            private string itemField;

            private System.DateTime dateTimeField;

            private string priceField;

            public string Shop
            {
                get
                {
                    return this.shopField;
                }
                set
                {
                    this.shopField = value;
                }
            }

            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            public string Street
            {
                get
                {
                    return this.streetField;
                }
                set
                {
                    this.streetField = value;
                }
            }

            public string Item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }

            public System.DateTime DateTime
            {
                get
                {
                    return this.dateTimeField;
                }
                set
                {
                    this.dateTimeField = value;
                }
            }

            public string Price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }

            public override string ToString()
            {
                return $"{shopField},{cityField},{streetField},{itemField},{dateTimeField},{priceField}";
            }
        }
    }
}
