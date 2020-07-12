using SeminarStandard.ProductionCode;
using System.Runtime.Remoting.Messaging;

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