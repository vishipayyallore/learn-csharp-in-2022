using static System.Console;

namespace MailServiceDemo.Decorators
{
    /// <summary>
    /// ConcreteComponent1
    /// </summary>
    public class CloudMailService : IMailService
    {

        public bool SendMail(string message)
        {
            WriteLine($"Message \"{message}\" sent via {nameof(CloudMailService)}.");

            return true;
        }

    }
}
