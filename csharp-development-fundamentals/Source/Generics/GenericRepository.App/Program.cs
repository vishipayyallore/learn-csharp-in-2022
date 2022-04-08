
using GenericRepository.Lib.Entities;
using GenericRepository.Lib.Repositories.V1;

AddEmployees(new EmployeeRepository());

static void AddEmployees(EmployeeRepository employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Sri Varu" });
    employeeRepository.Add(new Employee { FirstName = "Vignesh" });
    employeeRepository.Add(new Employee { FirstName = "RamaKrishna" });
    employeeRepository.Save();
}

