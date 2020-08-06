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

		[Test]
		public void Should_Return_V_For_5()
		{
			ExecuteTest(5, "V");
		}

		[Test]
		public void Should_Return_XXII_For_22()
		{
			ExecuteTest(22, "XXII");
		}

		[Test]
		public void Should_Return_XLV_For_45()
		{
			ExecuteTest(45, "XLV");
		}

		[Test]
		public void Should_Return_XCIX_For_99()
		{
			ExecuteTest(99, "XCIX");
		}

		[Test]
		public void Should_Return_DCC_For_700()
		{
			ExecuteTest(700, "DCC");
		}

		[Test]
		public void Should_Return_MCM_For_1900()
		{
			ExecuteTest(1900, "MCM");
		}

		[Test]
		public void Should_Return_MCMLXXXVI_For_1986()
		{
			ExecuteTest(1986, "MCMLXXXVI");
		}

		[Test]
		public void Convert0_Error()
		{
			ExecuteTest(0, "Nu exista cifra 0");
		}

		[Test]
		public void Should_Return_MMCCCXXI_For_2321()
		{
			ExecuteTest(2321, "MMCCCXXI");
		}
	}
}
