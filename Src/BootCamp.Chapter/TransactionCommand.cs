using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Diagnostics;

namespace BootCamp.Chapter
{
	public class TransactionCommand
	{
		public static readonly string Time = "time";
		public static readonly string City = "city";

		//Key: string cmd
		//Value: Action that takes string cmdParameters
		public Dictionary<string, Func<IEnumerable<Transaction>, string, object>> cmds = new Dictionary<string, Func<IEnumerable<Transaction>, string, object>>();

		public TransactionCommand()
		{
			//Setup default command options
			cmds.Add(TransactionCommand.Time, TransactionCommand.TimeCmd);
			cmds.Add(TransactionCommand.City, TransactionCommand.CityCmd);
		}

		public object RunCmd(IEnumerable<Transaction> transactions, string cmdAndArgs)
		{
			//Error if nothing was given
			if (string.IsNullOrWhiteSpace(cmdAndArgs)) throw new InvalidCommandException();

			//Pull command out
			string[] splitCmd = cmdAndArgs.Split(' ');
			string cmd = splitCmd[0];
			//Put args back together
			string args = splitCmd.Length > 1 ? string.Join(" ", splitCmd[1..]) : string.Empty;

			//Check if cmd is valid
			if (!cmds.ContainsKey(cmd)) throw new InvalidCommandException();

			//Run cmd
			return cmds[cmd](transactions, args);
		}

		public static object TimeCmd(IEnumerable<Transaction> transactions, string parameters)
		{
			bool hasParameters = !string.IsNullOrEmpty(parameters);
			DateTime startTime = default;
			DateTime endTime = default;

			//Parameters should be a time range "20:00-00:00"
			if (hasParameters)
			{
				string formatErrorMessage = $"Command parameter, \"{parameters}\", is not formatted correctly.";
				string[] splitTimes = parameters.Split('-');
				//Error if we don't have 2 fields
				if (splitTimes.Length != 2) throw new FormatException(formatErrorMessage);
				//Get start time
				if (!DateTime.TryParseExact(splitTimes[0], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime)) throw new FormatException(formatErrorMessage);
				//Get end time
				if (!DateTime.TryParseExact(splitTimes[1], "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime)) throw new FormatException(formatErrorMessage);
			}

			//Group transactions by hours
			var hoursEarned = from transaction in transactions
							  group transaction by transaction.DateTime.Hour into hours
							  select new
							  {
								  Hour = hours.Key,
								  Count = hours.Count(),
								  DayCount = (from hour in hours select hour.DateTime.Date).Distinct().Count(),
								  TotalEarned = hours.Sum(transaction => transaction.PriceValue)
							  } into hours
							  select new
							  {
								  hours.Hour,
								  hours.Count,
								  Earned = (hours.TotalEarned / hours.DayCount)
							  };

			//Left join to all hours to get a full day list of values
			var allHoursEarned = from hour in Enumerable.Range(0, 24).ToList()
								 join hourEarned in hoursEarned
								 on hour equals hourEarned.Hour into allHours
								 from allHour in allHours.DefaultIfEmpty(new
								 {
									 Hour = hour,
									 Count = 0,
									 Earned = 0m
								 })
								 select allHour;

			//Filter time range if passed in
			if (hasParameters)
			{
				allHoursEarned = from hourEarned in allHoursEarned
								 where hourEarned.Hour >= startTime.Hour
								 where hourEarned.Hour <= (endTime.Hour == 0 ? 24 : endTime.Hour)//Change 00:00 end times to 24:00 for range check
								 select hourEarned;
			}

			//Get rush hour (highest earned hour)
			int rushHour = (from hourEarned in allHoursEarned
							orderby hourEarned.Earned descending
							select hourEarned.Hour).First();

			//Convert to DTO and return
			return new EarningsDTO
			{
				Times = allHoursEarned.Select(h => new TimeDTO
				{
					Hour = h.Hour,
					Count = h.Count,
					Earned = string.Format($"€{h.Earned}")
				}).ToList(),
				RushHour = rushHour
			};
		}
		public static object CityCmd(IEnumerable<Transaction> transactions, string parameters)
		{
			//2 parameters required
			//Split parameters
			string formatErrorMessage = $"Command parameters, \"{parameters}\", are not formatted correctly.";
			string[] splitParams = parameters.Split(' ');
			//Error if we don't have 2 fields
			if (splitParams.Length != 2) throw new FormatException(formatErrorMessage);
			//Get what field we're ordering by
			CityFilterField filterField;
			if (!Enum.TryParse(splitParams[0][1..], out filterField)) throw new FormatException(formatErrorMessage);//Ignore first char as it's '-'
																													//Get how we're ordering
			CityFilterType filterType;
			if (!Enum.TryParse(splitParams[1][1..], out filterType)) throw new FormatException(formatErrorMessage);//Ignore first char as it's '-'

			//Group each city
			var results = from transaction in transactions
						  group transaction by transaction.City into cities
						  select new
						  {
							  City = cities.Key,
							  ItemCount = cities.Count(),
							  TotalPrice = cities.Sum(c => c.PriceValue)
						  };

			//Apply filters
			switch (filterField)
			{
				case CityFilterField.items:
					//Order
					results = results.OrderBy(c => c.ItemCount);
					//Get value from min/max to check for ties
					int minMaxCount = GetMinMaxValue<int>(results.Select(r => r.ItemCount), filterType);
					//Filter results where only that count matches
					results = results.Where(r => r.ItemCount ==  minMaxCount);
					break;
				case CityFilterField.money:
					//Order
					results = results.OrderBy(c => c.TotalPrice);
					//Get value from min/max to check for ties
					decimal minMaxPrice = GetMinMaxValue<decimal>(results.Select(r => r.TotalPrice), filterType);
					//Filter results where only that count matches
					results = results.Where(r => r.TotalPrice == minMaxPrice);
					break;
			}

			//Combine cities if needed and return
			return String.Join(", ", results.Select(r => r.City));
		}

		private static T GetMinMaxValue<T>(IEnumerable<T> values, CityFilterType filterType)
		{
			return filterType switch
			{
				CityFilterType.min => values.First(),
				CityFilterType.max => values.Last(),
				_ => throw new ArgumentException()
			};
		}

		private enum CityFilterField
		{
			items,
			money
		}
		private enum CityFilterType
		{
			min,
			max
		}
	}


}