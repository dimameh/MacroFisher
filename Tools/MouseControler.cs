using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoIt;

namespace MacroFisher.Tools
{
	class MouseControler
	{
		[DllImport("user32.dll", EntryPoint = "SendInput", SetLastError = true)]
		static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

		[DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo", SetLastError = true)]
		static extern IntPtr GetMessageExtraInfo();

		[DllImport("user32.dll")]
		static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
			int dwExtraInfo);

		[Flags()]
		private enum MOUSEEVENTF
		{
			MOVE = 0x0001, // mouse move 
			LEFTDOWN = 0x0002, // left button down
			LEFTUP = 0x0004, // left button up
			RIGHTDOWN = 0x0008, // right button down
			RIGHTUP = 0x0010, // right button up
			MIDDLEDOWN = 0x0020, // middle button down
			MIDDLEUP = 0x0040, // middle button up
			XDOWN = 0x0080, // x button down 
			XUP = 0x0100, // x button down
			WHEEL = 0x0800, // wheel button rolled
			VIRTUALDESK = 0x4000, // map to entire virtual desktop
			ABSOLUTE = 0x8000, // absolute move
			MOUSEEVENTF_WHEEL = 0x0800,
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct MOUSEINPUT
		{
			public int dx;
			public int dy;
			public int mouseData;
			public int dwFlags;
			public int time;
			public IntPtr dwExtraInfo;
		}

		[StructLayout(LayoutKind.Explicit)]
		private struct INPUT
		{
			[FieldOffset(0)] public int type;
			[FieldOffset(4)] public MOUSEINPUT mi;
		}

		/// <summary>
		/// Передвигает курсор в координаты X:Y экрана
		/// </summary>
		/// <param name="x">X координата позиции в пикселях</param>
		/// <param name="y">Y координата позиции в пикселях</param>
		/// <returns>При ошибке - 0, в другом случае - 1.</returns>
		//public static uint Move(int x, int y)
		//{
		//	// Bildschirm Auflösung
		//	float ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
		//	float ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

		//	INPUT input_move = new INPUT();
		//	input_move.mi.dx = (int)(x * (65535 / ScreenWidth));//(int)Math.Round(x * (65535 / ScreenWidth), 0);
		//	input_move.mi.dy = (int) (y * (65535 / ScreenHeight));//Math.Round(y * (65535 / ScreenHeight), 0);
		//	input_move.mi.mouseData = 0;
		//	input_move.mi.dwFlags = (int)(MOUSEEVENTF.MOVE | MOUSEEVENTF.ABSOLUTE);

		//	INPUT[] input = { input_move };
		//	return SendInput(1, input, Marshal.SizeOf(input_move));
		//}

		///// <summary>
		///// Передвигает курсор в координаты X:Y экрана
		///// </summary>
		///// <param name="x">X координата позиции в пикселях</param>
		///// <param name="y">Y координата позиции в пикселях</param>
		///// <returns>При ошибке - 0, в другом случае - 1.</returns>
		//public static void Move(int x, int y, int speed)
		//{
		//	AutoItX.MouseMove(x, y, speed);
		//}

		///// <summary>
		///// Симулирует нажатие мыши в месте нахождения курсора
		///// </summary>
		///// <returns>Все кроме 2 - ошибка.</returns>
		//public static void LeftClick()
		//{
		//	INPUT input_down = new INPUT();
		//	input_down.mi.dx = 0;
		//	input_down.mi.dy = 0;
		//	input_down.mi.mouseData = 0;
		//	input_down.mi.dwFlags = (int) MOUSEEVENTF.LEFTDOWN;

		//	INPUT input_up = input_down;
		//	input_up.mi.dwFlags = (int) MOUSEEVENTF.LEFTUP;

		//	INPUT[] input = {input_down, input_up};
		//	SendInput(2, input, Marshal.SizeOf(input_down));
		//	return;
		//}

		public static void LeftHoldXSeconds(int x)
		{
			INPUT input_down = new INPUT();
			input_down.mi.dx = 0;
			input_down.mi.dy = 0;
			input_down.mi.mouseData = 0;
			input_down.mi.dwFlags = (int) MOUSEEVENTF.LEFTDOWN;

			Thread.Sleep(x);

			INPUT input_up = input_down;
			input_up.mi.dwFlags = (int) MOUSEEVENTF.LEFTUP;

			INPUT[] input = {input_down, input_up};
			SendInput(2, input, Marshal.SizeOf(input_down));
			return;
		}

		///// <summary>
		///// Симулирует нажатие мыши в месте нахождения курсора
		///// </summary>
		///// <returns>Все кроме 2 - ошибка.</returns>
		//public static void RightClick()
		//{
		//	INPUT input_down = new INPUT();
		//	input_down.mi.dx = 0;
		//	input_down.mi.dy = 0;
		//	input_down.mi.mouseData = 0;
		//	input_down.mi.dwFlags = (int) MOUSEEVENTF.RIGHTDOWN;

		//	INPUT input_up = input_down;
		//	input_up.mi.dwFlags = (int) MOUSEEVENTF.RIGHTUP;

		//	INPUT[] input = {input_down, input_up};
		//	SendInput(2, input, Marshal.SizeOf(input_down));
		//	return;
		//}

		public static void RightHoldXSeconds(int x)
		{
			INPUT input_down = new INPUT();
			input_down.mi.dx = 0;
			input_down.mi.dy = 0;
			input_down.mi.mouseData = 0;
			input_down.mi.dwFlags = (int) MOUSEEVENTF.RIGHTDOWN;

			Thread.Sleep(x);

			INPUT input_up = input_down;
			input_up.mi.dwFlags = (int) MOUSEEVENTF.RIGHTUP;

			INPUT[] input = {input_down, input_up};
			SendInput(2, input, Marshal.SizeOf(input_down));
			return;
		}

		//public static uint WheelScroll()
		//{
		//	//INPUT wheelScroll = new INPUT();
		//	//wheelScroll.mi.dx = 500;
		//	//wheelScroll.mi.dy = 500;
		//	//wheelScroll.mi.mouseData = 0;
		//	//wheelScroll.mi.dwFlags = (int)MOUSEEVENTF.MIDDLEDOWN;
		//	//mouse_event(0x0800, 0, 0, 10 * 120, 0);
		//	//INPUT[] input = { wheelScroll };
		//	//return SendInput(1, input, Marshal.SizeOf(wheelScroll));
		//}
	}
}