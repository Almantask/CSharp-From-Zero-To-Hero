namespace BootCamp.Chapter
{
    internal struct User
    {
        public readonly string Username;
        public readonly string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
