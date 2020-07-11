using NUnit.Framework;

namespace SeminarStandard
{
	[TestFixture]
	public class GreetingTests
	{
		// TODO Setup/TearDown 
		// TODO TESTCASE
		Greeting greeting = new Greeting();

		[Test]
		public void ShouldGreetBob()
		{
			ExecuteTest("Bob", "Hello, Bob.");
		}

		public void ExecuteTest(string name, string expected)
		{
			//Arrange

			//Act
			string result = greeting.Greet(name);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void ShouldGreetGigi()
		{
			ExecuteTest("Gigi", "Hello, Gigi.");
		}


		[Test]
		public void ShouldHandleNull()
		{
			ExecuteTest(null, "Hello, my friend.");
		}


		[Test]
		public void ShouldHandleShouting()
		{
			ExecuteTest("JERRY", "HELLO JERRY!");
		}

		[Test]
		public void ShouldHandleTwoNamesArray()
		{
			//Arrange

			//Act
			string[] names = { "Jill", "Jane" };
			string result = greeting.GreetMultipleNames(names);

			//Assert
			Assert.AreEqual("Hello, Jill and Jane.", result);
		}


		[Test]
		public void ShouldHandleTwoNames()
		{
			ExecuteTest("Jill,Jane", "Hello, Jill and Jane.");
		}

		[Test]
		public void ShouldHandleThreeNames()
		{
			ExecuteTest("Amy,Brian,Charlotte", "Hello, Amy, Brian, and Charlotte.");
		}


		[Test]
		public void ShouldHandleMixedNames()
		{
			ExecuteTest("Amy,BRIAN,Charlotte", "Hello, Amy and Charlotte. AND HELLO BRIAN!");
		}


		[Test]
		public void ShouldHandleMultipleShouting()
		{
			ExecuteTest("AMY,BRIAN", "HELLO AMY AND BRIAN!");
		}


		[Test]
		public void ShouldHandleMultipleMoreMixed()
		{
			ExecuteTest("AMY,BRIAN,Tudor,Andreea,GEORGE,Marian", "Hello, Tudor, Andreea, and Marian. AND HELLO AMY, BRIAN, AND GEORGE!");
		}

	}
}
