using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using AutoIt;
using MacroFisher.Tools;
using System.Windows.Media.Media3D;

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

			_macrosList.Add(TestMacrosGenerator.GetMacros("test1"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("test2"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("test3"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("test4"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("testU"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Комариное Караси"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Острог Караси"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Комариное Караси SPEED"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Острог Караси FAST"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Острог Угри Мост"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Спининг Белая"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Фидер Белая Стерлядь"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Копать"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("Еда+Чай"));
			_macrosList.Add(TestMacrosGenerator.GetMacros("LKM"));
			RefreshListBox();
		}

		private Macros GenerateRandMenuMacros()
		{
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				return inv;
			}

			return null;
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
			_secondsBeforeStart = string.IsNullOrWhiteSpace(startSecTextBox.Text) ? 0 : int.Parse(startSecTextBox.Text);

			Thread.Sleep(_secondsBeforeStart * Command.MicroConvert * 10);

			switch (_currentMacros.Name)
			{
				case "Фидер Комариное Караси":
					RunFiderKomarinoeMacros();
					return;
				case "Фидер Острог Караси":
					RunFiderOstrogMacros();
					return;
				case "Копать":
					RunKopatMacros();
					return;
				default:
					RunMacros(_currentMacros);

					#region Отслеживание нажатий

					//keyboardScaner.Start();

					#endregion

					break;
			}

			//#region TEST

			//Camera Cam = new MatrixCamera(); // камера
			//float maxY; // ограничение по оси Y
			//float speed; //скорость перемещения камеры

			//Cam.transform.position = new Vector3(transform.position.x,
			//		transform.position.y - speed, transform.position.z);

			//if (Cam.transform.position.y < maxY) // ограничение по оси Y
			//{
			//	Cam.transform.position = new Vector3(transform.position.x, maxY,transform.position.z);
			//}




			//#endregion


			Camera cam = new MatrixCamera();
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
				//if (command.StrKey == "RightClick")
				//{
				//	if (command.SecondsPressed == 0)
				//	{
				//		AutoItX.MouseClick("RIGHT");
				//		Thread.Sleep(command.SecondsPausedAfter);
				//		Thread.Sleep(random.Next(command.PauseRandomMin,
				//			command.PauseRandomMax + 1));
				//	}
				//	else
				//	{
				//		MouseControler.RightHoldXSeconds(command.SecondsPressed);
				//		Thread.Sleep(command.SecondsPausedAfter);
				//		Thread.Sleep(random.Next(command.PauseRandomMin,
				//			command.PauseRandomMax + 1));
				//	}
				//}
				//else if (command.StrKey == "MouseMove")
				//{
				//	AutoItX.MouseMove(command.SecondsPressed, command.SecondsPausedAfter);
				//}
				//else if (command.StrKey == "LeftCick")
				//{
				//	if (command.SecondsPressed == 0)
				//	{
				//		AutoItX.MouseClick("LEFT");
				//		Thread.Sleep(command.SecondsPausedAfter);
				//		Thread.Sleep(random.Next(command.PauseRandomMin,
				//			command.PauseRandomMax + 1));
				//	}
				//	else
				//	{
				//		MouseControler.LeftHoldXSeconds(command.SecondsPressed);
				//		Thread.Sleep(command.SecondsPausedAfter);
				//		Thread.Sleep(random.Next(command.PauseRandomMin,
				//			command.PauseRandomMax + 1));
				//	}
				//}
				//else if (command.StrKey == "WheelUp")
				//{
				//	AutoItX.MouseWheel("up", random.Next(command.PressedRandomMin/ 100, command.PressedRandomMax/100));
				//	Thread.Sleep(command.SecondsPausedAfter);
				//	Thread.Sleep(random.Next(command.PauseRandomMin,
				//		command.PauseRandomMax + 1));
				//}
				//else if (command.StrKey == "WheelDown")
				//{
				//	AutoItX.MouseWheel("down", random.Next(command.PressedRandomMin / 100, command.PressedRandomMax / 100));
				//	Thread.Sleep(command.SecondsPausedAfter);
				//	Thread.Sleep(random.Next(command.PauseRandomMin,
				//		command.PauseRandomMax + 1));
				//}

				//ПКМ
				if (command.Key == 0x02)
				{
					if (command.SecondsPressed == 0)
					{
						AutoItX.MouseClick("RIGHT");
						Thread.Sleep(command.SecondsPausedAfter);
						Thread.Sleep(random.Next(command.PauseRandomMin,
							command.PauseRandomMax + 1));
					}
					else
					{
						MouseControler.RightHoldXSeconds(command.SecondsPressed);
						Thread.Sleep(command.SecondsPausedAfter);
						Thread.Sleep(random.Next(command.PauseRandomMin,
							command.PauseRandomMax + 1));
					}
				}
				//Двинуть мышь
				else if (command.Key == 0x03)
				{
					AutoItX.MouseMove(command.SecondsPressed/100, command.SecondsPausedAfter/100, 50);
				}
				//ЛКМ
				else if (command.Key == 0x01)
				{
					if (command.SecondsPressed == 0)
					{
						AutoItX.MouseClick("LEFT");
						Thread.Sleep(command.SecondsPausedAfter/100);
						Thread.Sleep(random.Next(command.PauseRandomMin,
							command.PauseRandomMax + 1));
					}
					else
					{
						MouseControler.LeftHoldXSeconds(command.SecondsPressed);
						Thread.Sleep(command.SecondsPausedAfter);
						Thread.Sleep(random.Next(command.PauseRandomMin,
							command.PauseRandomMax + 1));
					}
				}
				else if (command.StrKey == "WheelUp")
				{
					AutoItX.MouseWheel("up", random.Next(command.PressedRandomMin / 100, command.PressedRandomMax / 100));
					Thread.Sleep(command.SecondsPausedAfter);
					Thread.Sleep(random.Next(command.PauseRandomMin,
						command.PauseRandomMax + 1));
				}
				else if (command.StrKey == "WheelDown")
				{
					AutoItX.MouseWheel("down", random.Next(command.PressedRandomMin / 100, command.PressedRandomMax / 100));
					Thread.Sleep(command.SecondsPausedAfter);
					Thread.Sleep(random.Next(command.PauseRandomMin,
						command.PauseRandomMax + 1));
				}
				else
				{
					keybd_event(command.Key /*клавиша*/, 1 /*???*/, KEYEVENTF_EXTENDEDKEY,
						0);

					Thread.Sleep(command.SecondsPressed);

					Thread.Sleep(random.Next(command.PressedRandomMin,
						command.PressedRandomMax + 1));

					keybd_event(command.Key /*клавиша*/, 1 /*???*/, KEYEVENTF_KEYUP, 0);

					Thread.Sleep(command.SecondsPausedAfter);

					Thread.Sleep(random.Next(command.PauseRandomMin,
						command.PauseRandomMax + 1));
				}
			}
		}

		/// <summary>
		/// Повторить макрос X раз
		/// </summary>
		/// <param name="macros">Макрос</param>
		/// <param name="X">Количество повторений</param>
		private void RepeatMacrosXTimes(Macros macros, int X)
		{
			if (macros.Name == "Фидер Комариное Караси")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderKomarinoeMacros();
				}

				return;
			}
			if (macros.Name == "Фидер Острог Караси")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderOstrogMacros();
				}

				return;
			}
			if (macros.Name == "Копать")
			{
				int counter = 0;
				while (counter < X)
				{
					//int rand = random.Next(2, 5);
					//for (int i = 0; i < 1; i++)
					//{
						RunKopatMacros();
						counter++;
					//}

					//RunMacros(TestMacrosGenerator.GetMacros("Еда+Чай"));
				}
				return;
			}
			if (macros.Name == "Спининг Белая")
			{
				for (int i = 0; i < X; i++)
				{
					RunSpiningBeloeMacros();
				}

				return;
			}
			if (macros.Name == "Фидер Острог Угри Мост")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderOstrogUgriMostMacros();
				}

				return;
			}
			if (macros.Name == "Фидер Комариное Караси SPEED")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderKomarinoeSPEEDMacros();
				}

				return;
			}
			if (macros.Name == "Фидер Белая Стерлядь")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderBelayaSterlyadMacros();
				}

				return;
			}
			if(macros.Name == "Фидер Острог Караси FAST")
			{
				for (int i = 0; i < X; i++)
				{
					RunFiderOstrogSPEEDMacros();
				}

				return;
			}
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

			Thread.Sleep(_secondsBeforeStart * Command.MicroConvert*10);

			RepeatMacrosXTimes(_currentMacros, _timesToRepeat);
		}

		/// <summary>
		/// Запуск ловли на фидер на комарином с обманками
		/// </summary>
		private void RunFiderKomarinoeMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Комариное Караси"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 120) * 100);
			}

		}

		/// <summary>
		/// Запуск ловли на фидер на комарином с обманками
		/// </summary>
		private void RunFiderKomarinoeSPEEDMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Комариное Караси SPEED"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 60) * 100);
			}

		}

		/// <summary>
		/// Запуск ловли на фидер на комарином с обманками
		/// </summary>
		private void RunFiderOstrogMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Острог Караси"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 120) * 100);
			}

		}

		private void RunFiderOstrogSPEEDMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Острог Караси FAST"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 70);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 70);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 70);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 50) * 100);
			}

		}
		
		private void RunFiderOstrogUgriMostMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Острог Угри Мост"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 10)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 120) * 100);
			}

			Thread.Sleep(random.Next(1200, 2400) * 100);
		}

		private void RunFiderBelayaSterlyadMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Фидер Белая Стерлядь"));
			Macros inv = new Macros("Садок");
			int ver = random.Next(0, 100);
			if (ver <= 20)
			{
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			else
			{
				Thread.Sleep(random.Next(30, 120) * 100);
			}

			Thread.Sleep(random.Next(1200, 2400) * 100);
		}

		private void RunKopatMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Копать"));
			
			int ver = random.Next(0, 100);
			if (ver <= 10)
			{
				Macros inv = new Macros("МеждуКопками");
				int ver2 = random.Next(1, 5);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('w', 0, 0, 20, 80, 10, 20);
						break;
					case 2:
						inv.AddCommand('a', 0, 0, 20, 80, 10, 20);
						break;
					case 3:
						inv.AddCommand('s', 0, 0, 20, 80, 10, 20);
						break;
					case 4:
						inv.AddCommand('d', 0, 0, 20, 80, 10, 20);
						break;
				}

				RunMacros(inv);
			}
		}

		private void RunSpiningBeloeMacros()
		{
			RunMacros(TestMacrosGenerator.GetMacros("Спининг Белая"));
			int ver = random.Next(0, 100);
			if (ver <= 10)
			{
				Macros inv = new Macros("Садок");
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('i', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('i', 0, 0, 3, 7, 5, 10);
						break;
					case 2:
						inv.AddCommand('o', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('o', 0, 0, 3, 7, 5, 10);
						break;
					case 3:
						inv.AddCommand('c', 0, 0, 3, 7, 50, 100);
						inv.AddCommand('c', 0, 0, 3, 7, 5, 10);
						break;
				}

				RunMacros(inv);
			}
			if (ver <= 20 && ver > 10)
			{
				Macros inv = new Macros("МеждуБроскамиХодить");
				int ver2 = random.Next(1, 4);
				switch (ver2)
				{
					case 1:
						inv.AddCommand('w', 0, 0, 12, 30, 10, 20);
						break;
					case 2:
						inv.AddCommand('a', 0, 0, 10, 20, 10, 20);
						break;
					case 3:
						inv.AddCommand('d', 0, 0, 10, 20, 10, 20);
						break;
				}

				RunMacros(inv);
			}

		}
	}
}
