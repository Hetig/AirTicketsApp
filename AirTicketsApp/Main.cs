using AirTicketsApp.Models;
using Newtonsoft.Json;

namespace AirTicketsApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void addRow_Click(object sender, EventArgs e)
		{
			var addForm = new Add();
			addForm.ShowDialog();
		}

		private void select_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var jsonValue = FileProvider.GetValue(openFileDialog.FileName);
				var tickets = JsonConvert.DeserializeObject<List<AirTicket>>(jsonValue);

				tickets.ForEach(ticket => dataGridView.Rows.Add(ticket.Time, ticket.FlightNumber, ticket.Names));			
			}
		}
	}
}