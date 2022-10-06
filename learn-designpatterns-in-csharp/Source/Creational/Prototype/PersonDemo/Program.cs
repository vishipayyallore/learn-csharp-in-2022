using PersonDemo.Prototypes;

using static System.Console;

Title = "Design Pattern - Prototype";

ForegroundColor = ConsoleColor.Cyan;

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Clone();
WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Kevin", manager);
var employeeClone = (Employee)employee.Clone(true);
WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

// change the manager name
manager.Name = "Karen";
WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();