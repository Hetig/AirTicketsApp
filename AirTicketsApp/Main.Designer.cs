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
			tableLayoutPanel1 = new TableLayoutPanel();
			select = new Button();
			addRow = new Button();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 253F));
			tableLayoutPanel1.Location = new Point(12, 12);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(776, 392);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// select
			// 
			select.Location = new Point(531, 410);
			select.Name = "select";
			select.Size = new Size(94, 29);
			select.TabIndex = 2;
			select.Text = "Выбрать";
			select.UseVisualStyleBackColor = true;
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
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(addRow);
			Controls.Add(select);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "Main";
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Button select;
		private Button addRow;
	}
}