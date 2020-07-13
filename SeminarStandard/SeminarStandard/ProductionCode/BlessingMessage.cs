
using System.Linq;

namespace SeminarStandard.ProductionCode
{
	public class BlessingMessage : IFormatedMessage
	{
		const string hello = "May you be blessed";
		const string and = "&";
		const string separator = "and best wishes to";

		public string[] Names { get; set; }

		public string GetStartMessage(string name)
		{
			return $"{hello}{separator} {name}";
		}

		public string GetEndMessage(string res, string name)
		{
			return $"{res}, {and} {name}.";
		}

		public string GetTwoNamesMessage(string name1, string name2)
		{
			return $"{hello}{separator} {name1} {and} {name2}.";
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
