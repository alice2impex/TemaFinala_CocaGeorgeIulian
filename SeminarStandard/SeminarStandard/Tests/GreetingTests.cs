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
	}
}
