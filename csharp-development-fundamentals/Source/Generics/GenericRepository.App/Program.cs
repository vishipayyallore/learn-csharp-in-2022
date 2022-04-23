using GenericRepository.Lib.Entities;
using GenericRepository.Lib.Repositories.V1;
using GenericRepository.Lib.Repositories.V2;

AddEmployees(new EmployeeRepository());
AddOrganizations(new OrganizationRepository());

AddEmployeesV1(new GenericRepository<Employee>());
AddOrganizationsV1(new GenericRepository<Organization>());

static void AddEmployees(EmployeeRepository employeeRepository)
{
    foreach (var employee in GetAllEmployees())
    {
        employeeRepository.Add(employee);
    }

    employeeRepository.Save();
}

static void AddOrganizations(OrganizationRepository organizationRepository)
{
    foreach (var employee in GetAllEmployees())
    {
        organizationRepository.Add(employee);
    }

    organizationRepository.Save();
}

static void AddEmployeesV1(GenericRepository<Employee> employeeRepository)
{
    foreach (var employee in GetAllEmployees())
    {
        employeeRepository.Add(employee);
    }

    employeeRepository.Save();
}

static void AddOrganizationsV1(GenericRepository<Organization> organizationRepository)
{
    foreach (var organization in GetAllOrganization())
    {
        organizationRepository.Add(organization);
    }

    organizationRepository.Save();
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

static IEnumerable<Organization> GetAllOrganization()
{
    return new List<Organization>
    {
        new Organization { Name = "Organization 1"},
        new Organization { Name = "Organization 2"},
        new Organization { Name = "Organization 3"},
    };
}