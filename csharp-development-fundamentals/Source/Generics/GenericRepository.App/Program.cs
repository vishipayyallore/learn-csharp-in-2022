using GenericRepository.Lib.Entities;
using GenericRepository.Lib.Repositories.V1;
using GenericRepository.Lib.Repositories.V2;

AddEmployees(new EmployeeRepository());
AddEmployeesV1(new GenericRepository<Employee>());

static void AddEmployees(EmployeeRepository employeeRepository)
{
    foreach (var employee in GetAllEmployees())
    {
        employeeRepository.Add(employee);
    }

    employeeRepository.Save();
}

static void AddEmployeesV1(GenericRepository<Employee> employeeRepository)
{
    foreach (var employee in GetAllEmployees())
    {
        employeeRepository.Add(employee);
    }

    employeeRepository.Save();
}

static IEnumerable<Employee> GetAllEmployees()
{
    return new List<Employee>
    {
        new Employee { FirstName = "Sri Varu" },
        new Employee { FirstName = "Vignesh" },
        new Employee { FirstName = "RamaKrishna" }
    };
}