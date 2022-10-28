using MailParserDemo.AbstractTemplateMethods;

namespace MailParserDemo.TemplateMethods
{

    public class ExchangeMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Exchange");
        }
    }

}
