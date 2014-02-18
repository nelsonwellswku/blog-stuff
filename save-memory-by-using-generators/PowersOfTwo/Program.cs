using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PowersOfTwo
{
	class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> enumeratedPowers = GetPowersOfTwo();
			IEnumerable<int> listedPowers = GetPowersOfTwoFromList();

			// Print the first 10 powers of two using listedPowers
			// Here, the entire collection of powers of two was 
			// created in memory. Unfortunately, we only need the first 10.
			Console.WriteLine("Calculating the first 10 powers of two using the listed powers.");
			foreach (var value in listedPowers.Take(10))
			{
				Console.WriteLine(value);
			}

			Console.WriteLine();

			// Print the first 10 powers of two using enumeratedPowers
			// Here, the 11th item in the sequence was never calculated
			// and no memory was reserved for the remaining powers of two.
			Console.WriteLine("Calculating the first 10 powers of two using the enumerated powers.");
			foreach (var value in enumeratedPowers.Take(10))
			{
				Console.WriteLine(value);
			}

			Console.WriteLine();
			Console.WriteLine("Demo over. Press enter to exit.");
			Console.ReadKey();
		}

		private static IEnumerable<int> GetPowersOfTwo()
		{
			int currentValue = 2;
			do
			{
				yield return currentValue;
				currentValue *= 2;
			} while (currentValue > 0 && currentValue <= Int32.MaxValue);
		}

		private static IEnumerable<int> GetPowersOfTwoFromList()
		{
			// List<T> implements IEnumerable<T>
			var powersOfTwo = new List<int>();
			var currentValue = 2;
			do
			{
				powersOfTwo.Add(currentValue);
				currentValue *= 2;
			} while (currentValue > 0 && currentValue < Int32.MaxValue);

			return powersOfTwo;
		}
	}
}