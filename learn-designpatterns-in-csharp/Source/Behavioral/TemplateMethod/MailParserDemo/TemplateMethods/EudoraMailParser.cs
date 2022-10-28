using MailParserDemo.AbstractTemplateMethods;

namespace MailParserDemo.TemplateMethods
{
    public class EudoraMailParser : MailParser
    {
        public override void FindServer()
        {
            Console.WriteLine("Finding Eudora server through a custom algorithm...");
        }
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Eudora");
        }
    }

}
