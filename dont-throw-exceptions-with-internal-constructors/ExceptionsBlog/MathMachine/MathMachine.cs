using Adder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
	public class MathMachine
	{
		private readonly IAdder _adder;

		public MathMachine(IAdder adder)
		{
			_adder = adder;
		}

		public int Add(int x, int y)
		{
			try
			{
				return _adder.Add(x, y);
			}
			catch (WholeNumberAdderException)
			{
				Console.WriteLine("An adder exception was thrown! Handling...");
				return _adder.Add(Math.Abs(x), Math.Abs(y));
			}
		}
	}
}
