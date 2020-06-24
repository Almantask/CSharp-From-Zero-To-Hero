namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CredentialsManager credentials_manager = new CredentialsManager(@"C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Credentials\Credentials.txt");
            CredentialsCollector initial_credentials = new CredentialsCollector("Matthew2", "Thisisverysafe");
            
            credentials_manager.Register(initial_credentials.Credentials);
        }
    }
}
