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

		private List<int> _selectedIndexes;

		public MacrosRedactorForm()
		{
			InitializeComponent();
			Macros = new Macros("Current");
			_selectedIndexes = new List<int>();
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
				errorLabel.Visible = true;
				return;
			}
			errorLabel.Visible = false;

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

			AddMacroAtGridAndList(keyTextBox.Text, int.Parse(pressTimeTextBox.Text),
				int.Parse(pauseTimeTextBox.Text), int.Parse(pressMinTextBox.Text),
				int.Parse(pressMaxTextBox.Text), int.Parse(pauseMinTextBox.Text),
				int.Parse(pauseMaxTextBox.Text));

			keyTextBox.Text = string.Empty;
			pressTimeTextBox.Text = string.Empty;
			pauseTimeTextBox.Text = string.Empty;
			pressMinTextBox.Text = string.Empty ;
			pressMaxTextBox.Text = string.Empty ;
			pauseMinTextBox.Text = string.Empty ;
			pauseMaxTextBox.Text = string.Empty;
		}

		/// <summary>
		/// Добавить команду в список
		/// </summary>
		private void AddMacroAtGridAndList(string keyChar, int secondsPressed,
			int secondsPaused, int pressRandMin, int pressRandMax, int pauseRandMin,
			int pauseRandMax)
		{
			macrosDataGrid.Rows.Add(keyChar, secondsPressed,
				secondsPaused, '(' + pressRandMin + " ; " + pressRandMax + ')',
				'(' + pauseRandMin + " ; " + pauseRandMax + ')');

			byte key;

			if (keyChar.Length > 1)
			{
				key = GetKeyFromText(keyTextBox.Text);
			}
			else
			{
				key = (byte)VkKeyScan(keyTextBox.Text[0]);
			}

			Macros.AddCommand(new Command(key, secondsPressed,
				secondsPaused, pressRandMin, pressRandMax, pauseRandMin,
				pauseRandMax));
		}

		/// <summary>
		/// Валидация чисел
		/// </summary>
		private void IntValidation(object sender, KeyPressEventArgs e)
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

		/// <summary>
		/// Получить байтовый ключ из текстового кода
		/// </summary>
		/// <param name="text">string строка</param>
		/// <returns></returns>
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
		
		/// <summary>
		/// Сохранить
		/// </summary>
		private void saveButton_Click(object sender, EventArgs e)
		{
			if (macrosNameTextBox.Text != string.Empty && !Macros.IsEmpty)
			{
				Macros.Name = macrosNameTextBox.Text;
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Требуется название макроса. Макрос также не должен быть пустым");
			}
		}

		private void macrosDataGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			foreach (int index in _selectedIndexes)
			{
				Macros.RemoveAt(index);
			}
		}

		private void macrosDataGrid_SelectionChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < macrosDataGrid.SelectedRows.Count; i++)
			{
				_selectedIndexes[i] = macrosDataGrid.SelectedRows[i].Index;
			}
		}

		private void MacrosRedactorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (macrosNameTextBox.Text != string.Empty && !Macros.IsEmpty)
			{
				Macros.Name = macrosNameTextBox.Text;
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.Abort;
			}
		}
	}
}
