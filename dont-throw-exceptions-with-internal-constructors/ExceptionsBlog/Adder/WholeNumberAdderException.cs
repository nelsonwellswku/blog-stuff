using System;

namespace Adder
{
	public class WholeNumberAdderException : Exception
	{
		internal WholeNumberAdderException() : base() { }
		internal WholeNumberAdderException(string message) : base(message) { }
		internal WholeNumberAdderException(string message, Exception innerException) : base(message, innerException) { }
	}
}
