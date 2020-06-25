using System.Globalization;

namespace BootCamp.Chapter.Models.XML
{
    public class Transaction
    {
        public string Shop { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Item { get; set; }
        public string DateTime { get; set; }
        public string Price { get; set; }

        public static Transaction TransactionCreator(BootCamp.Chapter.Transaction transaction)
        {
            Transaction tr = new Transaction();
            tr.Shop = transaction.ShopName;
            tr.City = transaction.City;
            tr.Street = transaction.Street;
            tr.Item = transaction.Item;
            tr.DateTime = transaction.DateTime.ToString();
            tr.Price = transaction.Price.ToString("C2", CultureInfo.GetCultureInfo("lt-LT"));
            return tr;
        }

        public override string ToString()
        {
            return $"{Shop},{City},{Street},{Item},{DateTime},{Price}";
        }
    }
}
