using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter
{
	[XmlRoot("Earnings")]
	public class EarningsDTO
	{
		public List<TimeDTO> Times { get; set; }
		public int RushHour { get; set; }
	}

	[XmlType("Time")]
	public class TimeDTO
	{
		public int Hour { get; set;}
		public int Count { get; set;}
		public string Earned { get; set;}
	}
}
