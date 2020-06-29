using BootCamp.Chapter.ReportsManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Command
{
    public class DailyCommand : ICommand
    {
        private string _Path;
        private string[] _Command;
        private List<Transaction> _Transactions;
        private ReportsManager _ReportsManager;
        private string _Shop;

        public DailyCommand(string path, string[] command, List<Transaction> transactions, ReportsManager reportsManager)
        {
            _Path = path;
            _Command = command;
            _Transactions = transactions;
            _ReportsManager = reportsManager;
        }

        public void Execute()
        {
            ExtractShopName();
            ValidateShopName();
            throw new NotImplementedException();
        }

        private void ExtractShopName()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < _Command.Length; i++)
            {
                sb.Append(_Command[i] + " ");
            }
            if (String.IsNullOrEmpty(sb.ToString()))
            {
                throw new InvalidCommandException("Must enter a shop name.");
            }
            _Shop = sb.ToString().Trim();
        }

        private void ValidateShopName()
        {
            IEnumerable<String> shopnames = _Transactions.Select(z => z.ShopName).Distinct();

            if (shopnames.Contains(_Shop))
            {
                return;
            }
            else
            {
                throw new InvalidCommandException($"Shop name {_Shop} does not exsist.");
            }
        }
    }
}
