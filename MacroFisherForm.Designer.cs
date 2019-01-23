namespace MacroFisher
{
	partial class MacroFisherForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacroFisherForm));
			this.StartButton = new System.Windows.Forms.Button();
			this.AddMacroButton = new System.Windows.Forms.Button();
			this.MacrosListBox = new System.Windows.Forms.ListBox();
			this.currentMacrosLabel = new System.Windows.Forms.Label();
			this.currentMacrosName = new System.Windows.Forms.Label();
			this.deleteMacrosButton = new System.Windows.Forms.Button();
			this.pickMacrosErrorLabel = new System.Windows.Forms.Label();
			this.repeatMacrosButton = new System.Windows.Forms.Button();
			this.NTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.startSecTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(16, 136);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(113, 44);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Начать!";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// AddMacroButton
			// 
			this.AddMacroButton.Location = new System.Drawing.Point(371, 182);
			this.AddMacroButton.Name = "AddMacroButton";
			this.AddMacroButton.Size = new System.Drawing.Size(111, 49);
			this.AddMacroButton.TabIndex = 4;
			this.AddMacroButton.Text = "Добавить макрос";
			this.AddMacroButton.UseVisualStyleBackColor = true;
			this.AddMacroButton.Click += new System.EventHandler(this.AddMacroButton_Click);
			// 
			// MacrosListBox
			// 
			this.MacrosListBox.FormattingEnabled = true;
			this.MacrosListBox.ItemHeight = 16;
			this.MacrosListBox.Location = new System.Drawing.Point(264, 12);
			this.MacrosListBox.Name = "MacrosListBox";
			this.MacrosListBox.Size = new System.Drawing.Size(218, 164);
			this.MacrosListBox.TabIndex = 5;
			this.MacrosListBox.SelectedIndexChanged += new System.EventHandler(this.MacrosListBox_SelectedIndexChanged);
			// 
			// currentMacrosLabel
			// 
			this.currentMacrosLabel.AutoSize = true;
			this.currentMacrosLabel.Location = new System.Drawing.Point(9, 12);
			this.currentMacrosLabel.Name = "currentMacrosLabel";
			this.currentMacrosLabel.Size = new System.Drawing.Size(140, 17);
			this.currentMacrosLabel.TabIndex = 6;
			this.currentMacrosLabel.Text = "Выбранный макрос:";
			// 
			// currentMacrosName
			// 
			this.currentMacrosName.AutoSize = true;
			this.currentMacrosName.Location = new System.Drawing.Point(9, 43);
			this.currentMacrosName.Name = "currentMacrosName";
			this.currentMacrosName.Size = new System.Drawing.Size(130, 17);
			this.currentMacrosName.TabIndex = 7;
			this.currentMacrosName.Text = "Макрос не выбран";
			// 
			// deleteMacrosButton
			// 
			this.deleteMacrosButton.Location = new System.Drawing.Point(264, 182);
			this.deleteMacrosButton.Name = "deleteMacrosButton";
			this.deleteMacrosButton.Size = new System.Drawing.Size(101, 49);
			this.deleteMacrosButton.TabIndex = 8;
			this.deleteMacrosButton.Text = "Удалить макрос";
			this.deleteMacrosButton.UseVisualStyleBackColor = true;
			this.deleteMacrosButton.Click += new System.EventHandler(this.deleteMacrosButton_Click);
			// 
			// pickMacrosErrorLabel
			// 
			this.pickMacrosErrorLabel.AutoSize = true;
			this.pickMacrosErrorLabel.BackColor = System.Drawing.Color.Transparent;
			this.pickMacrosErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.pickMacrosErrorLabel.Location = new System.Drawing.Point(12, 96);
			this.pickMacrosErrorLabel.Name = "pickMacrosErrorLabel";
			this.pickMacrosErrorLabel.Size = new System.Drawing.Size(158, 34);
			this.pickMacrosErrorLabel.TabIndex = 9;
			this.pickMacrosErrorLabel.Text = "ОЧЕВИДНО, тебе \r\nнужно выбрать макрос";
			this.pickMacrosErrorLabel.Visible = false;
			// 
			// repeatMacrosButton
			// 
			this.repeatMacrosButton.Location = new System.Drawing.Point(15, 186);
			this.repeatMacrosButton.Name = "repeatMacrosButton";
			this.repeatMacrosButton.Size = new System.Drawing.Size(113, 45);
			this.repeatMacrosButton.TabIndex = 10;
			this.repeatMacrosButton.Text = "Повторить макрос N раз";
			this.repeatMacrosButton.UseVisualStyleBackColor = true;
			this.repeatMacrosButton.Click += new System.EventHandler(this.repeatMacrosButton_Click);
			// 
			// NTextBox
			// 
			this.NTextBox.Location = new System.Drawing.Point(134, 209);
			this.NTextBox.MaxLength = 3;
			this.NTextBox.Name = "NTextBox";
			this.NTextBox.Size = new System.Drawing.Size(79, 22);
			this.NTextBox.TabIndex = 11;
			this.NTextBox.Text = "5";
			this.NTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 189);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 17);
			this.label1.TabIndex = 12;
			this.label1.Text = "N";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(134, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "Секунд до старта";
			// 
			// startSecTextBox
			// 
			this.startSecTextBox.Location = new System.Drawing.Point(135, 156);
			this.startSecTextBox.MaxLength = 3;
			this.startSecTextBox.Name = "startSecTextBox";
			this.startSecTextBox.Size = new System.Drawing.Size(79, 22);
			this.startSecTextBox.TabIndex = 13;
			this.startSecTextBox.Text = "1";
			this.startSecTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValidation);
			// 
			// MacroFisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MacroFisher.Properties.Resources.index;
			this.ClientSize = new System.Drawing.Size(493, 240);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.startSecTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NTextBox);
			this.Controls.Add(this.repeatMacrosButton);
			this.Controls.Add(this.pickMacrosErrorLabel);
			this.Controls.Add(this.deleteMacrosButton);
			this.Controls.Add(this.currentMacrosName);
			this.Controls.Add(this.currentMacrosLabel);
			this.Controls.Add(this.MacrosListBox);
			this.Controls.Add(this.AddMacroButton);
			this.Controls.Add(this.StartButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MacroFisherForm";
			this.Text = "Macro Fisher [0.1]";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacroFisherForm_FormClosing);
			this.Load += new System.EventHandler(this.MacroFisherForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button AddMacroButton;
		private System.Windows.Forms.ListBox MacrosListBox;
		private System.Windows.Forms.Label currentMacrosLabel;
		private System.Windows.Forms.Label currentMacrosName;
		private System.Windows.Forms.Button deleteMacrosButton;
		private System.Windows.Forms.Label pickMacrosErrorLabel;
		private System.Windows.Forms.Button repeatMacrosButton;
		private System.Windows.Forms.TextBox NTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox startSecTextBox;
	}
}

