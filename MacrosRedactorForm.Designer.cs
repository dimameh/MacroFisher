namespace MacroFisher
{
	partial class MacrosRedactorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacrosRedactorForm));
			this.macrosDataGrid = new System.Windows.Forms.DataGridView();
			this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seccondsPressed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seccondsPausedAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pressType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addButton = new System.Windows.Forms.Button();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.holdRadioButton = new System.Windows.Forms.RadioButton();
			this.pressRadioButton = new System.Windows.Forms.RadioButton();
			this.pressTimeTextBox = new System.Windows.Forms.TextBox();
			this.pauseTimeTextBox = new System.Windows.Forms.TextBox();
			this.KeyHintLabel = new System.Windows.Forms.Label();
			this.pressTimeHintLabel = new System.Windows.Forms.Label();
			this.pauseTimeHintLabel = new System.Windows.Forms.Label();
			this.typeHintLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.macrosNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.macrosDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// macrosDataGrid
			// 
			this.macrosDataGrid.AllowUserToAddRows = false;
			this.macrosDataGrid.AllowUserToOrderColumns = true;
			this.macrosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.macrosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.seccondsPressed,
            this.seccondsPausedAfter,
            this.pressType});
			this.macrosDataGrid.Location = new System.Drawing.Point(12, 12);
			this.macrosDataGrid.Name = "macrosDataGrid";
			this.macrosDataGrid.RowTemplate.Height = 24;
			this.macrosDataGrid.Size = new System.Drawing.Size(590, 318);
			this.macrosDataGrid.TabIndex = 0;
			this.macrosDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.macrosDataGrid_RowsRemoved);
			// 
			// Key
			// 
			this.Key.Frozen = true;
			this.Key.HeaderText = "Клавиша";
			this.Key.MaxInputLength = 5;
			this.Key.Name = "Key";
			this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Key.ToolTipText = "Начните ввод";
			// 
			// seccondsPressed
			// 
			this.seccondsPressed.Frozen = true;
			this.seccondsPressed.HeaderText = "Время зажатия";
			this.seccondsPressed.Name = "seccondsPressed";
			this.seccondsPressed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.seccondsPressed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// seccondsPausedAfter
			// 
			this.seccondsPausedAfter.Frozen = true;
			this.seccondsPausedAfter.HeaderText = "Время ожидания после выполнения";
			this.seccondsPausedAfter.Name = "seccondsPausedAfter";
			this.seccondsPausedAfter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.seccondsPausedAfter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// pressType
			// 
			this.pressType.Frozen = true;
			this.pressType.HeaderText = "Тип";
			this.pressType.Name = "pressType";
			this.pressType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.pressType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(416, 406);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(121, 35);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(12, 365);
			this.keyTextBox.MaxLength = 4;
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.Size = new System.Drawing.Size(92, 22);
			this.keyTextBox.TabIndex = 2;
			// 
			// holdRadioButton
			// 
			this.holdRadioButton.AutoSize = true;
			this.holdRadioButton.Checked = true;
			this.holdRadioButton.Location = new System.Drawing.Point(405, 366);
			this.holdRadioButton.Name = "holdRadioButton";
			this.holdRadioButton.Size = new System.Drawing.Size(77, 21);
			this.holdRadioButton.TabIndex = 5;
			this.holdRadioButton.TabStop = true;
			this.holdRadioButton.Text = "Зажать";
			this.holdRadioButton.UseVisualStyleBackColor = true;
			// 
			// pressRadioButton
			// 
			this.pressRadioButton.AutoSize = true;
			this.pressRadioButton.Location = new System.Drawing.Point(488, 366);
			this.pressRadioButton.Name = "pressRadioButton";
			this.pressRadioButton.Size = new System.Drawing.Size(84, 21);
			this.pressRadioButton.TabIndex = 6;
			this.pressRadioButton.Text = "Тыкнуть";
			this.pressRadioButton.UseVisualStyleBackColor = true;
			// 
			// pressTimeTextBox
			// 
			this.pressTimeTextBox.Location = new System.Drawing.Point(127, 365);
			this.pressTimeTextBox.MaxLength = 4;
			this.pressTimeTextBox.Name = "pressTimeTextBox";
			this.pressTimeTextBox.Size = new System.Drawing.Size(111, 22);
			this.pressTimeTextBox.TabIndex = 7;
			this.pressTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTimeTextBox_KeyPress);
			// 
			// pauseTimeTextBox
			// 
			this.pauseTimeTextBox.Location = new System.Drawing.Point(261, 365);
			this.pauseTimeTextBox.MaxLength = 5;
			this.pauseTimeTextBox.Name = "pauseTimeTextBox";
			this.pauseTimeTextBox.Size = new System.Drawing.Size(92, 22);
			this.pauseTimeTextBox.TabIndex = 8;
			this.pauseTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pauseTimeTextBox_KeyPress);
			// 
			// KeyHintLabel
			// 
			this.KeyHintLabel.AutoSize = true;
			this.KeyHintLabel.Location = new System.Drawing.Point(12, 345);
			this.KeyHintLabel.Name = "KeyHintLabel";
			this.KeyHintLabel.Size = new System.Drawing.Size(67, 17);
			this.KeyHintLabel.TabIndex = 9;
			this.KeyHintLabel.Text = "Клавиша";
			// 
			// pressTimeHintLabel
			// 
			this.pressTimeHintLabel.AutoSize = true;
			this.pressTimeHintLabel.Location = new System.Drawing.Point(128, 345);
			this.pressTimeHintLabel.Name = "pressTimeHintLabel";
			this.pressTimeHintLabel.Size = new System.Drawing.Size(110, 17);
			this.pressTimeHintLabel.TabIndex = 10;
			this.pressTimeHintLabel.Text = "Время нажатия";
			// 
			// pauseTimeHintLabel
			// 
			this.pauseTimeHintLabel.AutoSize = true;
			this.pauseTimeHintLabel.Location = new System.Drawing.Point(262, 345);
			this.pauseTimeHintLabel.Name = "pauseTimeHintLabel";
			this.pauseTimeHintLabel.Size = new System.Drawing.Size(119, 17);
			this.pauseTimeHintLabel.TabIndex = 11;
			this.pauseTimeHintLabel.Text = "Время ожидания";
			// 
			// typeHintLabel
			// 
			this.typeHintLabel.AutoSize = true;
			this.typeHintLabel.Location = new System.Drawing.Point(444, 345);
			this.typeHintLabel.Name = "typeHintLabel";
			this.typeHintLabel.Size = new System.Drawing.Size(93, 17);
			this.typeHintLabel.TabIndex = 12;
			this.typeHintLabel.Text = "Тип нажатия";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(12, 406);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(99, 35);
			this.saveButton.TabIndex = 13;
			this.saveButton.Text = "Сохранить";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// macrosNameTextBox
			// 
			this.macrosNameTextBox.Location = new System.Drawing.Point(117, 419);
			this.macrosNameTextBox.MaxLength = 5;
			this.macrosNameTextBox.Name = "macrosNameTextBox";
			this.macrosNameTextBox.Size = new System.Drawing.Size(236, 22);
			this.macrosNameTextBox.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 399);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 15;
			this.label1.Text = "Название макроса";
			// 
			// MacrosRedactorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MacroFisher.Properties.Resources.index;
			this.ClientSize = new System.Drawing.Size(609, 455);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.macrosNameTextBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.typeHintLabel);
			this.Controls.Add(this.pauseTimeHintLabel);
			this.Controls.Add(this.pressTimeHintLabel);
			this.Controls.Add(this.KeyHintLabel);
			this.Controls.Add(this.pauseTimeTextBox);
			this.Controls.Add(this.pressTimeTextBox);
			this.Controls.Add(this.pressRadioButton);
			this.Controls.Add(this.holdRadioButton);
			this.Controls.Add(this.keyTextBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.macrosDataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MacrosRedactorForm";
			this.Text = "Редактор макроса";
			((System.ComponentModel.ISupportInitialize)(this.macrosDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView macrosDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Key;
		private System.Windows.Forms.DataGridViewTextBoxColumn seccondsPressed;
		private System.Windows.Forms.DataGridViewTextBoxColumn seccondsPausedAfter;
		private System.Windows.Forms.DataGridViewTextBoxColumn pressType;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.RadioButton holdRadioButton;
		private System.Windows.Forms.RadioButton pressRadioButton;
		private System.Windows.Forms.TextBox pressTimeTextBox;
		private System.Windows.Forms.TextBox pauseTimeTextBox;
		private System.Windows.Forms.Label KeyHintLabel;
		private System.Windows.Forms.Label pressTimeHintLabel;
		private System.Windows.Forms.Label pauseTimeHintLabel;
		private System.Windows.Forms.Label typeHintLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox macrosNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}