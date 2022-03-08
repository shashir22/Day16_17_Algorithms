using System;

namespace BinarySearchString
{
	class Program
	{
		static int binarySearch(string[] arr, string x)
		{
			int l = 0, r = arr.Length - 1;
			while (l <= r)
			{
				int m = l + (r - l) / 2;

				int res = x.CompareTo(arr[m]);

				// Check if x is present at mid
				if (res == 0)
					return m;

				// If x greater, ignore left half
				if (res > 0)
					l = m + 1;

				// If x is smaller, ignore right half
				else
					r = m - 1;
			}

			return -1;
		}

		// Driver method to test above
		static void Main(string[] args)
		{
			string[] arr = { "contribute", "geeks", "ide", "practice" };
			string x = "ide";
			int result = binarySearch(arr, x);

			if (result == -1)
				Console.WriteLine("Element not present");

			else
				Console.WriteLine("Element found at "
								  + "index " + result);
		}
	}
}
