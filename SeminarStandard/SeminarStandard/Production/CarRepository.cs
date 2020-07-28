using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.Production
{
	public class CarRepository: ICarRepository
	{
		public List<Car> GetAll()
		{
			var cars = new List<Car>() {
				new Car(){
			Make="Tesla",
			Model="Model 3" },
				new Car(){
			Make="Dacia",
			Model="Golan" }
		};

			return cars;
		}
	}
}
