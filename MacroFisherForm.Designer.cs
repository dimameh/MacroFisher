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
			this.StartButton = new System.Windows.Forms.Button();
			this.AddMacroButton = new System.Windows.Forms.Button();
			this.MacrosListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(12, 286);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(172, 40);
			this.StartButton.TabIndex = 3;
			this.StartButton.Text = "Начать!";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// AddMacroButton
			// 
			this.AddMacroButton.Location = new System.Drawing.Point(266, 286);
			this.AddMacroButton.Name = "AddMacroButton";
			this.AddMacroButton.Size = new System.Drawing.Size(172, 40);
			this.AddMacroButton.TabIndex = 4;
			this.AddMacroButton.Text = "Добавить макрос";
			this.AddMacroButton.UseVisualStyleBackColor = true;
			// 
			// MacrosListBox
			// 
			this.MacrosListBox.FormattingEnabled = true;
			this.MacrosListBox.ItemHeight = 16;
			this.MacrosListBox.Location = new System.Drawing.Point(266, 12);
			this.MacrosListBox.Name = "MacrosListBox";
			this.MacrosListBox.Size = new System.Drawing.Size(172, 260);
			this.MacrosListBox.TabIndex = 5;
			// 
			// MacroFisherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MacroFisher.Properties.Resources.index;
			this.ClientSize = new System.Drawing.Size(450, 338);
			this.Controls.Add(this.MacrosListBox);
			this.Controls.Add(this.AddMacroButton);
			this.Controls.Add(this.StartButton);
			this.Name = "MacroFisherForm";
			this.Text = "Macro Fisher [0.1]";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button AddMacroButton;
		private System.Windows.Forms.ListBox MacrosListBox;
	}
}

