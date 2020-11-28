using System.Text;
namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            string[] arr = new string[message.Length];
            StringBuilder sr = new StringBuilder();

            if (message == "" && padding == 0) return "";
          
            sr.AppendLine("+-----+");
            //sr.AppendLine();
            arr = message.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {

                sr.Append("|");
                sr.Append(arr[i]);
                sr.Append("|");
                sr.AppendLine();
                //if (arr.Length == 1) { sr.AppendLine(); }
                if (arr.Length > 1) { sr.AppendLine(); }

            }

            sr.AppendLine("+-----+");
            //sr.AppendLine();

            return sr.ToString();
        }
    }
}
