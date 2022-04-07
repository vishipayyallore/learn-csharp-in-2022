using GenericRepository.V1.Entities;
using GenericRepository.V1.Repositories;

AddEmployees(new EmployeeRepository());

static void AddEmployees(EmployeeRepository employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Sri Varu" });
    employeeRepository.Add(new Employee { FirstName = "Vignesh" });
    employeeRepository.Add(new Employee { FirstName = "RamaKrishna" });
    employeeRepository.Save();
}
