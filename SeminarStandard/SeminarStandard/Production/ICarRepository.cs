using System.Collections.Generic;

namespace SeminarStandard.Production
{
	public interface ICarRepository
	{
		List<Car> GetAll();
	}
}