using System;

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

		#endregion

		#region Properties

		public int Id { get; }

		public char Key { get; }

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

		public PressType Type { get; set; }

		#endregion

		#region Constructor

		/// <summary>
		///     Конструктор
		/// </summary>
		/// <param name="keyChar">Символ</param>
		/// <param name="pressed">Сколько секунд нажимать на него</param>
		/// <param name="paused">Сколько секунд после этого ничего не делать</param>
		/// <param name="id">ID макроса в списке для поиска</param>
		public Command(char keyChar, int pressed, int paused, int id, PressType pressType)
		{
			Key = keyChar;
			MicrosecondsPressed = pressed;
			MicrosecondsPausedAfter = paused;
			Id = id;
			Type = pressType;
		}

		#endregion
	}
}