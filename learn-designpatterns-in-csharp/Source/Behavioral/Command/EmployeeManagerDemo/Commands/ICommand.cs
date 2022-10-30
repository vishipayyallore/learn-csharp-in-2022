namespace EmployeeManagerDemo.Commands
{

    /// <summary>
    /// ICommand
    /// </summary>
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }



    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Manager : Employee
    {
        public List<Employee> Employees = new();
        public Manager(int id, string name)
            : base(id, name)
        {
        }
    }

}
