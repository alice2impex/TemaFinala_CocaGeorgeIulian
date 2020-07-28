using NUnit.Framework;
using SeminarStandard.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.TestUnits
{
	[TestFixture]
	public class CarsManagerTests
	{

		[Test]
		public void ShouldNotExportForNoCars()
		{
			//Arrange
			ICarRepository carRepository = new FakeCarRepository();
			IExcelService excelService = new FakeExcelService();
			CarsManager sut = new CarsManager(carRepository, excelService);

			//Act
			bool result = sut.Export("fileDemo.csv");

			//Assert
			Assert.AreEqual(result, false);
		}


		[Test]
		public void ShouldExportForExistingCars()
		{
			//Arrange
			ICarRepository carRepository = new FakeCarRepository(new List<Car>() { new Car() });
			IExcelService excelService = new FakeExcelService();
			CarsManager sut = new CarsManager(carRepository, excelService);

			//Act
			bool result = sut.Export("fileDemo.csv");

			//Assert
			Assert.AreEqual(result, true);
		}

	}
}
