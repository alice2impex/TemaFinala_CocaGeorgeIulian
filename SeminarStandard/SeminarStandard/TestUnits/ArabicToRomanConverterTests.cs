using NUnit.Framework;
using SeminarStandard.Production;
using System;

namespace SeminarStandard.TestUnits
{
	[TestFixture]
	public class ArabicToRomanConverterTests
	{
		[Test]
		public void Should_Return_I_For_1()
		{
			ExecuteTest(1, "I");
		}

		private void ExecuteTest(int number, string expected)
		{
			//Arrange
			var arabicToRomanConverter = new ArabicToRomanConverter();

			//Act
			string result = arabicToRomanConverter.Convert(number);

			//Assert
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Should_Return_II_For_2()
		{
			ExecuteTest(2, "II");
		}

		[Test]
		public void Should_Return_III_For_3()
		{
			ExecuteTest(3, "III");
		}

		[Test]
		public void Should_Return_IV_For_4()
		{
			ExecuteTest(4, "IV");
		}


	}
}
