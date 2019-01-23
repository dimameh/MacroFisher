using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroFisher.Tools
{
	class MouseControler
	{
		[DllImport("user32.dll", EntryPoint = "SendInput", SetLastError = true)]
		static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

		[DllImport("user32.dll", EntryPoint = "GetMessageExtraInfo", SetLastError = true)]
		static extern IntPtr GetMessageExtraInfo();
		
		[Flags()]
		private enum MOUSEEVENTF
		{
			MOVE = 0x0001,  // mouse move 
			LEFTDOWN = 0x0002,  // left button down
			LEFTUP = 0x0004,  // left button up
			RIGHTDOWN = 0x0008,  // right button down
			RIGHTUP = 0x0010,  // right button up
			MIDDLEDOWN = 0x0020,  // middle button down
			MIDDLEUP = 0x0040,  // middle button up
			XDOWN = 0x0080,  // x button down 
			XUP = 0x0100,  // x button down
			WHEEL = 0x0800,  // wheel button rolled
			VIRTUALDESK = 0x4000,  // map to entire virtual desktop
			ABSOLUTE = 0x8000,  // absolute move
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
			[FieldOffset(0)]
			public int type;
			[FieldOffset(4)]
			public MOUSEINPUT mi;
		}

		/// <summary>
		/// Передвигает курсор в координаты X:Y экрана
		/// </summary>
		/// <param name="x">X координата позиции в пикселях</param>
		/// <param name="y">Y координата позиции в пикселях</param>
		/// <returns>При ошибке - 0, в другом случае - 1.</returns>
		public static uint Move(int x, int y)
		{
			// Bildschirm Auflösung
			float ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
			float ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

			INPUT input_move = new INPUT();
			input_move.mi.dx = (int)Math.Round(x * (65535 / ScreenWidth), 0);
			input_move.mi.dy = (int)Math.Round(y * (65535 / ScreenHeight), 0);
			input_move.mi.mouseData = 0;
			input_move.mi.dwFlags = (int)(MOUSEEVENTF.MOVE | MOUSEEVENTF.ABSOLUTE);

			INPUT[] input = { input_move };
			return SendInput(1, input, Marshal.SizeOf(input_move));
		}

		/// <summary>
		/// Симулирует нажатие мыши в месте нахождения курсора
		/// </summary>
		/// <returns>Все кроме 2 - ошибка.</returns>
		public static uint LeftClick()
		{
			INPUT input_down = new INPUT();
			input_down.mi.dx = 0;
			input_down.mi.dy = 0;
			input_down.mi.mouseData = 0;
			input_down.mi.dwFlags = (int)MOUSEEVENTF.LEFTDOWN;

			INPUT input_up = input_down;
			input_up.mi.dwFlags = (int)MOUSEEVENTF.LEFTUP;

			INPUT[] input = { input_down, input_up };
			return SendInput(2, input, Marshal.SizeOf(input_down));
		}
	}
}
