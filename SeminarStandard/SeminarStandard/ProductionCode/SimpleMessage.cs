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

		public string GetStartMessage(string name)
		{
			return $"{hello}{coma} {name}";
		}

		public string GetEndMessage(string res, string name)
		{
			return $"{res}, {and} {name}.";
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return $"{hello}{coma} {name1} {and} {name2}.";
		}

		


	}
}
