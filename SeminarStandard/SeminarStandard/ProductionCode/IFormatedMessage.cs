
namespace SeminarStandard.ProductionCode
{
	public interface IFormatedMessage
	{
		string GetStartMessage(string name);

		string GetEndMessage(string res, string name);

		string GetTwoNamesMessage(string name1, string name2);

		string GetSingleNameMessage(string name);

		string[] Names { get; set; }

		void SetFilteredNames(string[] names);
	}
}
