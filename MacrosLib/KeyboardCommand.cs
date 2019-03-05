using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MacroFisher.MacrosLib
{
    internal class KeyboardCommand : Command
    {
        #region Properties

        /// <summary>
        ///     Минимальная пауза
        /// </summary>
        private double PauseMin
        {
            get => _pauseMin;
            set
            {
                if (value > 3600)
                {
                    throw new ArgumentOutOfRangeException(
                        "Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Время не может быть отрицательным");
                }

                _pauseMin = value * _microConvert;
            }
        }

        /// <summary>
        ///     Максимальная пауза
        /// </summary>
        private double PauseMax
        {
            get => _pauseMax;
            set
            {
                if (value > 3600)
                {
                    throw new ArgumentOutOfRangeException(
                        "Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Время не может быть отрицательным");
                }

                _pauseMax = value * _microConvert;
            }
        }

        /// <summary>
        ///     Минимальное время зажатия
        /// </summary>
        private double HoldMin
        {
            get => _holdMin;
            set
            {
                if (value > 3600)
                {
                    throw new ArgumentOutOfRangeException(
                        "Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Время не может быть отрицательным");
                }

                _holdMin = value * _microConvert;
            }
        }

        /// <summary>
        ///     Максимальное время зажатия
        /// </summary>
        private double HoldMax
        {
            get => _holdMax;
            set
            {
                if (value > 3600)
                {
                    throw new ArgumentOutOfRangeException(
                        "Слишком долгое время нажатия. Максимальная длина нажатия: 3600 секунд (1 час).");
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Время не может быть отрицательным");
                }

                _holdMax = value * _microConvert;
            }
        }

        #endregion

        #region Constructor

        /// <inheritdoc />
        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="key">Символ</param>
        public KeyboardCommand(string key, double pauseMin, double pauseMax,
            double holdMin, double holdMax) : base(key)
        {
            PauseMin = pauseMin * _microConvert;
            PauseMax = pauseMax * _microConvert;
            HoldMin = holdMin * _microConvert;
            HoldMax = holdMax * _microConvert;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Id команды
        /// </summary>
        public override int Id { get; set; }

        /// <inheritdoc />
        /// <summary>
        ///     Выполнить команду
        /// </summary>
        public override void RunNode()
        {
            var rand = new Random();
            keybd_event((byte) VkKeyScan(Key[0]), 1, KEYEVENTF_EXTENDEDKEY, 0);

            Thread.Sleep(rand.Next(Convert.ToInt32(HoldMin), Convert.ToInt32(HoldMax)));

            keybd_event((byte) VkKeyScan(Key[0]), 1, KEYEVENTF_KEYUP, 0);

            Thread.Sleep(rand.Next(Convert.ToInt32(PauseMin), Convert.ToInt32(PauseMax)));
        }

        #endregion

        #region WinAPI

        /// <summary>
        ///     Имитатор зажатия клавиши
        /// </summary>
        /// <param name="bVk">кейкод клавиши (virtual-key-codes)</param>
        /// <param name="bScan">хуй знает (а мне оно собственно и до пизды)</param>
        /// <param name="dwFlags">(флажок зажать/отпустить)</param>
        /// <param name="dwExtraInfo">хуй знает (а мне оно собственно и до пизды)</param>
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
            int dwExtraInfo);

        //зажать
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        //отпустить
        private const uint KEYEVENTF_KEYUP = 0x0002;

        /// <summary>
        ///     Перевод символа в кейкод
        /// </summary>
        /// <param name="ch">символ</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern short VkKeyScan(char ch);

        #endregion
    }
}