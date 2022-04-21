
using GenericRepository.Lib.Entities;
using GenericRepository.Lib.Repositories.V1;
using GenericRepository.Lib.Repositories.V2;

AddEmployees(new EmployeeRepository());

AddEmployeesV1(new GenericRepository<Employee>());

static void AddEmployees(EmployeeRepository employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Sri Varu" });
    employeeRepository.Add(new Employee { FirstName = "Vignesh" });
    employeeRepository.Add(new Employee { FirstName = "RamaKrishna" });

    employeeRepository.Save();
}

static void AddEmployeesV1(GenericRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Sri Varu" });
    employeeRepository.Add(new Employee { FirstName = "Vignesh" });
    employeeRepository.Add(new Employee { FirstName = "RamaKrishna" });

    employeeRepository.Save();
}

