using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace MacroFisher.Tools
{
	internal static class Serialization
	{
		public static string separator = "|";

		public static void Save(string filename, List<Macros> savingList)
		{
			string serializedText = savingList.Count + "\n";

			foreach (var macros in savingList)
			{
				serializedText = serializedText + macros.Name + separator + GetMacrosToString(macros) + separator;
			}

			StreamWriter SW = new StreamWriter(new FileStream(filename, FileMode.Create, FileAccess.Write));
			SW.Write(serializedText);
			SW.Close();
		}

		public static List<Macros> Read(string filename)
		{
			List<Macros> readingList = new List<Macros>();
			string[] s = File.ReadAllLines(filename);
			int elementCount;
			s[1].Remove(s.Length-1);

			if (!int.TryParse(s[1], out elementCount))
			{
				throw new InvalidDataException("Не удалось считать количество макросов в списке");
			}


			return readingList;
		}

		public static string GetMacrosToString(Macros macros)
		{
			string result = string.Empty;
			foreach (Command command in macros)
			{
				result = result + command.Id +
				         separator + command.Key +
				         separator + command.MicrosecondsPressed +
				         separator + command.MicrosecondsPausedAfter +
				         separator + command.Type +
				         separator;
			}

			return result;
		}

		private static Macros GetMacrosFromString(string macroString)
		{
			string[] elementalString = macroString.Split(separator[0]);
			Macros deserializingMacros = new Macros(elementalString[0]);
			for (int i = 1; i < elementalString.Length; i++)
			{
				//deserializingMacros.AddCommand(new Command(elementalString[i+1], elementalString[i + 2], elementalString[i + 3], (PressType)elementalString[i + 4], elementalString[i] ));
			}

			return null;
		}
	}
}
