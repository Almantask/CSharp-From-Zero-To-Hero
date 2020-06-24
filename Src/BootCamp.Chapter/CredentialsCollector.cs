using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class CredentialsCollector
    {
        // Create a new instance of credentials and ask the user to input their username and password.
        // Check happens to ensure the user does not already have an account and saved password
        // if check comes back true then Username (not encoded) and password (encoded into Unicode) gets sorted to file
        private readonly Credentials _credentials;

        public Credentials Credentials
        {
            get { return _credentials; }
        }              

        public CredentialsCollector(string username, string password)
        {
            _credentials = new Credentials(username, password);
        }

    }
}
