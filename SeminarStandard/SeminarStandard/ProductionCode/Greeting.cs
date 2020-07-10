using System;
using System.Linq;

namespace SeminarStandard
{
	internal class Greeting
	{
		const string hello = "Hello";
		const string HELLO = "HELLO";
		const string coma = ",";
		const string and = "and";
		const string AND = "AND";

		string result;

		internal string Greet(string name)
		{
			result = string.Empty;

			if (string.IsNullOrEmpty(name))
			{
				result = $"{hello}{coma} my friend.";
			}
			else
			{
				var names = name.Trim().Split(',');
				if (names.Length > 1)
				{
					result = GreetMultipleNames(names);
				}
				else
				{
					result = GreetSingleName(name);
				}
			}

			return result;
		}

		private string GreetSingleName(string name)
		{
			if (name == name.ToUpper())
				result = $"{HELLO} {name}!";
			else
				result = $"{hello}{coma} {name}.";

			return result;
		}

		internal string GreetMultipleNames(string[] names)
		{
			//Use string builder.

			string[] shoutingNames = names.Where(name => name == name.ToUpper()).ToArray();
			string[] simpleNames = names.Where(name => name != name.ToUpper()).ToArray();

			string simpleGreetings = GetSimpleNamesGreeting(simpleNames);
			string shoutingGreetings = GetShoutingNamesGreeting(shoutingNames);

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

		private string GetSimpleNamesGreeting(string[] names)
		{
			string res = string.Empty;
			if (names.Length > 0)
			{
				res = $"{hello}{coma} {names[0]}";

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
							res = $"{res}, {and} {names[iCount]}.";
						}
					}
				}
				else if (names.Length == 2)
				{
					res = $"{hello}{coma} {names[0]} {and} {names[1]}.";
				}
				else
				{
					res = GreetSingleName(names[0]);
				}
			}
			return res;
		}

		private string GetShoutingNamesGreeting(string[] names)
		{
			string res = string.Empty;
			if (names.Length > 0)
			{
				res = $"{HELLO} {names[0]}";

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
							res = $"{res}, {AND} {names[iCount]}!";
						}
					}
				}
				else if (names.Length == 2)
				{
					res = $"{HELLO} {names[0]} {AND} {names[1]}!";
				}
				else
				{
					res = GreetSingleName(names[0]);
				}
			}
			return res;
		}

	}
}