using MacroFisher.MacrosLib;

namespace MacroFisher.Tools
{
	public static class TestMacrosGenerator
	{
		#region Public methods

		public static Macros GetMacros(string str)
		{
			var macros = new Macros(str);
			macros.Name = str;
			switch (str)
			{
				case "test1":
					macros.AddCommand('d', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('a', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('w', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					return macros;
				case "test2":
					macros.AddCommand('d', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('a', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('w', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('s', 1, 0, 1, 5, 0, 0);
					return macros;
				case "test3":
					macros.AddCommand('d', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('a', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('w', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('s', 1, 0, 0, 0, 1, 5);
					return macros;
				case "Копать":
					macros.AddCommand(0x01, 1, 0, 0, 0, 40, 55);
					macros.AddCommand(' ', 1, 0, 0, 0, 10, 20);
					return macros;
				case "Еда+Чай ":
					//Координаты:
					//Продуктов в инвентаре: 200, 730
					//Еды: 500, 300
					//Кнопка использовать кнопка: 850, 980
					//Кнопка назад: 50, 180
					//Питье: 500, 650
					macros.AddCommand('I', 1, 0, 0, 0, 10, 15);//открываем инвентарь
					macros.AddCommand(0x03, 200, 730, 0, 0, 0, 0);//Выбираем продукты
					macros.AddCommand(0x01, 1, 0, 0, 0, 7, 15);//тык
					macros.AddCommand(0x03, 500, 300, 0, 0, 0, 0);//Выбираем еду
					macros.AddCommand(0x01, 1, 0, 0, 0, 7, 15);//тык
					macros.AddCommand(0x03, 850, 980, 0, 0, 0, 0);//Использовать
					macros.AddCommand(0x01, 1, 0, 0, 0, 7, 15);//тык
					macros.AddCommand(0x03, 500, 650, 0, 0, 0, 0);//Чай
					macros.AddCommand(0x01, 1, 0, 0, 0, 7, 15);//тык
					macros.AddCommand(0x03, 850, 980, 0, 0, 0, 0);//Использовать
					macros.AddCommand(0x01, 1, 0, 0, 0, 7, 15);//тык
					macros.AddCommand('I', 1, 0, 0, 0, 10, 15);//Закрываем инвентарь
					return macros;
				case "Фидер Комариное Караси":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 130, 160, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					
					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 130, 160, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 130, 160, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "Фидер Комариное Караси SPEED":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 90, 110, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 30);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 90, 110, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 30);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 90, 110, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 16, 25, 35);
					macros.AddCommand('p', 0, 0, 12, 18, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 30);
					return macros;
				case "Фидер Острог Лещи":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 140, 170, 0, 0);//Вытягивает
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 18, 25, 35);//Заброс
					macros.AddCommand('p', 0, 0, 6, 12, 15, 30);//Подтягивает
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 140, 170, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 18, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 12, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 140, 170, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 12, 18, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 12, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "Фидер Острог Караси":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "Фидер Острог Караси FAST":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 60, 80, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 60, 80, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 60, 80, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 15, 25, 35);
					macros.AddCommand('p', 0, 0, 6, 10, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "Спининг Белая":
					//вытаскиваем с первой
					macros.AddCommand('p', 0, 0, 14, 40, 15, 30);
					macros.AddCommand('p', 0, 0, 260, 290, 25, 35);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					return macros;
				case "Фидер Белая Стерлядь":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 280, 350, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 30, 50, 60, 70);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 280, 350, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 30, 50, 60, 70);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 280, 350, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 30, 50, 60, 70);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "Фидер Острог Угри Мост":
					//вытаскиваем с первой
					macros.AddCommand('1', 0, 0, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 10, 25, 35);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем со второй
					macros.AddCommand('2', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 10, 25, 35);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);

					//вытаскиваем с третьей
					macros.AddCommand('3', 0, 20, 0, 0, 10, 16);
					macros.AddCommand('p', 0, 0, 100, 140, 0, 0);
					macros.AddCommand(' ', 0, 0, 0, 0, 2, 5);
					macros.AddCommand('h', 0, 0, 40, 60, 15, 20);
					macros.AddCommand(' ', 0, 0, 0, 0, 13, 16);
					macros.AddCommand('p', 0, 0, 6, 10, 25, 35);
					macros.AddCommand('p', 0, 0, 3, 6, 15, 30);
					macros.AddCommand('0', 0, 0, 0, 0, 25, 35);
					return macros;
				case "test4":
					//macros.AddCommand(0x01, 0, 1, 0, 0, 0, 0);
					//macros.AddCommand(0x02, 0, 3, 0, 0, 0, 0);
					macros.AddCommand(0x03, 16, 1, 0, 0, 0, 0);
					return macros;
				case "testU":
					macros.AddCommand('1', 0, 2, 0, 0, 0, 0);
					macros.AddCommand('p', 16, 0, 1, 2, 0, 0);//!
					macros.AddCommand(' ', 0, 1, 0, 0, 0, 0);
					macros.AddCommand('h', 8, 1, 0, 0, 0, 0);//!
					macros.AddCommand(' ', 0, 1, 0, 0, 0, 0);
					macros.AddCommand('p', 2, 2, 0, 0, 0, 0);//!
					macros.AddCommand('0', 0, 0, 0, 0, 0, 0);
					macros.AddCommand('y', 2, 0, 0, 0, 2, 4);//!
					return macros;
				case "Magaz":
					macros.AddCommand('d', 140, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 6, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 110, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 25, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 65, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 390, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 13, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 258, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 143, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 202, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 20, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 171, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 66, 0, 0, 0, 6, 16);
					macros.AddCommand('f', 14, 0, 0, 0, 6, 16);
					return macros;
				case "returnFromMagaz":
					macros.AddCommand('s', 330, 0, 0, 0, 6, 16);
					macros.AddCommand('w', 3, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 3, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 140, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 25, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 7, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 16, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 45, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 30, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 28, 0, 0, 0, 6, 16);
					macros.AddCommand('d', 40, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 412, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 145, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 22, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 265, 0, 0, 0, 6, 16);
					macros.AddCommand('s', 5, 0, 0, 0, 6, 16);
					macros.AddCommand('a', 187, 0, 0, 0, 6, 16);
					return macros;
				case "LKM":
					macros.AddCommand(0x01, 0, 0, 0, 0, 1, 1);
					return macros;
				default:
					return macros;
			}
		}

		#endregion
	}
}