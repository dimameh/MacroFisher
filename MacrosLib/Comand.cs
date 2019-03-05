namespace MacroFisher.MacrosLib
{
    public abstract class Command : IMacrosNode
    {
        #region Constants

        protected const int _microConvert = 1000;

        #endregion

        #region Ordinary fields

        protected double _holdMax;

        protected double _holdMin;

        protected double _pauseMax;

        protected double _pauseMin;

        #endregion

        #region Properties

        public string Key { get; }

        #endregion

        #region Constructor

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="key"> Название клавиши </param>
        protected Command(string key)
        {
            Key = key;
        }

        #endregion

        #region Public methods

        #region Implementation of IMacrosNode

        public abstract int Id { get; set; }

        /// <summary>
        ///     Выполнить команду
        /// </summary>
        public abstract void RunNode();

        #endregion

        #endregion
    }
}