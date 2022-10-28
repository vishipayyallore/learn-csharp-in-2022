using MailParserDemo.AbstractTemplateMethods;

using static System.Console;

namespace MailParserDemo.TemplateMethods
{

    public class ExchangeMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            WriteLine("Connecting to Exchange");
        }
    }

}
