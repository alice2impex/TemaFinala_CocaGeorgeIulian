using System.Collections.Generic;
using System.Linq;

namespace SeminarStandard.Production
{
	internal class CarsManager
	{
		//TODO TEAR DOWN AND SETUP


		private readonly ICarRepository carRepository;
		private readonly IExcelService excelService;

		public CarsManager(ICarRepository carRepository, IExcelService excelService)
		{
			this.carRepository = carRepository;
			this.excelService = excelService;
		}


		internal bool Export(string fileName)
		{
			List<Car> cars = carRepository.GetAll();

			if (cars.Count > 0)
			{
				excelService.Export(fileName, cars);
				if (excelService.Success)
					return true;
			}

			return false;
		}
	}
}