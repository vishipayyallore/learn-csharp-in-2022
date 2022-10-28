using MailParserDemo.AbstractTemplateMethods;

using static System.Console;

namespace MailParserDemo.TemplateMethods
{
    public class ApacheMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            WriteLine("Connecting to Apache");
        }
    }

}
