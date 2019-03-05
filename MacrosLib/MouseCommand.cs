using System;
using System.Threading;
using System.Windows.Forms;
using AutoIt;

namespace MacroFisher.MacrosLib
{
    internal class MouseCommand : Command
    {
        #region Private fields

        private string _direction;

        private string _key;

        private int _screenXCoordinate;

        private int _screenYCoordinate;

        private int _wheelClicks;

        #endregion

        #region Properties

        public new string Key
        {
            get => _key;
            set
            {
                if (value != "LMB" && value != "RMB" && value != "Move" &&
                    value != "Wheel")
                {
                    throw new ArgumentException("Указан несуществующий ключ");
                }

                _key = value;
            }
        }

        /// <summary>
        /// ID команды
        /// </summary>
        public override int Id { get; set; }

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

        /// <summary>
        ///     X координата экрана
        /// </summary>
        private int ScreenXCoordinate
        {
            get => _screenXCoordinate;
            set
            {
                float screenWidth = Screen.PrimaryScreen.Bounds.Width;

                if (value * (65535 / screenWidth) > screenWidth || value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Неправильно указаны координаты");
                }

                _screenXCoordinate = (int) (value * (65535 / screenWidth));
            }
        }

        /// <summary>
        ///     Y координата экрана
        /// </summary>
        private int ScreenYCoordinate
        {
            get => _screenYCoordinate;
            set
            {
                float screenHeight = Screen.PrimaryScreen.Bounds.Height;

                if (value * (65535 / screenHeight) > screenHeight || value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Неправильно указаны координаты");
                }

                _screenYCoordinate = (int) (value * (65535 / screenHeight));
            }
        }

        /// <summary>
        ///     Направлеие прокрутки колёсика
        /// </summary>
        private string Direction
        {
            get => _direction;
            set
            {
                if (value != "up" && value != "down")
                {
                    throw new ArgumentOutOfRangeException(
                        "Неправильно указано направление");
                }

                _direction = value;
            }
        }

        /// <summary>
        ///     Количество кликов прогрутки
        /// </summary>
        private int WheelClicks
        {
            get => _wheelClicks;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Количество кликов прокрутки не может быть меньше или равным нулю");
                }

                _wheelClicks = value;
            }
        }

        #endregion

        #region Constructor

        /// <inheritdoc />
        /// <summary>
        ///     Конструктор для нажатия левой и правой кнопок мыши
        /// </summary>
        public MouseCommand(string key, double pauseMin, double pauseMax,
            double holdMin, double holdMax) : base(key)
        {
            PauseMin = pauseMin * _microConvert;
            PauseMax = pauseMax * _microConvert;
            HoldMin = holdMin * _microConvert;
            HoldMax = holdMax * _microConvert;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Конструктор для перемещения курсора
        /// </summary>
        public MouseCommand(string key, int screenXCoordinate, int screenYCoordinate,
            double pauseMin, double pauseMax) : base(key)
        {
            ScreenXCoordinate = screenXCoordinate;
            ScreenYCoordinate = screenYCoordinate;
            PauseMin = pauseMin * _microConvert;
            PauseMax = pauseMax * _microConvert;
        }

        /// <inheritdoc />
        /// <summary>
        ///     Конструктор для прокрутки колёсика
        /// </summary>
        public MouseCommand(string key, int wheelClicks, double pauseMin, double pauseMax,
            string direction = "up") : base(key)
        {
            Direction = direction;
            WheelClicks = wheelClicks;
            PauseMin = pauseMin * _microConvert;
            PauseMax = pauseMax * _microConvert;
        }

        #endregion

        #region Public methods

        /// <inheritdoc />
        /// <summary>
        ///     Выполнить команду
        /// </summary>
        public override void RunNode()
        {
            var rand = new Random();
            switch (Key)
            {
                case "LMB":
                    AutoItX.MouseDown();

                    Thread.Sleep(rand.Next(Convert.ToInt32(HoldMin),
                        Convert.ToInt32(HoldMax)));

                    AutoItX.MouseUp();
                    break;
                case "RMB":
                    AutoItX.MouseDown("Right");

                    Thread.Sleep(rand.Next(Convert.ToInt32(HoldMin),
                        Convert.ToInt32(HoldMax)));

                    AutoItX.MouseUp("Right");
                    break;
                case "Move":
                    AutoItX.MouseMove(ScreenXCoordinate, ScreenYCoordinate);
                    break;
                case "Wheel":
                    AutoItX.MouseWheel(Direction, WheelClicks);
                    break;
            }

            Thread.Sleep(rand.Next(Convert.ToInt32(PauseMin), Convert.ToInt32(PauseMax)));
        }

        #endregion
    }
}