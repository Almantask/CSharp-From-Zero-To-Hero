using System;
using System.Collections.Generic;
using System.Text;

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
        //TODO see if one of the accounts has the same name
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
            Console.Clear();
            foreach (Account account in _accounts)
            {
                Console.WriteLine($"{account.Name} + { String.Concat( Encoding.Unicode.GetChars(account.Password))}");
            }
            Console.ReadKey();
        }

        public bool Login(string name, string password)
        {
            if (AccountNameExists(name))
            {
                foreach (Account account in _accounts)
                {
                    if (account.Name == name)
                    {
                        if (account.Password == Encoding.Unicode.GetBytes(password))
                        {
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

        // if create:
        //TODO if none exist create + add to list
        //TODO return success or not.


    }
}
