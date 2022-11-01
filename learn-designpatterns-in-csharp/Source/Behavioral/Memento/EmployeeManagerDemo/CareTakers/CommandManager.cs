using EmployeeManagerDemo.Commands;
using EmployeeManagerDemo.Mementos;

namespace EmployeeManagerDemo.CareTakers
{
    /// <summary>
    /// CareTaker (and Invoker from the Command pattern)
    /// </summary>
    public class CommandManager
    {
        private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new();

        private AddEmployeeToManagerList? _command;

        public void Invoke(AddEmployeeToManagerList command)
        {
            // if the command has not been stored yet, store it - we will
            // reuse it instead of storing different instances

            _command ??= command;

            if (command.CanExecute())
            {
                command.Execute();
                _mementos.Push(command.CreateMemento());
            }
        }

        public void Undo()
        {
            if (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }

        public void UndoAll()
        {
            while (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }
    }

}
