using System;
using System.Xml.Serialization;

namespace BootCamp.Chapter.Models.XML
{
    public class TransactionModel
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Shops
        {

            private ShopsShop[] shopField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Shop")]
            public ShopsShop[] Shop
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
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ShopsShop
        {

            private string shopField;

            private string cityField;

            private string streetField;

            private string itemField;

            private System.DateTime dateTimeField;

            private string priceField;

            /// <remarks/>
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

            /// <remarks/>
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

            /// <remarks/>
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

            /// <remarks/>
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

            /// <remarks/>
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

            /// <remarks/>
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
