using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Domain
{
    public class Order
    {
        public OrderHeader Header { get; }
        public IEnumerable<OrderLine> Lines { get; }

        public Order(OrderHeader header, IEnumerable<OrderLine> lines)
        {
            Header = header;
            Lines = lines;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Header.Name} - {Header.Description}");
            foreach (var line in Lines)
            {
                sb.AppendLine($"{line.Item.Name}- amount: {line.Amount}, price: {line.Price}");
            }

            return sb.ToString();
        }
    }
}
