using System.Text;

namespace SeminarStandard.Production
{
	internal class ArabicToRomanConverter
	{
		internal string Convert(int number)
		{
			StringBuilder result = new StringBuilder();

			for (int i = 0; i < number; i++)
			{
				result.Append("I");
			}

			return result.ToString();
		}
	}
}