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
					macros.AddCommand('w', 3, 1, PressType.Hold);
					macros.AddCommand('i', 3, 1, PressType.Press);
					return macros;
				default:
					return macros;
			}
		}

		#endregion
	}
}