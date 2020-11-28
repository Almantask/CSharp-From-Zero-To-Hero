using System;
using System.Text;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            string message = "Hello";
            int padding = 3;

            Console.WriteLine(Build(message, padding)); 
            
        }
        // Use ArrayOperation Class from homework 5
        public static string Build(string message, int padding)
        {
            string[] arr = new string[message.Length];
            StringBuilder sr = new StringBuilder();

            sr.AppendLine("+-----+");
            sr.AppendLine();
            arr = message.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
               
                sr.Append("|");
                sr.Append(arr[i]);
                sr.Append("|");
                sr.AppendLine();
                if (arr.Length == 1) { sr.AppendLine(); }
                if (arr.Length > 1) { sr.AppendLine(); }

            }
           
            sr.AppendLine("+-----+");
            

            return sr.ToString();
        }
    }
}

