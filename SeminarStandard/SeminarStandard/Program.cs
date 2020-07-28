using SeminarStandard.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard
{
	class Program
	{
		static void Main(string[] args)
		{
			CarsManager carsManager = new CarsManager(new CarRepository(), new ExcelService());
			bool success = carsManager.Export(@"C:\cars.csv");
			if (success)
			{
				Console.WriteLine("Was Sucessfully Exported!");
			}

		}
	}
}
