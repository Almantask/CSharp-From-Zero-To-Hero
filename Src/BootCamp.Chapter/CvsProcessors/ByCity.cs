using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.CvsProcessors
{
    public class ByCity
    {
        private static CultureInfo CurrentCultureInfo => CultureInfo.GetCultureInfo("lt-LT");
        
        public static string CheckByCity(IEnumerable<Transaction> transactions, string command)
        {
            var arguments = GetCommands(command);

            string result = arguments[0] switch
            {
                Commands.Items => GetCityNameByItems(transactions, arguments),
                Commands.Money => GetCityNameByMoney(transactions, arguments)
                // ,_ => 
            };

            return result;
        }

        private static string GetCityNameByItems(IEnumerable<Transaction> transactions, List<Commands> arguments)
        {
            var data = transactions
                .GroupBy(n => n.City,
                    transaction => transaction,
                    (city, values) =>
                    {
                        var transaction = values.ToList();
                        return new CityByItems
                        (
                            city,
                            transaction.Select(n => n.Price).Count()
                        );
                    })
                .OrderBy(n => n.Count);
            
            var result = arguments[1] switch
            {
                Commands.Max => data.Last(),
                Commands.Min => data.First()
                // ,_ => throw new Exception()
            };
            return result.City;
        }

        private static string GetCityNameByMoney(IEnumerable<Transaction> transactions, List<Commands> arguments)
        {
            var data = transactions
                .GroupBy
                (
                    n => n.City,
                    transaction => transaction,
                    (city, values) =>
                    {
                        var transaction = values.ToList();
                        return new CityByMoney
                        (
                            city,
                            transaction.Select(n => n.Price).Sum()
                        );
                    }
                )
                .OrderBy(n => n.Money);

            // TODO: Better Exception
            var result = arguments[1] switch
            {
                Commands.Max => data.Last(),
                Commands.Min => data.First()
                // ,_ => throw new Exception()
            };
            return result.City;
        }

        private static List<Commands> GetCommands(string command)
        {
            var arguments = command.ToLower().Split(' ');
            if (arguments.Length != 2) throw new ArgumentException();
            var returnList = new List<Commands>();

            switch (arguments[0])
            {
                case "-items":
                    returnList.Add(Commands.Items);
                    break;
                case "-money":
                    returnList.Add(Commands.Money);
                    break;
                default:
                    throw new ArgumentException();
            }
            
            switch (arguments[1])
            {
                case "-max":
                    returnList.Add(Commands.Max);
                    break;
                case "-min":
                    returnList.Add(Commands.Min);
                    break;
                default:
                    throw new ArgumentException();
            }

            

            return returnList;
        }
    }
}