namespace Console
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;
		private readonly MapperFunc<Employee, EmployeeViewModel> _mapEmployee;

		public EmployeeController(IEmployeeService employeeService, MapperFunc<Employee, EmployeeViewModel> mapEmployee)
		{
			_employeeService = employeeService;
			_mapEmployee = mapEmployee;
		}

		public EmployeeViewModel GetEmployee(int id)
		{
			var employee = _employeeService.GetEmployee(id);
			var employeeViewModel = _mapEmployee(employee);
			return employeeViewModel;
		}
	}
}