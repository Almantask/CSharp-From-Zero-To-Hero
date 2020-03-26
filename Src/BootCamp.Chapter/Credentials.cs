namespace BootCamp.Chapter
{
    internal struct Credentials
    {
        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new InvalidArgumentException("Unexpected argument for username.");
                }
                _username = value;
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == null || value.Trim() == "")
                {
                    throw new InvalidArgumentException("Unexpected argument for password.");
                }
                _password = value;
            }
        }
    }
}
