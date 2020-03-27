using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    public class FileAccessor
    {
        const string filePath = "Login.txt";

        public FileAccessor()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        public List<Account> GetAccountsList()
        {
            return AccountsFromFile();
        }

        private List<Account> AccountsFromFile()
        {
            List<Account> accounts = new List<Account>();
            string allLines = File.ReadAllText(filePath);

            if (String.IsNullOrEmpty(allLines))
            {
                return accounts;
            }

            string[] accountsArray = allLines.Split(Environment.NewLine);

            for (int i = 0; i < accountsArray.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(accountsArray[i]))
                {
                    continue;
                }

                string[] splitNameAndPassword = accountsArray[i].Split(',');
                byte[] passwordByteArray = splitNameAndPassword[1].Split(' ').Select(byte.Parse).ToArray();

                Account account = new Account(splitNameAndPassword[0], String.Concat(Encoding.Unicode.GetChars(passwordByteArray)));
                accounts.Add(account);
            }
            return accounts;
        }

        public void AddAccountToFile(Account account)
        {
            string textToBeAdded = $"{account.Name},{string.Concat(account.Password)}{Environment.NewLine}";
            File.AppendAllText(filePath, textToBeAdded);
        }
    }
}
