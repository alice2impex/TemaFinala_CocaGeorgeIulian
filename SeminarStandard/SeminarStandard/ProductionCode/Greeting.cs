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
		const string AND = "AND";
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
			string[] shoutingNames = names.Where(name => name == name.ToUpper()).ToArray();
			string[] simpleNames = names.Where(name => name != name.ToUpper()).ToArray();


			string simpleGreetings = GetNamesGreetingMesage(simpleNames, simpleMessage);
			string shoutingGreetings = GetNamesGreetingMesage(shoutingNames, shoutingMessage);

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

		private string GetNamesGreetingMesage(string[] names, IMessage message)
		{
			//MESSAGE abstract then interface to replace Simple and Shouting Message. form outside give shouting message


			string res = string.Empty;
			if (names.Length > 0)
			{
				res = message.GetStartMessage(names[0]);

				if (names.Length > 2)
				{
					for (int iCount = 1; iCount < names.Length; iCount++)
					{
						if (iCount != names.Length - 1)
						{
							res = res + coma + " " + names[iCount];
						}
						else
						{
							res = message.GetEndMessage(res, names[iCount]);
						}
					}
				}
				else if (names.Length == 2)
				{
					res = message.GetTwoNamesMessage(names[0], names[1]);
				}
				else
				{
					res = GetSingleNameMessage(names[0]);
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