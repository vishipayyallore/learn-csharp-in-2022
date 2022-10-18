using MailServiceDemo.Components;

namespace MailServiceDemo.Decorators
{
    /// <summary>
    /// ConcreteDecorator2
    /// </summary>
    public class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        /// <summary>
        /// A list of sent messages - a "fake" database
        /// </summary>
        public List<string> SentMessages { get; private set; } = new List<string>();

        public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                // store sent message
                SentMessages.Add(message);

                return true;
            };

            return false;
        }
    }

}
