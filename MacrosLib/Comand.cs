using System;
using System.Runtime.InteropServices;

namespace MacroFisher
{
	public class Command
	{
		#region Constants

		private const int _microConvert = 1000;

		#endregion

		#region Private fields

		private int _microsecondsPausedAfter;
		private int _microsecondsPressed;
		private int _pressedRandomMin;
		private int _pressedRandomMax;
		private int _pauseRandomMin;
		private int _pauseRandomMax;

		#endregion

		#region Properties

		public int Id { get; set; }

		public byte Key { get; }

		public int MicrosecondsPressed
		{
			get => _microsecondsPressed;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_microsecondsPressed = value * _microConvert;
			}
		}

		public int PressedRandomMin
		{
			get => _pressedRandomMin;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_pressedRandomMin = value * _microConvert;
			}
		}

		public int PressedRandomMax
		{
			get => _pressedRandomMax;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_pressedRandomMax = value * _microConvert;
			}
		}

		public int PauseRandomMin
		{
			get => _pauseRandomMin;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_pauseRandomMin = value * _microConvert;
			}
		}

		public int PauseRandomMax
		{
			get => _pauseRandomMax;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_pauseRandomMax = value * _microConvert;
			}
		}

		public int MicrosecondsPausedAfter
		{
			get => _microsecondsPausedAfter;
			private set
			{
				if (value > 86400)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 86400 секунд (24 часа).");
				}

				_microsecondsPausedAfter = value * _microConvert;
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Перевод символа в кейкод
		/// </summary>
		/// <param name="ch">символ</param>
		/// <returns></returns>
		[DllImport("user32.dll")] static extern short VkKeyScan(char ch);

		/// <summary>
		///     Конструктор
		/// </summary>
		/// <param name="keyChar">Символ</param>
		/// <param name="pressed">Сколько секунд нажимать на него</param>
		/// <param name="paused">Сколько секунд после этого ничего не делать</param>
		/// <param name="id">ID макроса в списке для поиска</param>
		public Command(char keyChar, int pressed, int paused, int pressRandMin, int pressRandMax, int pauseRandMin, int pauseRandMax, int id = 0)
		{
			Key = (byte)VkKeyScan(keyChar);
			MicrosecondsPressed = pressed;
			MicrosecondsPausedAfter = paused;
			Id = id;

			PressedRandomMin = pressRandMin;
			PressedRandomMax = pressRandMax;
			PauseRandomMin = pauseRandMin;
			PauseRandomMax = pauseRandMax;
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public Command(byte keyChar, int pressed, int paused, int pressRandMin, int pressRandMax, int pauseRandMin, int pauseRandMax, int id = 0)
		{
			Key = keyChar;
			MicrosecondsPressed = pressed;
			MicrosecondsPausedAfter = paused;
			Id = id;

			PressedRandomMin = pressRandMin;
			PressedRandomMax = pressRandMax;
			PauseRandomMin = pauseRandMin;
			PauseRandomMax = pauseRandMax;
		}

		#endregion
	}
}