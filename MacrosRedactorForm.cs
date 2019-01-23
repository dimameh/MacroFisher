using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroFisher
{
	public partial class MacrosRedactorForm : Form
	{
		/// <summary>
		/// Перевод символа в кейкод
		/// </summary>
		/// <param name="ch">символ</param>
		/// <returns></returns>
		[DllImport("user32.dll")] static extern short VkKeyScan(char ch);


		public Macros Macros { get;}

		public MacrosRedactorForm()
		{
			InitializeComponent();
			Macros = new Macros("Current");
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (keyTextBox.Text == string.Empty ||
			    pressTimeTextBox.Text == string.Empty ||
				pauseTimeTextBox.Text == string.Empty ||
				pressMinTextBox.Text == string.Empty ||
				pressMaxTextBox.Text == string.Empty ||
				pauseMinTextBox.Text == string.Empty ||
				pauseMaxTextBox.Text == string.Empty)
			{
				
			}
			byte key;
			keyTextBox.Text = keyTextBox.Text.ToUpper();
			if (keyTextBox.Text.Length > 1)
			{
				key = GetKeyFromText(keyTextBox.Text);
			}
			else
			{
				key = (byte) VkKeyScan(keyTextBox.Text[0]);
			}

			AddMacroAtGridAndList(keyTextBox.Text, key, int.Parse(pressTimeTextBox.Text),
					int.Parse(pauseTimeTextBox.Text));

			keyTextBox.Text = string.Empty;
			pressTimeTextBox.Text = string.Empty;
			pauseTimeTextBox.Text = string.Empty;
		}

		private void AddMacroAtGridAndList(string strKey, byte byteKey, int pressTime, int pauseTime)
		{
			//if (holdRadioButton.Checked)
			//{
			//	macrosDataGrid.Rows.Add(strKey, pressTime,
			//		pauseTime, "Зажать");

			//	Macros.AddCommand(new Command(byteKey, int.Parse(pressTimeTextBox.Text),
			//		int.Parse(pauseTimeTextBox.Text)));
			//}
			//else
			//{
			//	macrosDataGrid.Rows.Add(strKey, pressTime,
			//		pauseTime, "Тыкнуть");

			//	Macros.AddCommand(new Command(byteKey, int.Parse(pressTimeTextBox.Text),
			//		int.Parse(pauseTimeTextBox.Text)));
			//}
		}

		private void pressTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back) 
			{
				e.Handled = true;
			}
			else
			{
				e.Handled = false;
			}
		}

		private void pauseTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			else
			{
				e.Handled = false;
			}
		}

		private byte GetKeyFromText(string text)
		{
			switch (text)
			{
				case "LMB":
					return 0x01;
				case "RMB":
					return 0x02;
				case "MMB":
					return 0x04;
				default:
					throw new ArgumentException("No such key");
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (macrosNameTextBox.Text != string.Empty)
			{
				Macros.Name = macrosNameTextBox.Text;
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Требуется название макроса");
			}
		}
	}
}
