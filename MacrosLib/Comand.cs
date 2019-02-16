using System;
using System.Runtime.InteropServices;

namespace MacroFisher
{
	public class Command //TODO: переписать с наследованием отдельно для мыши, отдельно для клавиатуры
	{
		#region Constants

		public const int MicroConvert = 100;

		#endregion

		#region Private fields

		private int _secondsPausedAfter;
		private int _secondsPressed;
		private int _pressedRandomMin;
		private int _pressedRandomMax;
		private int _pauseRandomMin;
		private int _pauseRandomMax;

		#endregion

		#region Properties 

		public int Id { get; set; }

		public byte Key { get; }
		
		public string StrKey { get; }

		public int SecondsPressed
		{
			get => _secondsPressed;
			private set
			{
				if (value > 3600)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
				}

				_secondsPressed = value * MicroConvert;
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

				_pressedRandomMin = value * MicroConvert;
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

				_pressedRandomMax = value * MicroConvert;
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

				_pauseRandomMin = value * MicroConvert;
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

				_pauseRandomMax = value * MicroConvert;
			}
		}

		public int SecondsPausedAfter
		{
			get => _secondsPausedAfter;
			private set
			{
				if (value > 86400)
				{
					throw new ArgumentOutOfRangeException(
						"Слишком долгое время нажатия. Максимальная длина нажатия: 86400 секунд (24 часа).");
				}

				_secondsPausedAfter = value * MicroConvert;
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
			SecondsPressed = pressed;
			SecondsPausedAfter = paused;
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
			SecondsPressed = pressed;
			SecondsPausedAfter = paused;
			Id = id;

			PressedRandomMin = pressRandMin;
			PressedRandomMax = pressRandMax;
			PauseRandomMin = pauseRandMin;
			PauseRandomMax = pauseRandMax;
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		public Command(string keyString, int pressed, int paused, int pressRandMin, int pressRandMax, int pauseRandMin, int pauseRandMax, int id = 0)
		{
			StrKey = keyString;
			SecondsPressed = pressed;
			SecondsPausedAfter = paused;
			Id = id;

			PressedRandomMin = pressRandMin;
			PressedRandomMax = pressRandMax;
			PauseRandomMin = pauseRandMin;
			PauseRandomMax = pauseRandMax;
		}
		#endregion
	}
}