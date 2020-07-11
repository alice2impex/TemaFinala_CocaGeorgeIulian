using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.ProductionCode
{
	public class ShoutingMessage
	{
		const string HELLO = "HELLO";
		const string AND = "AND";

		public string GetStartMessageShouting(string name)
		{
			return $"{HELLO} {name}";
		}

		public string GetEndMessageShouting(string res, string name)
		{
			return $"{res}, {AND} {name}!";
		}

		public string GetTwoNamesMessageShouting(string name1, string name2)
		{
			return $"{HELLO} {name1} {AND} {name2}!";
		}




	}
}
