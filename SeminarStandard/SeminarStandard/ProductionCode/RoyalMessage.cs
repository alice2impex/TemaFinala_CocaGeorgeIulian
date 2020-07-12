
using System.Linq;

namespace SeminarStandard.ProductionCode
{
	public class RoyalMessage : IFormatedMessage
	{
		const string hello = "Hello Your Majesty";
		const string and = "&";
		const string coma = ",";

		public string[] Names { get; set; }

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

		public void SetFilteredNames(string[] names)
		{
			Names = names.Where(name => name != name.ToUpper()).ToArray();
		}

		public string GetSingleNameMessage(string name)
		{
			return $"{hello}, {name}.";
		}
	}
}
