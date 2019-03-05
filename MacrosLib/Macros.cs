using System;
using System.Collections;
using System.Collections.Generic;

namespace MacroFisher.MacrosLib
{
    public class Macros : IEnumerable, IMacrosNode
    {
        #region Readonly fields

        /// <summary>
        ///     Список команд макроса
        /// </summary>
        private readonly List<IMacrosNode> _macrosNodeList = new List<IMacrosNode>();

        #endregion

        #region Properties

        /// <summary>
        ///     Название макроса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Возвращает true если хранимый список пустой
        /// </summary>
        public bool IsEmpty => _macrosNodeList.Count == 0;

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="name"></param>
        public Macros(string name)
        {
            Name = name;
        }

        /// <summary>
        ///     Конструктор копирования
        /// </summary>
        /// <param name="macros"></param>
        public Macros(Macros macros)
        {
            Name = macros.Name;
            foreach (IMacrosNode com in macros)
            {
                AddCommand(com);
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Генерация id для элементов списка
        /// </summary>
        /// <returns></returns>
        private int GenerateId()
        {
            for (var i = 0; i < _macrosNodeList.Capacity + 1; i++)
            {
                var isIdFree = true;
                foreach (var macros in _macrosNodeList)
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
        ///     Добавить команду
        /// </summary>
        public void AddCommand(IMacrosNode command)
        {
            command.Id = GenerateId();
            _macrosNodeList.Add(command);
        }

        /// <summary>
        ///     Удалить макрос
        /// </summary>
        /// <param name="id">id макроса</param>
        public void RemoveCommand(int id)
        {
            foreach (var macros in _macrosNodeList)
            {
                if (macros.Id == id)
                {
                    _macrosNodeList.Remove(macros);
                }
            }
        }

        public void RemoveAt(int index)
        {
            _macrosNodeList.RemoveAt(index);
        }

        #region Implementation of IEnumerable

        public IEnumerator GetEnumerator()
        {
            return _macrosNodeList.GetEnumerator();
        }

        #endregion

        #endregion

        #region Implementation of IMacrosNode

        /// <summary>
        ///     Id макроса
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        ///     Запуск всех элементов макроса
        /// </summary>
        public void RunNode()
        {
            foreach (var macrosNode in _macrosNodeList)
            {
                macrosNode.RunNode();
            }
        }

        #endregion
    }
}