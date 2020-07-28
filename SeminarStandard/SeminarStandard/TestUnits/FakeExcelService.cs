using SeminarStandard.Production;
using System.Collections.Generic;

namespace SeminarStandard.TestUnits
{
	internal class FakeExcelService : IExcelService
	{
		public bool Success { get; set; }

		public void Export(string fileName, object cars)
		{
			Success = true;
			//LogTheExport
		}
	}
}