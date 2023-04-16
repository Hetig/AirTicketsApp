using AirTicketsApp.Models;
using Newtonsoft.Json;

namespace AirTicketsApp
{
	public class TicketsStorage
	{
		public static readonly string FileName = "AirTickets.json";

		public static void Add(AirTicket ticket)
		{
			var tickets = GetAll();
			tickets.Add(ticket);
			var jsonValue = JsonConvert.SerializeObject(tickets);
			FileProvider.Replace(FileName, jsonValue);
		}

		public static List<AirTicket> GetAll()
		{
			if(!FileProvider.Exist("AirTickets.json"))
			{
				return new List<AirTicket>();
			}

			var jsonValue = FileProvider.GetValue(FileName);
			var tickets = JsonConvert.DeserializeObject<List<AirTicket>>(jsonValue);
			return tickets;
		}
	}
}
