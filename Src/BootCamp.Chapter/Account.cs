namespace BootCamp.Chapter
{
    public class Account
    {
        private string[] _amounts;

        private void SetBalance(string[] amounts)
        {
            _amounts = amounts;
        }

        public string[] GetBalance()
        {
            return _amounts;
        }
    }
}