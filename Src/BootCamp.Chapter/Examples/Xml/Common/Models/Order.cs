using System.Text;

namespace BootCamp.Chapter.Examples.Xml.Common.Models
{
    public class Order
    {
        public OrderHeader Header { get; set; }
        public OrderLine[] Lines { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Header.Name} - {Header.Description}");
            foreach (var line in Lines)
            {
                sb.AppendLine($"{line.Item.Nam}- amount: {line.Amount}, price: {line.Price}");
            }

            return sb.ToString();
        }
    }
}
