using EmployeeManagerDemo.Models;

using static System.Console;

namespace EmployeeManagerDemo.Receivers
{
    /// <summary>
    /// Receiver (implementation)
    /// </summary>
    public class EmployeeManagerRepository : IEmployeeManagerRepository
    {
        // for demo purposes, use an in-memory datastore as a fake "manager list"
        private readonly List<Manager> _managers = new()
            { new Manager(1, "Katie"), new Manager(2, "Geoff") };

        public void AddEmployee(int managerId, Employee employee)
        {
            // in real-life, add additional input & error checks
            _managers.First(m => m.Id == managerId).Employees.Add(employee);
        }

        public void RemoveEmployee(int managerId, Employee employee)
        {
            // in real-life, add additional input & error checks
            _managers.First(m => m.Id == managerId).Employees.Remove(employee);
        }

        public bool HasEmployee(int managerId, int employeeId)
        {
            // in real-life, add additional input & error checks
            return _managers.First(m => m.Id == managerId).Employees.Any(e => e.Id == employeeId);
        }


        /// <summary>
        /// For demo purposes, write out the data store to the console window
        /// </summary>
        public void WriteDataStore()
        {
            foreach (var manager in _managers)
            {
                WriteLine($"Manager {manager.Id}, {manager.Name}");
                if (manager.Employees.Any())
                {
                    foreach (var employee in manager.Employees)
                    {
                        WriteLine($"\t Employee {employee.Id}, {employee.Name}");
                    }
                }
                else
                {
                    WriteLine($"\t No employees.");
                }
            }
            WriteLine();
        }
    }

}
