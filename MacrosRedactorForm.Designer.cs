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
			this.PressRandom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RandomPause = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addButton = new System.Windows.Forms.Button();
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.pressTimeTextBox = new System.Windows.Forms.TextBox();
			this.pauseTimeTextBox = new System.Windows.Forms.TextBox();
			this.KeyHintLabel = new System.Windows.Forms.Label();
			this.pressTimeHintLabel = new System.Windows.Forms.Label();
			this.pauseTimeHintLabel = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.macrosNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pressMinTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pressMaxTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pauseMaxTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pauseMinTextBox = new System.Windows.Forms.TextBox();
			this.errorLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
            this.PressRandom,
            this.RandomPause});
			this.macrosDataGrid.Location = new System.Drawing.Point(12, 12);
			this.macrosDataGrid.Name = "macrosDataGrid";
			this.macrosDataGrid.RowTemplate.Height = 24;
			this.macrosDataGrid.Size = new System.Drawing.Size(703, 318);
			this.macrosDataGrid.TabIndex = 0;
			this.macrosDataGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.macrosDataGrid_RowsRemoved);
			this.macrosDataGrid.SelectionChanged += new System.EventHandler(this.macrosDataGrid_SelectionChanged);
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
			// PressRandom
			// 
			this.PressRandom.Frozen = true;
			this.PressRandom.HeaderText = "Рамки зажатия";
			this.PressRandom.Name = "PressRandom";
			this.PressRandom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.PressRandom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// RandomPause
			// 
			this.RandomPause.Frozen = true;
			this.RandomPause.HeaderText = "Рамки паузы";
			this.RandomPause.Name = "RandomPause";
			this.RandomPause.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.RandomPause.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(718, 337);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(121, 35);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// keyTextBox
			// 
			this.keyTextBox.Location = new System.Drawing.Point(721, 33);
			this.keyTextBox.MaxLength = 4;
			this.keyTextBox.Name = "keyTextBox";
			this.keyTextBox.Size = new System.Drawing.Size(92, 22);
			this.keyTextBox.TabIndex = 2;
			// 
			// pressTimeTextBox
			// 
			this.pressTimeTextBox.Location = new System.Drawing.Point(721, 80);
			this.pressTimeTextBox.MaxLength = 4;
			this.pressTimeTextBox.Name = "pressTimeTextBox";
			this.pressTimeTextBox.Size = new System.Drawing.Size(111, 22);
			this.pressTimeTextBox.TabIndex = 7;
			this.pressTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// pauseTimeTextBox
			// 
			this.pauseTimeTextBox.Location = new System.Drawing.Point(720, 125);
			this.pauseTimeTextBox.MaxLength = 5;
			this.pauseTimeTextBox.Name = "pauseTimeTextBox";
			this.pauseTimeTextBox.Size = new System.Drawing.Size(92, 22);
			this.pauseTimeTextBox.TabIndex = 8;
			this.pauseTimeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// KeyHintLabel
			// 
			this.KeyHintLabel.AutoSize = true;
			this.KeyHintLabel.Location = new System.Drawing.Point(721, 13);
			this.KeyHintLabel.Name = "KeyHintLabel";
			this.KeyHintLabel.Size = new System.Drawing.Size(67, 17);
			this.KeyHintLabel.TabIndex = 9;
			this.KeyHintLabel.Text = "Клавиша";
			// 
			// pressTimeHintLabel
			// 
			this.pressTimeHintLabel.AutoSize = true;
			this.pressTimeHintLabel.Location = new System.Drawing.Point(722, 60);
			this.pressTimeHintLabel.Name = "pressTimeHintLabel";
			this.pressTimeHintLabel.Size = new System.Drawing.Size(110, 17);
			this.pressTimeHintLabel.TabIndex = 10;
			this.pressTimeHintLabel.Text = "Время нажатия";
			// 
			// pauseTimeHintLabel
			// 
			this.pauseTimeHintLabel.AutoSize = true;
			this.pauseTimeHintLabel.Location = new System.Drawing.Point(721, 105);
			this.pauseTimeHintLabel.Name = "pauseTimeHintLabel";
			this.pauseTimeHintLabel.Size = new System.Drawing.Size(119, 17);
			this.pauseTimeHintLabel.TabIndex = 11;
			this.pauseTimeHintLabel.Text = "Время ожидания";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(12, 336);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(99, 43);
			this.saveButton.TabIndex = 13;
			this.saveButton.Text = "Сохранить";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// macrosNameTextBox
			// 
			this.macrosNameTextBox.Location = new System.Drawing.Point(117, 357);
			this.macrosNameTextBox.MaxLength = 5;
			this.macrosNameTextBox.Name = "macrosNameTextBox";
			this.macrosNameTextBox.Size = new System.Drawing.Size(236, 22);
			this.macrosNameTextBox.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 337);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 17);
			this.label1.TabIndex = 15;
			this.label1.Text = "Название макроса";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(721, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Нажатие min";
			// 
			// pressMinTextBox
			// 
			this.pressMinTextBox.Location = new System.Drawing.Point(720, 169);
			this.pressMinTextBox.MaxLength = 5;
			this.pressMinTextBox.Name = "pressMinTextBox";
			this.pressMinTextBox.Size = new System.Drawing.Size(92, 22);
			this.pressMinTextBox.TabIndex = 16;
			this.pressMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(721, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 17);
			this.label3.TabIndex = 19;
			this.label3.Text = "Нажатие max";
			// 
			// pressMaxTextBox
			// 
			this.pressMaxTextBox.Location = new System.Drawing.Point(720, 213);
			this.pressMaxTextBox.MaxLength = 5;
			this.pressMaxTextBox.Name = "pressMaxTextBox";
			this.pressMaxTextBox.Size = new System.Drawing.Size(92, 22);
			this.pressMaxTextBox.TabIndex = 18;
			this.pressMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(719, 288);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Пауза max";
			// 
			// pauseMaxTextBox
			// 
			this.pauseMaxTextBox.Location = new System.Drawing.Point(718, 308);
			this.pauseMaxTextBox.MaxLength = 5;
			this.pauseMaxTextBox.Name = "pauseMaxTextBox";
			this.pauseMaxTextBox.Size = new System.Drawing.Size(92, 22);
			this.pauseMaxTextBox.TabIndex = 22;
			this.pauseMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(719, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "Пауза min";
			// 
			// pauseMinTextBox
			// 
			this.pauseMinTextBox.Location = new System.Drawing.Point(718, 259);
			this.pauseMinTextBox.MaxLength = 5;
			this.pauseMinTextBox.Name = "pauseMinTextBox";
			this.pauseMinTextBox.Size = new System.Drawing.Size(92, 22);
			this.pauseMinTextBox.TabIndex = 20;
			this.pauseMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.BackColor = System.Drawing.Color.Transparent;
			this.errorLabel.ForeColor = System.Drawing.Color.Red;
			this.errorLabel.Location = new System.Drawing.Point(543, 336);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(145, 17);
			this.errorLabel.TabIndex = 24;
			this.errorLabel.Text = "Заполните все поля!";
			this.errorLabel.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(359, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 68);
			this.label6.TabIndex = 25;
			this.label6.Text = "Обзначения мыши:\r\nLMB - ЛКМ\r\nRMB - ПКМ\r\nMMB - СреднКМ";
			// 
			// MacrosRedactorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MacroFisher.Properties.Resources.index;
			this.ClientSize = new System.Drawing.Size(848, 409);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pauseMaxTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pauseMinTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pressMaxTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pressMinTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.macrosNameTextBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.pauseTimeHintLabel);
			this.Controls.Add(this.pressTimeHintLabel);
			this.Controls.Add(this.KeyHintLabel);
			this.Controls.Add(this.pauseTimeTextBox);
			this.Controls.Add(this.pressTimeTextBox);
			this.Controls.Add(this.keyTextBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.macrosDataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MacrosRedactorForm";
			this.Text = "Редактор макроса";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacrosRedactorForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.macrosDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView macrosDataGrid;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.TextBox pressTimeTextBox;
		private System.Windows.Forms.TextBox pauseTimeTextBox;
		private System.Windows.Forms.Label KeyHintLabel;
		private System.Windows.Forms.Label pressTimeHintLabel;
		private System.Windows.Forms.Label pauseTimeHintLabel;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox macrosNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox pressMinTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox pressMaxTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox pauseMaxTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox pauseMinTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn Key;
		private System.Windows.Forms.DataGridViewTextBoxColumn seccondsPressed;
		private System.Windows.Forms.DataGridViewTextBoxColumn seccondsPausedAfter;
		private System.Windows.Forms.DataGridViewTextBoxColumn PressRandom;
		private System.Windows.Forms.DataGridViewTextBoxColumn RandomPause;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.Label label6;
	}
}