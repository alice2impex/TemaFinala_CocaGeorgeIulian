using SeminarStandard.ProductionCode;

namespace SeminarStandard
{
	internal class MessageFactory
	{
		public IFormatedMessage GetMessageByName(string name)
		{
			if (!string.IsNullOrEmpty(name))
			{
				if (name != name.ToUpper())
					return new SimpleMessage();
				else
					return new ShoutingMessage();

				//ADD Royal Message detected by containing: "Prince or Princess, King, Queen"
			}
			return null;
		}
	}
}