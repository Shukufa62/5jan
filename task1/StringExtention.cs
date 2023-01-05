using System;
namespace task1
{
	internal static class StringExtention
	{
		public  static bool HasDigit(this string str)
		{
			for(int i=0;i<str.Length;i++)
			{
				if (Char.IsDigit(str[i]))
					return true;
			}
			return false;


		}
		public static string FixSpace(this string str)
		{
			StringBuilder sb = new StringBuilder();

			int spacecount = 0;

			for(int i = 0; i < str.Length; i++)
			{
				if (str[i] != ' ')
				{
					sb.Append(str[i]);
					spacecount = 0;

				}
				else if (spacecount == 0)
				{
					sb.Append(str[i]);
					spacecount++;
				}
			}
            return sb.ToString();
        }

	}
}

