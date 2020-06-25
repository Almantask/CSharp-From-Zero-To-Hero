using System;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Models.XML
{
    public class TransactionModel
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        ///

            [XmlRoot("Transactions")]
        public partial class Transactions
        {

            private TransactionsTransaction[] transactionField;

            /// <remarks/>
            /// 

            [XmlArray("Transactions"), XmlArrayItem(ElementName = "Transaction", Type = typeof(TransactionsTransaction))]
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

        /// <remarks/>
        /// 

            [XmlRoot("Transaction")]
        public partial class TransactionsTransaction
        {

            private string shopField;

            private string cityField;

            private string streetField;

            private string itemField;

            private System.DateTime dateTimeField;

            private string priceField;

            [XmlElement("Shop")]
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

            [XmlElement("City")]
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

            [XmlElement("Street")]
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

            [XmlElement("Item")]
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

            [XmlElement("DateTime")]
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

            [XmlElement("Price")]
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
