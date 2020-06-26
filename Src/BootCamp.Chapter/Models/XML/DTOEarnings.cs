using System.Xml.Serialization;

namespace BootCamp.Chapter.Models.XML
{
    public class DTOEarnings
    {
        [XmlRoot("Times")]
        public partial class Earnings
        {
            private EarningsTime[] timesField;

            private int rushHourField;

            [XmlElement("Time")]
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

        public partial class EarningsTime
        {
            private int hourField;

            private int countField;

            private string earnedField;

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