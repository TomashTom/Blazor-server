namespace Blazor_server.Data
{
    public class EmployeeServices : IemployeeServices
    {
        private List<Employee> _employees = new List<Employee>
        {

            new Employee
            {
                Name = "Name 1",
                Id = Guid.NewGuid(),
            },

            new Employee
            {
                Name = "Name 2",
                Id = Guid.NewGuid(),
            }
        };
        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
