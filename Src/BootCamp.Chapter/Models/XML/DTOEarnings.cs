namespace BootCamp.Chapter.Models.XML
{
    public class DTOEarnings
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Earnings
        {

            private EarningsTime[] timesField;

            private int rushHourField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Time", IsNullable = false)]
            public EarningsTime[] Times
            {
                get
                {
                    return this.timesField;
                }
                set
                {
                    this.timesField = value;
                }
            }

            /// <remarks/>
            public int RushHour
            {
                get
                {
                    return this.rushHourField;
                }
                set
                {
                    this.rushHourField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class EarningsTime
        {

            private int hourField;

            private int countField;

            private string earnedField;

            /// <remarks/>
            public int Hour
            {
                get
                {
                    return this.hourField;
                }
                set
                {
                    this.hourField = value;
                }
            }

            /// <remarks/>
            public int Count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }

            /// <remarks/>
            public string Earned
            {
                get
                {
                    return this.earnedField;
                }
                set
                {
                    this.earnedField = value;
                }
            }
        }


    }
}
