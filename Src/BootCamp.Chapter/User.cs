namespace BootCamp.Chapter
{
    internal class User
    {
        public string UserName { get; private set; }

        public string Password { get; private set; }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
