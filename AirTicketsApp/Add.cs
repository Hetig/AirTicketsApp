using AirTicketsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketsApp
{
	public partial class Add : Form
	{
		public Add()
		{
			InitializeComponent();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var airTicket = new AirTicket(dateTimePicker.Value, flightNumberTextBox.Text, namesTextBox.Text);

			TicketsStorage.Add(airTicket);
			MessageBox.Show("Билет успешно добавлен");
		}
	}
}
