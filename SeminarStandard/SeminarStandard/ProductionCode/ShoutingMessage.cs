using System;
using System.Linq;

namespace SeminarStandard.ProductionCode
{
	public class ShoutingMessage : IFormatedMessage
	{
		const string HELLO = "HELLO";
		const string AND = "AND";

		public string[] Names { get; set; }

		public string GetStartMessage(string name)
		{
			return $"{HELLO} {name}";
		}

		public string GetEndMessage(string res, string name)
		{
			return $"{res}, {AND} {name}!";
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return $"{HELLO} {name1} {AND} {name2}!";
		}

		public void SetFilteredNames(string[] names)
		{
			Names = names.Where(name => name == name.ToUpper()).ToArray();
		}

		public string GetSingleNameMessage(string name)
		{
			return $"{HELLO} {name}!";
		}
	}
}
