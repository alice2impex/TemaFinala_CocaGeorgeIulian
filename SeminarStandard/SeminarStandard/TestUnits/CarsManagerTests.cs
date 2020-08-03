using Castle.Components.DictionaryAdapter.Xml;
using Moq;
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
		Mock<ICarRepository> carRepositoryMock;
		Mock<IExcelService> excelServiceMock;
		CarsManager sut;
		MockRepository mockRepository = new MockRepository(MockBehavior.Default);
		const string fileName = "fileDemo.xls";

		[SetUp]
		public void Setup()
		{
			carRepositoryMock = mockRepository.Create<ICarRepository>();
			excelServiceMock = mockRepository.Create<IExcelService>();
			sut = new CarsManager(carRepositoryMock.Object, excelServiceMock.Object);
		}

		[TearDown]
		public void CleanUp()
		{
			carRepositoryMock = null;
			excelServiceMock = null;
			sut = null;
		}


		[Test]
		public void ShouldNotExportForNoCars()
		{
			//Arrange
			carRepositoryMock.Setup(s => s.GetAll()).Returns(new List<Car>());

			//Act
			bool result = sut.Export(fileName);

			//Assert
			Assert.AreEqual(result, false);
			carRepositoryMock.Verify(s => s.GetAll());
			excelServiceMock.Verify(s => s.Export(It.IsAny<string>(), It.IsAny<List<Car>>()), Times.Never);
		}


		[Test]
		public void ShouldExportForExistingCars()
		{
			//Arrange
			carRepositoryMock.Setup(s => s.GetAll()).Returns(new List<Car>() { new Car() });
			excelServiceMock.Setup(s => s.Export(It.Is<string>(c => c == fileName), It.IsAny<List<Car>>()));
			excelServiceMock.SetupGet(s => s.Success).Returns(true);

			//Act
			bool result = sut.Export(fileName);

			//Assert
			Assert.AreEqual(result, true);
			mockRepository.VerifyAll();
		}

	}
}
