using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class LoginAndRedister
    {
        private List<Account> accounts;

        public LoginAndRedister()
        {
            FileAccessor accessor = new FileAccessor();
            accounts = accessor.GetAccountsList();
        }
        //TODO see if one of the accounts has the same name
        private bool AccountNameExists(string name)
        {
            foreach (Account account in accounts)
            {
                if (account.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Login(string name, string password)
        {
            if (AccountNameExists(name))
            {
                foreach (Account account in accounts)
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

        // if create:
        //TODO if none exist create + add to list
        //TODO return success or not.


    }
}
