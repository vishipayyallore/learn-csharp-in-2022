using GenericRepository.V1.Entities;

namespace GenericRepository.V1.Repositories
{

    public class EmployeeRepository
    {
        private readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Save()
        {
            foreach (var item in _employees)
            {
                Console.WriteLine(item);
            }
        }

    }

}
