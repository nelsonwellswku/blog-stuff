namespace Adder
{
	public class WholeNumberAdder : IAdder
	{
		public int Add(int x, int y)
		{
			if (x < 0) throw new WholeNumberAdderException("Argument x less than 0");
			if (y < 0) throw new WholeNumberAdderException("Argument y less than 0");

			return x + y;
		}
	}
}
