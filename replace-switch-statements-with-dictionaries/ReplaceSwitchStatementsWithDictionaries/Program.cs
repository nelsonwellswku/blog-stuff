using System;
using System.Collections.Generic;

namespace ReplaceSwitchStatementsWithDictionaries
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var diceValues = new List<int> {1, 3, 2, 4, 3};

			var switchScorer = new SwitchScorer();
			var dictionaryScorer = new DictionaryScorer();

			// In reality, we wouldn't return a string for a score
			// but this is just for demonstration purposes
			var switchScore = switchScorer.Score(diceValues, ScoreCategory.ThreeOfAKind);
			var dictionaryScore = dictionaryScorer.Score(diceValues, ScoreCategory.ThreeOfAKind);

			Console.WriteLine("switchScorer return {0}", switchScore);
			Console.WriteLine("dictionaryScorer returned {0}", dictionaryScore);
			Console.ReadKey();
		}
	}
}