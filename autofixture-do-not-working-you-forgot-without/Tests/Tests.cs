using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace Tests
{
	public class Tests
	{
		private readonly HashSet<string> _names = new HashSet<string>
		{
			"Peter",
			"Paul",
			"Mary",
			"John"
		};

		[Test]
		public void CustomizeFixture_NoWithout()
		{
			// Arrange
			var fixture = new Fixture();
			fixture.Customize<Employee>(ob => ob
				.Do(AssignRandomEmployeeType));

			// Act
			var employee = fixture.Create<Employee>();

			// Assert
			var inList = _names.Contains(employee.Name);
			Assert.IsTrue(inList); // Will always fail because the action executed in Do is overwritten by Autofixture
		}

		[Test]
		public void CustomizeFixture_WithWithout()
		{
			// Arrange
			var fixture = new Fixture();
			fixture.Customize<Employee>(ob => ob
				.Without(e => e.Name)
				.Do(AssignRandomEmployeeType));

			// Act
			var employee = fixture.Create<Employee>();

			// Assert
			var inList = _names.Contains(employee.Name);
			Assert.IsTrue(inList);
		}

		private void AssignRandomEmployeeType(Employee employee)
		{
			employee.Name = _names.OrderBy(x => Guid.NewGuid()).First();
		}
	}
}