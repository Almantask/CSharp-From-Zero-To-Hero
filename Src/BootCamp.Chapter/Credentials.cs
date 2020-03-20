namespace BootCamp.Chapter
{
    internal struct Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                throw new InvalidArgumentException("Unexpected arguments for username or password.");
            }

            Username = username;
            Password = password;
        }
    }
}
