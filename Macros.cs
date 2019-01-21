using System;
using System.Collections.Generic;

namespace MacroFisher
{
	internal class Macros
	{
		#region Nested class

		private class Command
		{
			#region Constants

			private const int _microConvert = 1000;

			#endregion

			#region Private fields

			private int _secondsPauseAfter;
			private int _secondsPressed;

			#endregion

			#region Properties

			public int Id { get; }

			private char Key { get; }

			private int SecondsPressed
			{
				get => _secondsPressed;
				set
				{
					if (value > 3600)
					{
						throw new ArgumentOutOfRangeException(
							"Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
					}

					_secondsPressed = value * _microConvert;
				}
			}

			private int SecondsPauseAfter
			{
				get => _secondsPauseAfter;
				set
				{
					if (value > 86400)
					{
						throw new ArgumentOutOfRangeException(
							"Слишком долгое время нажатия. Максимальная длина нажатия: 86400 секунд (24 часа).");
					}

					_secondsPauseAfter = value * _microConvert;
				}
			}

			#endregion

			#region Constructor

			/// <summary>
			///     Конструктор
			/// </summary>
			/// <param name="keyChar">Символ</param>
			/// <param name="pressed">Сколько секунд нажимать на него</param>
			/// <param name="paused">Сколько секунд после этого ничего не делать</param>
			/// <param name="id">ID макроса в списке для поиска</param>
			public Command(char keyChar, int pressed, int paused, int id)
			{
				Key = keyChar;
				SecondsPressed = pressed;
				SecondsPauseAfter = paused;
				Id = id;
			}

			#endregion
		}

		#endregion

		#region Readonly fields

		/// <summary>
		/// Список команд макроса
		/// </summary>
		private readonly List<Command> _macrosList = new List<Command>();

		#endregion

		#region Properties

		/// <summary>
		/// Название макроса
		/// </summary>
		public string Name { get; set; }

		#endregion

		#region Private methods

		private int GenerateId()
		{
			bool isIdFree;

			for (var i = 0; i < _macrosList.Capacity; i++)
			{
				isIdFree = true;
				foreach (var macros in _macrosList)
				{
					if (i == macros.Id)
					{
						isIdFree = false;
						break;
					}
				}

				if (isIdFree)
				{
					return i;
				}
			}

			throw new Exception("Ошибка в генерации ID для макроса. Нет свободных ID");
		}

		#endregion

		#region Public methods

		/// <summary>
		///     Добавить макрос
		/// </summary>
		/// <param name="keyChar">Символ</param>
		/// <param name="pressed">Сколько секунд нажимать на него</param>
		/// <param name="paused">Сколько секунд после этого ничего не делать</param>
		public void AddCommand(char keyChar, int pressed, int paused)
		{
			_macrosList.Add(new Command(keyChar, pressed, paused, GenerateId()));
		}

		/// <summary>
		///     Удалить макрос
		/// </summary>
		/// <param name="id">id макроса</param>
		public void RemoveCommand(int id)
		{
			foreach (var macros in _macrosList)
			{
				if (macros.Id == id)
				{
					_macrosList.Remove(macros);
				}
			}
		}

		#endregion
	}
}