using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MacroFisher.Tools;

namespace MacroFisher
{
	public partial class MacroFisherForm : Form
	{
		#region Отслеживание нажатий 1

		//GlobalKeyboardHook globalKeyboardHookCTRL = new GlobalKeyboardHook();
		//GlobalKeyboardHook globalKeyboardHookALT = new GlobalKeyboardHook();

		//private Thread keyboardScaner;

		//private bool IsAltPressed { get; set; } = false;
		//private bool IsCtrlPressed { get; set; } = false;
		//private bool IsActivated { get; set; } = false;

		#endregion

		#region WinAPI

		/// <summary>
		/// Имитатор зажатия клавиши
		/// </summary>
		/// <param name="bVk">кейкод клавиши (virtual-key-codes)</param>
		/// <param name="bScan">хуй знает</param>
		/// <param name="dwFlags">(флажок зажать/отпустить)</param>
		/// <param name="dwExtraInfo">хуй знает</param>
		[DllImport("user32.dll")]
		static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
			int dwExtraInfo);

		//зажать
		const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

		//отпустить
		const uint KEYEVENTF_KEYUP = 0x0002;

		#endregion

		/// <summary>
		/// Список доступных макросов
		/// </summary>
		private List<Macros> _macrosList;

		/// <summary>
		/// Макрос, выбранный в данный момент
		/// </summary>
		private Macros _currentMacros;

		/// <summary>
		/// Форма редактора макросов
		/// </summary>
		private MacrosRedactorForm _macrosRedactorForm;

		private int _secondsBeforeStart;

		private int _timesToRepeat;

		Random random = new Random();

		#region Инициализация

		public MacroFisherForm()
		{
			InitializeComponent();

			_macrosList = new List<Macros>();

			_macrosList.Add(TestMacrosGenerator.GetMacros(1));
			_macrosList.Add(TestMacrosGenerator.GetMacros(2));
			_macrosList.Add(TestMacrosGenerator.GetMacros(3));
			_macrosList.Add(TestMacrosGenerator.GetMacros(4));
			RefreshListBox();
		}

		/// <summary>
		/// Обновить список макросов
		/// </summary>
		private void RefreshListBox()
		{
			MacrosListBox.Items.Clear();
			if (_macrosList.Capacity != 0)
			{
				foreach (var macros in _macrosList)
				{
					MacrosListBox.Items.Add(macros.Name);
				}
			}
		}

		private void MacroFisherForm_Load(object sender, EventArgs e)
		{
			#region Отслеживание нажатий 2

			//globalKeyboardHookALT.HookedKeys.Add(Keys.LMenu);
			//globalKeyboardHookCTRL.HookedKeys.Add(Keys.LControlKey);

			//globalKeyboardHookALT.KeyDown += AltPressed;
			//globalKeyboardHookALT.KeyUp += AltNotPressed;

			//globalKeyboardHookCTRL.KeyDown += CtrlPressed;
			//globalKeyboardHookCTRL.KeyUp += CtrlNotPressed;

			//keyboardScaner = new Thread(Start);

			#endregion
		}

		#endregion
		
		/// <summary>
		/// Начать выполнение выбранного макроса
		/// </summary>
		private void StartButton_Click(object sender, EventArgs e)
		{
			#region Имитация нажатий через 5 сек

			#region шпаргалка

			//ссылка на коды клавиш
			//https://docs.microsoft.com/ru-ru/windows/desktop/inputdev/virtual-key-codes
			//SendKeys.Send("");
			//шпаргалка
			//keybd_event((byte)VkKeyScan('D')/*D*/, 1/*???*/, KEYEVENTF_KEYUP, 0);
			//System.Threading.Thread.Sleep(5000);
			//keybd_event(0x44/*D*/, 1/*???*/, KEYEVENTF_EXTENDEDKEY, 0);
			//System.Threading.Thread.Sleep(1000);
			//keybd_event(0x44/*D*/, 1/*???*/, KEYEVENTF_KEYUP, 0);

			#endregion

			if (_currentMacros == null)
			{
				pickMacrosErrorLabel.Visible = true;
				return;
			}

			if (string.IsNullOrWhiteSpace(startSecTextBox.Text))
			{
				_secondsBeforeStart = 0;
			}
			else
			{
				_secondsBeforeStart = int.Parse(startSecTextBox.Text);
			}
			Thread.Sleep(_secondsBeforeStart * Command.MicroConvert);

			RunMacros(_currentMacros);

			#endregion

			#region Отслеживание нажатий

			//keyboardScaner.Start();

			#endregion
		}
		
		#region Отслеживание нажатий 3

		//private void Start()
		//{
		//	while (true)
		//	{
		//		if (IsCtrlPressed && IsAltPressed && !IsActivated)
		//		{
		//			loger.Text = "Activated";
		//			IsActivated = true;
		//			keybd_event(0x44/*D*/, 1/*???*/, KEYEVENTF_EXTENDEDKEY, 0);
		//		}
		//		else if (IsCtrlPressed && IsAltPressed && IsActivated)
		//		{
		//			loger.Text = "Deactivated";
		//			IsActivated = false;
		//			keybd_event(0x44/*A*/, 1/*???*/, KEYEVENTF_KEYUP, 0);
		//		}
		//	}
		//}

		//private void AltPressed(object sender, KeyEventArgs e)
		//{
		//	IsAltPressed = true;
		//	e.Handled = true;
		//}

		//private void CtrlPressed(object sender, KeyEventArgs e)
		//{
		//	IsCtrlPressed = true;
		//	e.Handled = true;
		//}

		//private void AltNotPressed(object sender, KeyEventArgs e)
		//{
		//	IsAltPressed = false;
		//	e.Handled = true;
		//}

		//private void CtrlNotPressed(object sender, KeyEventArgs e)
		//{
		//	IsCtrlPressed = false;
		//	e.Handled = true;
		//}

		//private void Form1_Shown(object sender, EventArgs e)
		//{
		//	while (true)
		//	{
		//		if (IsAltPressed && !IsActivated)
		//		{
		//			loger.Text = "Activated";
		//			IsActivated = true;
		//			Start();
		//		}
		//		else if (IsAltPressed && IsActivated)
		//		{
		//			loger.Text = "Deactivated";
		//			IsActivated = false;
		//		}
		//	}
		//}

		#endregion

		/// <summary>
		/// Событие закрытия формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MacroFisherForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//Properties.Settings.Default.Save();
			//Properties.Settings.Default.Upgrade();
			//MessageBox.Show("Saved Settings");
		}

		/// <summary>
		/// Событие смены выбора в листбоксе
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MacrosListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (var macros in _macrosList)
			{
				if (MacrosListBox.SelectedItem != null)
				{
					if (macros.Name == MacrosListBox.SelectedItem.ToString())
					{
						_currentMacros = macros;
						currentMacrosName.Text = macros.Name;
						pickMacrosErrorLabel.Visible = false;
						break;
					}
				}
				else
				{
					currentMacrosName.Text = "Макрос не выбран";
				}
			}
		}

		/// <summary>
		/// Удалить макрос
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteMacrosButton_Click(object sender, EventArgs e)
		{
			foreach (var macros in _macrosList)
			{
				if (macros.Name == MacrosListBox.SelectedItem.ToString())
				{
					MacrosListBox.Items.RemoveAt(MacrosListBox.SelectedIndex);
					_macrosList.Remove(macros);
					_currentMacros = null;
					break;
				}
			}
		}

		/// <summary>
		/// Добавить новый макрос
		/// </summary>
		private void AddMacroButton_Click(object sender, EventArgs e)
		{
			_macrosRedactorForm = new MacrosRedactorForm();

			if (_macrosRedactorForm.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			_macrosList.Add(_macrosRedactorForm.Macros);
			RefreshListBox();
		}

		/// <summary>
		/// Выполнить макрос
		/// </summary>
		/// <param name="macros">Макрос</param>
		private void RunMacros(Macros macros)
		{
			foreach (Command command in macros)
			{
				MouseControler.Move(100, 100);
				if (command.Key == 0x01)
				{
					MouseControler.LeftClick();
					Thread.Sleep(command.MicrosecondsPausedAfter);
					Thread.Sleep(random.Next(command.PauseRandomMin, command.PauseRandomMax));
				}
				else
				{
					keybd_event(command.Key /*клавиша*/, 1 /*???*/, KEYEVENTF_EXTENDEDKEY,
						0);

					Thread.Sleep(command.MicrosecondsPressed);

					Thread.Sleep(random.Next(command.PressedRandomMin,
						command.PressedRandomMax));

					keybd_event(command.Key /*клавиша*/, 1 /*???*/, KEYEVENTF_KEYUP, 0);

					Thread.Sleep(command.MicrosecondsPausedAfter);

					Thread.Sleep(random.Next(command.PauseRandomMin,
						command.PauseRandomMax));
				}
				MouseControler.Move(500, 500);
			}
		}

		/// <summary>
		/// Повторить макрос X раз
		/// </summary>
		/// <param name="macros">Макрос</param>
		/// <param name="X">Количество повторений</param>
		private void RepeatMacrosXTimes(Macros macros, int X)
		{
			for (int i = 0; i < X; i++)
			{
				RunMacros(macros);
			}
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
		/// Повторить макрос
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void repeatMacrosButton_Click(object sender, EventArgs e)
		{
			if (_currentMacros == null)
			{
				pickMacrosErrorLabel.Visible = true;
				return;
			}

			if (string.IsNullOrWhiteSpace(startSecTextBox.Text))
			{
				_secondsBeforeStart = 0;
			}
			else
			{
				_secondsBeforeStart = int.Parse(startSecTextBox.Text);
			}
			if (string.IsNullOrWhiteSpace(NTextBox.Text))
			{
				_timesToRepeat = 1;
			}
			else
			{
				_timesToRepeat = int.Parse(NTextBox.Text);
			}

			Thread.Sleep(_secondsBeforeStart * Command.MicroConvert);

			RepeatMacrosXTimes(_currentMacros, _timesToRepeat * Command.MicroConvert);
		}
	}
}
