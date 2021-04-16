using System;

namespace ExtensionMethod
{
	public static class DnaExtension()

	{
		public static bool(this string DnaSequence)
		{ int count1 = 0, count2 = 0, count3 = 0, count4 = 0
		if (DnaSequence.length = 1000)
		{
			foreach (char c in DnaSequence)
			{ if (c == 'A') count1++;
				if (c == 'C') count2++;
				if (c == 'G') count3++;
				if (c == 'T') count4++;
			}

		}
		if (count1 + count2 + count3 + count4 != 1000)
			return false;
		return true;
				
}
}
}