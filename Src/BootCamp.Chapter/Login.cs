using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class LoginAndRedister
    {
        private List<Account> _accounts;
        private readonly FileAccessor _accessor = new FileAccessor();

        public LoginAndRedister()
        {
            _accounts = _accessor.GetAccountsList();
        }
        public bool AccountNameExists(string name)
        {
            foreach (Account account in _accounts)
            {
                if (account.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowAllAccounts()
        {
            foreach (Account account in _accounts)
            {
                Console.WriteLine($"{account.Name} + { account.Password }"); //String.Concat( Encoding.Unicode.GetChars(account.Password))
            }
            Console.ReadKey();
        }
        public bool Login(string name, string password, out Account loggedInAccount)
        {
            loggedInAccount = null;
            Account temp = new Account(name, password);

            if (AccountNameExists(temp.Name))
            {
                foreach (Account account in _accounts)
                {
                    if (account.Name == temp.Name)
                    {
                        if (account.Password == temp.Password)
                        {
                            loggedInAccount = account;
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }
        public void Create(string name, string password)
        {
            Account account = new Account(name, password);
            _accounts.Add(account);
            _accessor.AddAccountToFile(account);
        }
    }
}
