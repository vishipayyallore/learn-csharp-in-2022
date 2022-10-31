using EmployeeManagerDemo.Models;

namespace EmployeeManagerDemo.Mementos
{
    /// <summary>
    /// Memento
    /// </summary>
    public class AddEmployeeToManagerListMemento
    {
        public int ManagerId { get; private set; }
        public Employee? Employee { get; private set; }

        public AddEmployeeToManagerListMemento(int managerId, Employee? employee)
        {
            ManagerId = managerId;
            Employee = employee;
        }
    }

}
