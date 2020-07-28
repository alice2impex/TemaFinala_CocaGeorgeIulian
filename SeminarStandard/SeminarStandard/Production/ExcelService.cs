using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarStandard.Production
{
	public class ExcelService : IExcelService
	{
		public bool Success { get; internal set; }

		public void Export(string fileName, object cars)
		{
			//Impelemented export to excel.
			Success = true;
		}
	}
}
