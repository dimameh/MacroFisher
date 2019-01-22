using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroFisher
{
	public static class TestMacrosGenerator
	{
		public static Macros GetMacros(int macrosNumber)
		{
			Macros macros = new Macros();
			switch (macrosNumber)
			{
				case 1:
					macros.AddCommand('d',3,1,PressType.Hold);
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
	}
}
