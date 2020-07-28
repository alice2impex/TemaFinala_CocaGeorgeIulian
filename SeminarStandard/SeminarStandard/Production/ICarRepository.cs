using System.Collections.Generic;

namespace SeminarStandard.Production
{
	internal interface ICarRepository
	{
		List<Car> GetAll();
	}
}