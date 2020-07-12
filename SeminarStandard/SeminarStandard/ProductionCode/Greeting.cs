using SeminarStandard.ProductionCode;
using System;
using System.Linq;

namespace SeminarStandard
{
	internal class Greeting
	{
		const string hello = "Hello";
		const string and = "and";
		const string HELLO = "HELLO";
		const string coma = ",";
		string result = string.Empty;
		IMessage simpleMessage = new SimpleMessage();
		IMessage shoutingMessage = new ShoutingMessage();

		internal string Greet(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				result = $"{hello}, my friend.";
			}
			else
			{
				var names = name.Split(',');
				if (names.Length == 2)
				{
					result = GetTwoNames(names);
				}
				else if (names.Length > 2)
				{
					result = GreetMultipleNames(names);
				}
				else
				{
					result = GetSingleNameMessage(name);
				}
			}

			return result;
		}

		internal string GreetMultipleNames(string[] names)
		{
			//Use string builder.
			simpleMessage.SetFilteredNames(names);
			shoutingMessage.SetFilteredNames(names);

			string simpleGreetings = GetNamesGreetingMesage(simpleMessage);
			string shoutingGreetings = GetNamesGreetingMesage(shoutingMessage);

			if (simpleGreetings.Length > 0)
			{
				result = simpleGreetings;
			}

			if (shoutingGreetings.Length > 0 && simpleGreetings.Length > 0)
			{
				result = result + " AND " + shoutingGreetings;
			}
			else if (simpleGreetings.Length > 0)
			{
				result = simpleGreetings;
			}
			else
			{
				result = result + shoutingGreetings;
			}

			return result;
		}

		private string GetNamesGreetingMesage(IMessage message)
		{
			string res = string.Empty;
			if (message.Names.Length > 0)
			{
				res = message.GetStartMessage(message.Names[0]);

				if (message.Names.Length > 2)
				{
					for (int iCount = 1; iCount < message.Names.Length; iCount++)
					{
						if (iCount != message.Names.Length - 1)
						{
							res = res + coma + " " + message.Names[iCount];
						}
						else
						{
							res = message.GetEndMessage(res, message.Names[iCount]);
						}
					}
				}
				else if (message.Names.Length == 2)
				{
					res = message.GetTwoNamesMessage(message.Names[0], message.Names[1]);
				}
				else
				{
					res = GetSingleNameMessage(message.Names[0]);
				}
			}
			return res;
		}

		private string GetTwoNames(string[] names)
		{
			return $"{hello}, {names[0]} {and} {names[1]}.";
		}

		private string GetSingleNameMessage(string name)
		{
			if (name == name.ToUpper())
			{
				return $"{HELLO} {name}!";
			}
			else
				return $"{hello}, {name}.";
		}

		internal string GreetTwoNames(string[] names)
		{
			string result = String.Empty;
			if (names.Length == 2)
			{
				result = $"{hello}, {names[0]} {and} {names[1]}.";
			}

			return result;
		}
	}
}