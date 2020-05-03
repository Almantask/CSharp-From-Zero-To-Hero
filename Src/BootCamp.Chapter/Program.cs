using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            TestTransactionTryParse();
        }

        private static void TestTransactionTryParse()
        {
            string testString = "Lidl,New York, Freedom, Bread -Granary Small Pull,2020 - 04 - 25T10: 32:16Z,\"€64,90\"";

            if (Transaction.TryParse(testString, out Transaction transaction))
            {
                Console.WriteLine("Succeded!");
                Console.WriteLine(transaction.ToString());
            }
        }
    }
}