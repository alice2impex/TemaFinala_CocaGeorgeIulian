using System;
using System.Collections.Generic;

namespace SeminarStandard.ProductionCode
{
	public interface IMessage
	{
		string GetStartMessage(string name);

		string GetEndMessage(string res, string name);

		string GetTwoNamesMessage(string name1, string name2);

		string GetSingleNameMessage(string name);

		string[] Names { get; set; }
		void SetFilteredNames(string[] names);

	}
}
