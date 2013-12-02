using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Adder;
using Moq;
using Machines;
using FluentAssertions;

namespace MathMachineTests
{
	[TestClass]
	public class MathMachineTests
	{
		private Mock<IAdder> _adderMock;

		public MathMachineTests()
		{
			_adderMock = new Mock<IAdder>();
		}

		[TestMethod]
		public void Add_Success()
		{
			// Arrange
			var expected = 5;
			_adderMock.Setup(x => x.Add(2, 3)).Returns(expected);
			var machine = new MathMachine(_adderMock.Object);

			// Act
			var actual = machine.Add(2, 3);

			// Assert
			actual.Should().Be(expected);
		}

		[TestMethod]
		public void Add_Failure()
		{
			// Arrange
			var expected = 5;
			// Dang, can't do this!
			//_adderMock.Setup(x => x.Add(3, -2)).Throws(new WholeNumberAdderException(It.IsAny<string>()));
			var machine = new MathMachine(_adderMock.Object);

			// Act
			var actual = machine.Add(3, -2);

			// Assert
			actual.Should().Be(expected);
		}

		[TestMethod]
		public void Add_ConcreteAdderImplementation_Failure()
		{
			// Arrange
			// Since I can't throw the whole adder exception from my mock,
			// I have to use an instance of the concrete implementation. Yuck.
			var adder = new WholeNumberAdder();
			var expected = 5;
			var machine = new MathMachine(adder);

			// Act
			var actual = machine.Add(3, -2);

			// Assert
			actual.Should().Be(expected);
		}
	}
}
