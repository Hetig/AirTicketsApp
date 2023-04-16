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
	}
}