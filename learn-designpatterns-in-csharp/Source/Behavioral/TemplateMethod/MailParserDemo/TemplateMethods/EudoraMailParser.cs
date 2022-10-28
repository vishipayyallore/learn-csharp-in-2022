using MailParserDemo.AbstractTemplateMethods;

using static System.Console;

namespace MailParserDemo.TemplateMethods
{
    public class EudoraMailParser : MailParser
    {
        public override void FindServer()
        {
            WriteLine("Finding Eudora server through a custom algorithm...");
        }

        public override void AuthenticateToServer()
        {
            WriteLine("Connecting to Eudora");
        }
    }

}
