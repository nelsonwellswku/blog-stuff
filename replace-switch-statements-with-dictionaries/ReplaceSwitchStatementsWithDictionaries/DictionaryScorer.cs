using System;
using System.Collections.Generic;
using ScoreDict = System.Collections.Generic.Dictionary<ReplaceSwitchStatementsWithDictionaries.ScoreCategory, System.Func<System.Collections.Generic.ICollection<int>, string>>;

namespace ReplaceSwitchStatementsWithDictionaries
{
	public class DictionaryScorer
	{
		private static readonly ScoreDict ScoreDict = new ScoreDict
		{
			{ScoreCategory.ThreeOfAKind, values => "ThreeOfAKind"},
			{ScoreCategory.FourOfAKind, values => "FourOfAKind"},
			{ScoreCategory.FullHouse, values => "FullHouse"},
			{ScoreCategory.SmallStraight, values => "SmallStraight"},
			{ScoreCategory.LargeStraight, values => "LargeStraight"},
			{ScoreCategory.Yahtzee, values => "Yahtzee"}
		};

		public string Score(ICollection<int> diceValues, ScoreCategory scoreCategory)
		{
			Func<ICollection<int>, string> scoreFunc;
			return ScoreDict.TryGetValue(scoreCategory, out scoreFunc) ?
				scoreFunc(diceValues) :
				"Zero!";
		}
	}
}