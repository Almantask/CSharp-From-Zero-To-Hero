using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class TransactionDataParser
    {
        public readonly List<Transaction> Transactions;


        public TransactionDataParser(string inputPath)
        {
            Transactions = new List<Transaction>();
            GetTransactions(inputPath);
        }

        private void GetTransactions(string inputPath)
        {
            using var reader = new StreamReader(File.OpenRead(inputPath));

            int count = 0;
            while (!reader.EndOfStream)
            {
                if (count == 0)
                {
                    reader.ReadLine();
                    count++;
                }
                else
                {
                    string parsedData = reader?.ReadLine();
                    TryParse(parsedData, out string itemName, out DateTime timePurchased, 
                        out decimal price, out string shopName, out string location, out string streetName);

                    Transactions.Add(new Transaction(itemName, timePurchased, price, shopName, location, streetName));
                }
            }
        }

        private string CharListToString(List<char> input)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char letter in input)
            {
                stringBuilder.Append(letter);
            }

            return stringBuilder.ToString();
        }

        private List<string> ObtainData(string inputString)
        {
            bool quotationMarkHit = false;
            List<char> currArg = new List<char>();
            List<string> args = new List<string>();
            int lenOfCommand = inputString.Length;

            for (int i = 0; i < lenOfCommand; i++)
            {
                // first char
                if (inputString[i] != ',' && currArg.Count == 0 && inputString[i] != ' ')
                {
                    if (inputString[i] == '"')
                    {
                        quotationMarkHit = true;
                        continue;
                    }
                    currArg.Add(inputString[i]);
                }
                else if (inputString[i] == '"' && quotationMarkHit == true)
                {
                    quotationMarkHit = false;
                    args.Add(CharListToString(currArg));
                    currArg.Clear();
                }
                else if (inputString[i] == ',' && quotationMarkHit == true)
                {
                    currArg.Add(inputString[i]);
                }
                // Next char
                else if (inputString[i] != ',' && currArg.Count != 0)
                {
                    currArg.Add(inputString[i]);
                }
                // End of a Arg
                else if (inputString[i] == ',' && currArg.Count != 0 && quotationMarkHit == false)
                {
                    args.Add(CharListToString(currArg));
                    currArg.Clear();
                }
                // Skips if blank space between args
                else if (inputString[i] == ' ' && inputString[i - 1] != ',' && inputString[i + 1] != ',')
                {
                    continue;
                }
            }
            return args;
        }

        private bool TryParse(string rawTransaction, out string itemName, out DateTime timePurchased,
                                           out decimal price, out string shopName, out string location, out string streetName)
        {
            List<string> receivedData = ObtainData(rawTransaction);
            shopName = receivedData[0] ?? throw new ArgumentNullException("Parsed Data cannot be Null or Empty");
            location = receivedData[1] ?? throw new ArgumentNullException("Parsed Data cannot be Null or Empty");
            streetName = receivedData[2] ?? throw new ArgumentNullException("Parsed Data cannot be Null or Empty");
            itemName = receivedData[3] ?? throw new ArgumentNullException("Parsed Data cannot be Null or Empty");
            timePurchased = receivedData[4] != null ? DateTime.Parse(receivedData[4]) : throw new ArgumentNullException("Parsed Data cannot be Null or Empty");
            price = receivedData[5] != null ? decimal.Parse(receivedData[5], NumberStyles.Number | NumberStyles.AllowCurrencySymbol, new CultureInfo("es-ES")) : throw new ArgumentNullException("Parsed Data cannot be Null or Empty");

            // return true assuming that if a value is illegitimate (i.e Null or Empty) then an exception will be raised and the bool will not be returned.
            return true;
        }
    }
}
