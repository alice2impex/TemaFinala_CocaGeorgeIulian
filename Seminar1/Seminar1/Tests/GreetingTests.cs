using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar1.Tests
{
	[TestClass]
	public class GreetingTests
	{
		[TestMethod]
		public void ShouldGreetBob()
		{
			//Arrange
			Greeting greeting = new Greeting();

			//Act
			string result = greeting.Greet("Bob");

			//Assert
			Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Hello, Bob.", result);
		}
	}
}
