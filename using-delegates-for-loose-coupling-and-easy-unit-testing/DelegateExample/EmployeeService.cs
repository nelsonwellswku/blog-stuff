using System;
using System.Collections.Generic;

namespace Console
{
	public interface IEmployeeService
	{
		Employee GetEmployee(int id);
	}

	public class EmployeeService : IEmployeeService
	{
		private readonly Dictionary<int, Employee> _db = new Dictionary<int, Employee>
		{
			{1, new Employee {FirstName = "John", LastName = "Smith"}},
			{2, new Employee {FirstName = "Jane", LastName = "Doe"}}
		};

		public Employee GetEmployee(int id)
		{
			Employee employee;
			var found = _db.TryGetValue(id, out employee);
			if(found)
			{
				return employee;
			}

			throw new InvalidOperationException("Employee record does not exist.");
		}
	}
}