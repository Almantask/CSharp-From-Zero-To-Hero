using BootCamp.Chapter.Models;
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
        private List<string> _Command;
        private List<Transaction> _Transactions;
        private ReportsManager _ReportsManager;
        private string _Shop;
        private bool _Ascending;

        public DailyCommand(string path, List<string> command, List<Transaction> transactions, ReportsManager reportsManager)
        {
            _Path = path;
            _Command = command;
            _Transactions = transactions;
            _ReportsManager = reportsManager;
        }

        public void Execute()
        {
            _Ascending = IsAscendingOrDescending();
            ExtractShopName();
            ValidateShopName();
            IEnumerable<EarnedDayDecimal> earnedPerDayDecimal = GetEarnedPerDayDecimalForShop();
            sortList(ref earnedPerDayDecimal);
            List<Earning> EarnedPerDay = GetEarningListFromEarnedDayDecimalList(earnedPerDayDecimal);
            _ReportsManager.WriteModel(_Path, EarnedPerDay);
        }

        private bool IsAscendingOrDescending()
        {
            if(_Command[_Command.Count - 1] == "-desc")
            {
                _Command.RemoveAt(_Command.Count - 1);
                return false;
            }
            if (_Command[_Command.Count - 1] == "-asc")
            {
                _Command.RemoveAt(_Command.Count - 1);
            }
                return true;
        }

        private void ExtractShopName()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < _Command.Count; i++)
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

        private IEnumerable<EarnedDayDecimal> GetEarnedPerDayDecimalForShop()
        {
            IEnumerable<EarnedDayDecimal> sortedTransactionsByDayOfWeek = _Transactions.Where(x => x.ShopName == _Shop)
                                                            .Select(x => new { x.DateTime.DayOfWeek, x.Price, x.DateTime })
                                                            .GroupBy(x => x.DayOfWeek)
                                                            .Select(x => new EarnedDayDecimal
                                                            {
                                                                Day = x.First().DayOfWeek.ToString(),
                                                                Earned = x.Sum(z => z.Price) / x.Select(z => z.DateTime.Date)
                                                                                                                                .Distinct()
                                                                                                                                .Count()
                                                            });
            return sortedTransactionsByDayOfWeek;
        }

        private void sortList(ref IEnumerable<EarnedDayDecimal> earnedPerDayDecimal)
        {
            if (_Ascending)
            {
                earnedPerDayDecimal = earnedPerDayDecimal.OrderBy(x => x.Earned);
            }
            else
            {
                earnedPerDayDecimal = earnedPerDayDecimal.OrderByDescending(x => x.Earned);
            }
        }
            

private static List<Earning> GetEarningListFromEarnedDayDecimalList(IEnumerable<EarnedDayDecimal> sortedTransactionsByDayOfWeek)
        {
            List<Earning> sortedEarnedDayModel = new List<Earning>();

            foreach (EarnedDayDecimal earnedDayDecimal in sortedTransactionsByDayOfWeek)
            {
                sortedEarnedDayModel.Add(Earning.ConvertFromDecimal(earnedDayDecimal));
            }
            return sortedEarnedDayModel;
        }
    }
}
