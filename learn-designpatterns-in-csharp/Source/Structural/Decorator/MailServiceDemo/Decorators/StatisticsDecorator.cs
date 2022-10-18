using MailServiceDemo.Components;

using static System.Console;

namespace MailServiceDemo.Decorators
{
    /// <summary>
    /// ConcreteDecorator1
    /// </summary>
    public class StatisticsDecorator : MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            // Fake collecting statistics 
            WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}.");

            return base.SendMail(message);
        }
    }

}
