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
		public void ShouldHandleTwoNames()
		{
			ExecuteTest("Jill,Jane", "Hello, Jill and Jane.");
		}


		[Test]
		public void ShouldHandleTwoNamesShouting()
		{
			ExecuteTest("JERRY,JILL", "HELLO JERRY AND JILL!");
		}


		[Test]
		public void ShouldHandleMultipleNames3()
		{
			ExecuteTest("Amy,Brian,Charlotte", "Hello, Amy, Brian, and Charlotte.");
		}

		[Test]
		public void ShouldHandleMultipleNames4()
		{
			ExecuteTest("Amy,Brian,Charlotte,Andreea", "Hello, Amy, Brian, Charlotte, and Andreea.");
		}

		[Test]
		public void ShouldHandleMultipleMixedNames()
		{
			ExecuteTest("Amy,BRIAN,Charlotte", "Hello, Amy and Charlotte. AND HELLO BRIAN!");
		}

		[Test]
		public void ShouldHandleMultipleMoreMixed()
		{
			ExecuteTest("AMY,BRIAN,Tudor,Andreea,GEORGE,Marian", "Hello, Tudor, Andreea, and Marian. AND HELLO AMY, BRIAN, AND GEORGE!");
		}
	}
}
