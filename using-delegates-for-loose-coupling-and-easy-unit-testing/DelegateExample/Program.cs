namespace Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var controller = new EmployeeController(
				new EmployeeService(), 
				emp => new EmployeeViewModel {FullName = $"{emp.FirstName} {emp.LastName}"});

			System.Console.WriteLine("Hello " + controller.GetEmployee(2).FullName);
			System.Console.WriteLine("Press any key to continue.");
			System.Console.ReadKey();
		}
	}

	public delegate TDest MapperFunc<in TSrc, out TDest>(TSrc source);

	public class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}

	public class EmployeeViewModel
	{
		public string FullName { get; set; }
	}
}