namespace AirTicketsApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			select = new Button();
			addRow = new Button();
			openFileDialog = new OpenFileDialog();
			dataGridView = new DataGridView();
			Time = new DataGridViewTextBoxColumn();
			FlightNumber = new DataGridViewTextBoxColumn();
			Names = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// select
			// 
			select.Location = new Point(531, 410);
			select.Name = "select";
			select.Size = new Size(94, 29);
			select.TabIndex = 2;
			select.Text = "Выбрать";
			select.UseVisualStyleBackColor = true;
			select.Click += select_Click;
			// 
			// addRow
			// 
			addRow.Location = new Point(631, 409);
			addRow.Name = "addRow";
			addRow.Size = new Size(157, 29);
			addRow.TabIndex = 3;
			addRow.Text = "Добавить запись";
			addRow.UseVisualStyleBackColor = true;
			addRow.Click += addRow_Click;
			// 
			// openFileDialog
			// 
			openFileDialog.FileName = "openFileDialog1";
			// 
			// dataGridView
			// 
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Columns.AddRange(new DataGridViewColumn[] { Time, FlightNumber, Names });
			dataGridView.Location = new Point(12, 12);
			dataGridView.Name = "dataGridView";
			dataGridView.RowHeadersWidth = 51;
			dataGridView.RowTemplate.Height = 29;
			dataGridView.Size = new Size(776, 377);
			dataGridView.TabIndex = 4;
			// 
			// Time
			// 
			Time.HeaderText = "Время вылета";
			Time.MinimumWidth = 6;
			Time.Name = "Time";
			Time.Width = 240;
			// 
			// FlightNumber
			// 
			FlightNumber.HeaderText = "Номер рейса";
			FlightNumber.MinimumWidth = 6;
			FlightNumber.Name = "FlightNumber";
			FlightNumber.Width = 240;
			// 
			// Names
			// 
			Names.HeaderText = "ФИО пассажиров";
			Names.MinimumWidth = 6;
			Names.Name = "Names";
			Names.Width = 240;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView);
			Controls.Add(addRow);
			Controls.Add(select);
			Name = "Form1";
			Text = "Main";
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Button select;
		private Button addRow;
		private OpenFileDialog openFileDialog;
		private DataGridView dataGridView;
		private DataGridViewTextBoxColumn Time;
		private DataGridViewTextBoxColumn FlightNumber;
		private DataGridViewTextBoxColumn Names;
	}
}