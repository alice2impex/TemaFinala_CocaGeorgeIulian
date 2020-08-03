using SeminarStandard.Production;
using System.Collections.Generic;

namespace SeminarStandard.TestUnits
{
	internal class FakeCarRepository : ICarRepository
	{
		List<Car> cars = new List<Car>();

		public FakeCarRepository()
		{
			this.cars = new List<Car>();
		}

		public FakeCarRepository( List<Car> cars)
		{
			this.cars = cars;
		}

		public List<Car> GetAll()
		{
			return this.cars;
		}
	}
}