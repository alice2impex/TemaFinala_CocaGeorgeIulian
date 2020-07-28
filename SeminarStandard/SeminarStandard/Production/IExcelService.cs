namespace SeminarStandard.Production
{
	public interface IExcelService
	{
		bool Success { get; }

		void Export(string fileName, object cars);
	}
}