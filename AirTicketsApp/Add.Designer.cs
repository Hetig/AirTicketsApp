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
			dateTimePicker1 = new DateTimePicker();
			addButton = new Button();
			label3 = new Label();
			textBox3 = new TextBox();
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(231, 89);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(338, 27);
			dateTimePicker1.TabIndex = 14;
			// 
			// addButton
			// 
			addButton.Location = new Point(331, 364);
			addButton.Name = "addButton";
			addButton.Size = new Size(141, 37);
			addButton.TabIndex = 13;
			addButton.Text = "Добавить";
			addButton.UseVisualStyleBackColor = true;
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
			// textBox3
			// 
			textBox3.Location = new Point(231, 300);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(338, 27);
			textBox3.TabIndex = 11;
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
			// textBox2
			// 
			textBox2.Location = new Point(231, 186);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(338, 27);
			textBox2.TabIndex = 8;
			// 
			// Add
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dateTimePicker1);
			Controls.Add(addButton);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Name = "Add";
			Text = "Add";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private Button addButton;
		private Label label3;
		private TextBox textBox3;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
	}
}