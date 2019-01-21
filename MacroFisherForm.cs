﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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

		/// <summary>
		/// Перевод символа в кейкод
		/// </summary>
		/// <param name="ch">символ</param>
		/// <returns></returns>
		[DllImport("user32.dll")] static extern short VkKeyScan(char ch);

		//зажать
		const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
		//отпустить
		const uint KEYEVENTF_KEYUP = 0x0002;
		#endregion

		//TODO: Добавить галочку при добавлении макрокнопки использовать рандом или нет.

		public MacroFisherForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
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

		private void StartButton_Click(object sender, EventArgs e)
		{
			#region Имитация нажатий через 5 сек
			//ссылка на коды клавиш
			//https://docs.microsoft.com/ru-ru/windows/desktop/inputdev/virtual-key-codes
			//SendKeys.Send("");

			MacrosListBox.Items.Add(VkKeyScan('D'));
			System.Threading.Thread.Sleep(5000);
			keybd_event((byte)VkKeyScan('D')/*D*/, 1/*???*/, KEYEVENTF_EXTENDEDKEY, 0);
			System.Threading.Thread.Sleep(1000);
			keybd_event((byte)VkKeyScan('D')/*D*/, 1/*???*/, KEYEVENTF_KEYUP, 0);



			//System.Threading.Thread.Sleep(5000);
			//keybd_event(0x44/*D*/, 1/*???*/, KEYEVENTF_EXTENDEDKEY, 0);
			//System.Threading.Thread.Sleep(1000);
			//keybd_event(0x44/*D*/, 1/*???*/, KEYEVENTF_KEYUP, 0);

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
	}
}