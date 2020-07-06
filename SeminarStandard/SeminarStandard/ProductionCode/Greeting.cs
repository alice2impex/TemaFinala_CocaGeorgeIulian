using System;

namespace SeminarStandard
{
	internal class Greeting
	{
		public Greeting()
		{
		}

		internal string Greet(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return "Hello, my friend.";
			}

			if (name==name.ToUpper())
			{
				return $"HELLO {name}!";
			}

			return $"Hello, {name}.";
		}
	}
}