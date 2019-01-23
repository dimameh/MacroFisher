using System.ComponentModel;

namespace MacroFisher
{
	public static class TestMacrosGenerator
	{
		#region Public methods

		public static Macros GetMacros(int macrosNumber)
		{
			var macros = new Macros("Test Macros #" + macrosNumber);
			switch (macrosNumber)
			{
				case 1:
					macros.AddCommand('d', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('a', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('w', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					return macros;
				case 2:
					macros.AddCommand('d', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('a', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('w', 1, 0, 1, 5, 0, 0);
					macros.AddCommand('s', 1, 0, 1, 5, 0, 0);
					return macros;
				case 3:
					macros.AddCommand('d', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('a', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('w', 1, 0, 0, 0, 1, 5);
					macros.AddCommand('s', 1, 0, 0, 0, 0, 0);
					macros.AddCommand('s', 1, 0, 0, 0, 1, 5);
					return macros;
				case 4:
					macros.AddCommand(0x01, 1, 1, 0, 0, 0, 0);
					macros.AddCommand(0x02, 1, 1, 0, 0, 0, 0);
					macros.AddCommand(0x01, 0, 0, 0, 0, 0, 0);
					macros.AddCommand(0x01, 0, 0, 0, 0, 0, 0);
					return macros;
				default:
					return macros;
			}
		}

		#endregion
	}
}