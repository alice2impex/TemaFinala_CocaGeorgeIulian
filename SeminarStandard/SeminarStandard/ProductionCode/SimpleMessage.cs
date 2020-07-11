using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.ProductionCode
{
	public class SimpleMessage
	{
		const string hello = "Hello";
		const string and = "and";
		const string coma = ",";

		public string Hello { get { return hello; } }

		public string And { get { return and; } }

		public string GetNamesStartingMessage(string name)
		{
			return $"{hello}{coma} {name}";
		}

		public string GetNamesEndingMessage(string res, string name)
		{
			res = $"{res}, {and} {name}.";
			return res;
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return  $"{hello}{coma} {name1} {and} {name2}.";
		}
	}
}
