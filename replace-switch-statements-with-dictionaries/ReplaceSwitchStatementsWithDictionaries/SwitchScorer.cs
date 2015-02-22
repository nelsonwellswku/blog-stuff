using System.Collections.Generic;

namespace ReplaceSwitchStatementsWithDictionaries
{
	public class SwitchScorer
	{
		public string Score(ICollection<int> diceValues, ScoreCategory scoreCategory)
		{
			var score = "Zero!";
			switch(scoreCategory)
			{
				case ScoreCategory.ThreeOfAKind:
					// Here we'd process the dice values to see if it was a valid three of a kind or not
					score = "ThreeOfAKind";
					break;
				case ScoreCategory.FourOfAKind:
					score = "FourOfAKind";
					break;
				case ScoreCategory.FullHouse:
					score = "FullHouse";
					break;
				case ScoreCategory.SmallStraight:
					score = "SmallStraight";
					break;
				case ScoreCategory.LargeStraight:
					score = "LargeStraight";
					break;
				case ScoreCategory.Yahtzee:
					score = "Yahtzee";
					break;
				default:
					score = "Default";
					break;
			}

			return score;
		}
	}
}