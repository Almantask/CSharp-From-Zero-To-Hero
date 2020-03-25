using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileAccessor
    {
        const string filePath = "Login.txt";

        public FileAccessor()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
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
            for (int i = 0; i < accountsArray.Length; i += 2)
            {
                //TODO out of bounds!!!
                Account account = new Account(accountsArray[i].Split(',')[0], accountsArray[i].Split(',')[1]);
                accounts.Add(account);
            }

            return accounts;
        }

        public void AddAccountToFile(Account account)
        {
            //TODO needs to save it encoded!!!
            string textToBeAdded = $"{account.Name},{string.Concat(account.Password)}{Environment.NewLine}";
            File.AppendAllText(filePath, textToBeAdded);
        }
    }
}
