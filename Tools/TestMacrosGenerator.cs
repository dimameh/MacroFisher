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
					macros.AddCommand('d', 3, 1, 0, 0, 0, 0);
					macros.AddCommand('a', 3, 1, 0, 0, 0, 0);
					macros.AddCommand('w', 3, 1, 0, 0, 0, 0);
					macros.AddCommand('s', 3, 1, 0, 0, 0, 0);
					return macros;
				case 2:
					macros.AddCommand('d', 3, 1, 1, 2, 1, 1);
					macros.AddCommand('a', 3, 1, 2, 2, 2, 2);
					macros.AddCommand('w', 3, 1, 1, 1, 1, 1);
					macros.AddCommand('s', 3, 1, 1, 5, 1, 5);
					return macros;
				case 3:
					macros.AddCommand('w', 3, 1, 0, 0, 0, 0);
					macros.AddCommand('3', 3, 1, 0, 0, 0, 0);
					return macros;
				default:
					return macros;
			}
		}

		#endregion
	}
}