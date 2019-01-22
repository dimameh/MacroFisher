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
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(12, 191);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(172, 40);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Начать!";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// AddMacroButton
			// 
			this.AddMacroButton.Location = new System.Drawing.Point(327, 182);
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
			this.MacrosListBox.Location = new System.Drawing.Point(220, 12);
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
			this.deleteMacrosButton.Location = new System.Drawing.Point(220, 182);
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
			this.pickMacrosErrorLabel.Location = new System.Drawing.Point(12, 154);
			this.pickMacrosErrorLabel.Name = "pickMacrosErrorLabel";
			this.pickMacrosErrorLabel.Size = new System.Drawing.Size(158, 34);
			this.pickMacrosErrorLabel.TabIndex = 9;
			this.pickMacrosErrorLabel.Text = "ОЧЕВИДНО, тебе \r\nнужно выбрать макрос";
			this.pickMacrosErrorLabel.Visible = false;
			// 
			// MacroFisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MacroFisher.Properties.Resources.index;
			this.ClientSize = new System.Drawing.Size(450, 248);
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
	}
}

