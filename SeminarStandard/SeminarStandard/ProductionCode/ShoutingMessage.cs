using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.ProductionCode
{
	public class ShoutingMessage : SimpleMessage
	{
		const string HELLO = "HELLO";
		const string AND = "AND";
	}

	public string Hello { get { return HELLO; } }

	public string And { get { return AND; } }

	public string GetNamesStartingMessage(string name)
	{
		return $"{Hello}{coma} {name}";
	}

	public string GetNamesEndingMessage(string res, string name)
	{
		res = $"{res}, {and} {name}.";
		return res;
	}

	public string GetTwoNamesMessage(string name1, string name2)
	{
		return $"{hello}{coma} {name1} {and} {name2}.";
	}

}
