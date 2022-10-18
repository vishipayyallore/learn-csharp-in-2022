using static System.Console;

namespace MailServiceDemo.Decorators
{
    /// <summary>
    /// ConcreteComponent2
    /// </summary>
    public class OnPremiseMailService : IMailService
    {

        public bool SendMail(string message)
        {
            WriteLine($"Message \"{message}\" sent via {nameof(OnPremiseMailService)}.");

            return true;
        }

    }
}
