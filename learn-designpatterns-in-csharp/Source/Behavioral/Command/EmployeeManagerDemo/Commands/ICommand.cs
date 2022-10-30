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

}
