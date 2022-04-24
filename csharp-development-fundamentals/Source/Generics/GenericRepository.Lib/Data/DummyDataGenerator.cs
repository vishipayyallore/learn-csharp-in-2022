using GenericRepository.Lib.Entities;

namespace GenericRepository.Lib.Data
{

    public static class DummyDataGenerator
    {

        public static IEnumerable<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee { FirstName = "Sri Varu" },
                new Employee { FirstName = "Vignesh" },
                new Employee { FirstName = "RamaKrishna" }
            };
        }

        public static IEnumerable<Organization> GetAllOrganization()
        {
            return new List<Organization>
            {
                new Organization { Name = "Organization 1"},
                new Organization { Name = "Organization 2"},
                new Organization { Name = "Organization 3"},
            };
        }

    }

}
