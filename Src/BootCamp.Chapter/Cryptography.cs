using System.Text;

namespace BootCamp.Chapter
{
    internal class Cryptography
    {
        public string Encode(string message)
        {
            var messageBytes = Encoding.Unicode.GetBytes(message);
            var encodedMessage = new StringBuilder();

            foreach (var unit in messageBytes)
            {
                encodedMessage.Append(unit);
            }

            return encodedMessage.ToString();
        }
    }
}
