using System.Text;

namespace BootCamp.Chapter
{
    public class Account
    {
        public Account(string name, string password)
        {
            Name = name;
            StringBuilder sb = new StringBuilder();
            byte[] bytePassword = Encoding.Unicode.GetBytes(password);
            for (int i = 0; i < bytePassword.Length; i++)
            {
                if (i < bytePassword.Length - 1)
                {
                    sb.Append(bytePassword[i].ToString() + " ");
                }
                else
                {
                    sb.Append(bytePassword[i].ToString());
                }
            }
            Password = sb.ToString();
        }
        public string Name { get; }
        public string Password { get; }
    }
}
