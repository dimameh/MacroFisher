using System;
using System.IO;
using System.Threading;

namespace MacroFisher
{
	public static class TestMacrosGenerator
	{
		#region Public methods

		public static Macros GetMacros(int macrosNumber)
		{
			var macros = new Macros("Test Macros #" + macrosNumber);

			switch
				(macrosNumber)
			{
				case 1:
					macros.AddCommand('d', 3, 1, PressType.Hold);
					macros.AddCommand('a', 3, 1, PressType.Hold);
					macros.AddCommand('w', 3, 1, PressType.Hold);
					macros.AddCommand('s', 3, 1, PressType.Hold);
					return macros;
				case 2:
					macros.AddCommand('d', 3, 1, PressType.Press);
					macros.AddCommand('a', 3, 1, PressType.Press);
					macros.AddCommand('w', 3, 1, PressType.Press);
					macros.AddCommand('s', 3, 1, PressType.Press);
					return macros;
				case 3:
					macros.AddCommand('w', 3, 1, PressType.Press);
					macros.AddCommand('3', 3, 1, PressType.Press);
					return macros;
				case 4:

					macros.AddCommand('p', 0, 4, PressType.Press);
					macros.AddCommand(' ', 0, 5, PressType.Press);

					char key;
					switch (1)
					{
						case 1:
							key = 'w';
							break;
						case 2:
							key = 'a';
							break;
						case 3:
							key = 's';
							break;
						case 4:
							key = 'd';
							break;
						default:
							key = 's';
							break;
					}
					macros.AddCommand(key, 5, 5, PressType.Hold);

					return macros;
				default:
					return macros;
			}
		}

		#endregion
	}
}