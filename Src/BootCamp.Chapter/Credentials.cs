namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public string Username;
        public string Password;

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            return false;
        }
    }
}
