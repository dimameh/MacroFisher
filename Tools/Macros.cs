using System;
using System.Collections;
using System.Collections.Generic;

namespace MacroFisher
{
	public class Macros : IEnumerable
	{
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

			for (var i = 0; i < _macrosList.Capacity+1; i++)
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
		/// <param name="secondsPressed">Сколько секунд нажимать на него</param>
		/// <param name="secondsPaused">Сколько секунд после этого ничего не делать</param>
		/// <param name="pressType">Тип нажатия (Hold/Press)</param>
		public void AddCommand(char keyChar, int secondsPressed, int secondsPaused, PressType pressType)
		{
			if (pressType == PressType.Hold)
			{
				_macrosList.Add(new Command(keyChar, secondsPressed, secondsPaused,
					GenerateId(), pressType));
			}
			else
			{
				_macrosList.Add(new Command(keyChar, 0, secondsPaused,
					GenerateId(), pressType));
			}
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

		#region Implementation of IEnumerable

		public IEnumerator GetEnumerator()
		{
			return _macrosList.GetEnumerator();
		}

		#endregion
	}
}