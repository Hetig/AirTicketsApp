namespace AirTicketsApp
{
	partial class Add
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dateTimePicker = new DateTimePicker();
			addButton = new Button();
			label3 = new Label();
			namesTextBox = new TextBox();
			label2 = new Label();
			label1 = new Label();
			flightNumberTextBox = new TextBox();
			SuspendLayout();
			// 
			// dateTimePicker
			// 
			dateTimePicker.Format = DateTimePickerFormat.Time;
			dateTimePicker.Location = new Point(231, 89);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(338, 27);
			dateTimePicker.TabIndex = 14;
			// 
			// addButton
			// 
			addButton.Location = new Point(331, 364);
			addButton.Name = "addButton";
			addButton.Size = new Size(141, 37);
			addButton.TabIndex = 13;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
			addButton.Click += addButton_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(307, 267);
			label3.Name = "label3";
			label3.Size = new Size(193, 20);
			label3.TabIndex = 12;
			label3.Text = "Укажите ФИО пассажиров";
			// 
			// namesTextBox
			// 
			namesTextBox.Location = new Point(231, 300);
			namesTextBox.Name = "namesTextBox";
			namesTextBox.Size = new Size(338, 27);
			namesTextBox.TabIndex = 11;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(322, 152);
			label2.Name = "label2";
			label2.Size = new Size(162, 20);
			label2.TabIndex = 10;
			label2.Text = "Укажите номер рейса";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(316, 49);
			label1.Name = "label1";
			label1.Size = new Size(168, 20);
			label1.TabIndex = 9;
			label1.Text = "Укажите время вылета";
			// 
			// flightNumberTextBox
			// 
			flightNumberTextBox.Location = new Point(231, 186);
			flightNumberTextBox.Name = "flightNumberTextBox";
			flightNumberTextBox.Size = new Size(338, 27);
			flightNumberTextBox.TabIndex = 8;
			// 
			// Add
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dateTimePicker);
			Controls.Add(addButton);
			Controls.Add(label3);
			Controls.Add(namesTextBox);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(flightNumberTextBox);
			Name = "Add";
			Text = "Add";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker;
		private Button addButton;
		private Label label3;
		private TextBox namesTextBox;
		private Label label2;
		private Label label1;
		private TextBox flightNumberTextBox;
	}
}