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
			}
			return null;
		}
	}
}