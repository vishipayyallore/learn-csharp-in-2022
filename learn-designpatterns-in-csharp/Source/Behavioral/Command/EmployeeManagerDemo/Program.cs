using EmployeeManagerDemo.Commands;
using EmployeeManagerDemo.Invokers;
using EmployeeManagerDemo.Models;
using EmployeeManagerDemo.Receivers;
using static System.Console;

Title = "Design Pattern - Command";

ForegroundColor = ConsoleColor.Cyan;

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRepository();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(111, "Kevin")));
repository.WriteDataStore();

commandManager.Undo();
repository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(222, "Clara")));
repository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(333, "Tom")));
repository.WriteDataStore();

// try adding the same employee again
commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(333, "Tom")));
repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();

ResetColor();
WriteLine("\n\nPress any key ...");
ReadKey();

