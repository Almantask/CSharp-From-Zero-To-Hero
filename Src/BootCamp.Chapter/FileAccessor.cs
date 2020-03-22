using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileAccessor
    {
        const string filePath = "Login.txt";

        public List<Account> GetAccountsList()
        {
            return AccountsFromFile();
        }
        private List<Account> AccountsFromFile()
        {
            List<Account> accounts = new List<Account>();
            string[] accountsArray = File.ReadAllText(filePath).Split(',');
            for (int i = 0; i < accountsArray.Length; i += 2)
            {
                Account account = new Account(accountsArray[i], accountsArray[i + 1]);
                accounts.Add(account);
            }

            return accounts;
        }

        public void AddAccountToFile(Account account)
        {
            string textToBeAdded = $"{account.Name},{account.Password.ToString()}{Environment.NewLine}";
            File.AppendAllText(filePath, textToBeAdded);
        }
    }
}
