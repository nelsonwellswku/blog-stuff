using System;
using Moq;
using NUnit.Framework;

namespace Console
{
	class EmployeeControllerTests
	{
		private Mock<IEmployeeService> _employeeServiceMock;
		private Employee _returnedEmployee;
		private EmployeeViewModel _returnedEmployeeViewModel;
		private MapperFunc<Employee, EmployeeViewModel> _mapEmployee;

		[SetUp]
		public void SetUp()
		{
			_returnedEmployee = new Employee();
			_returnedEmployeeViewModel = new EmployeeViewModel();
			_mapEmployee = emp => emp == _returnedEmployee ? _returnedEmployeeViewModel : null;

			_employeeServiceMock = new Mock<IEmployeeService>();
			_employeeServiceMock.Setup(x => x.GetEmployee(It.Is<int>(i => i == 1))).Returns(_returnedEmployee);
			_employeeServiceMock.Setup(x => x.GetEmployee(It.Is<int>(i => i != 1))).Throws<InvalidOperationException>();
		}

		[Test]
		public void GetEmployee_HappyPath()
		{
			// Arrange
			var controller = new EmployeeController(_employeeServiceMock.Object, _mapEmployee);

			// Act
			var viewModel = controller.GetEmployee(1);

			// Assert
			Assert.NotNull(viewModel);
		}

		[Test]
		public void GetEmployee_SadPath()
		{
			// Arrange
			var controller = new EmployeeController(_employeeServiceMock.Object, _mapEmployee);

			// Act
			Action act = () => controller.GetEmployee(2);

			// Assert
			Assert.Throws<InvalidOperationException>(new TestDelegate(act));

		}
	}
}