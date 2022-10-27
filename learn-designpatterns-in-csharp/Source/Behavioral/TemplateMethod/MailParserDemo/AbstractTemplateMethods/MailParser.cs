using static System.Console;

namespace MailParserDemo.AbstractTemplateMethods
{

    /// <summary>
    /// AbstractClass
    /// </summary>
    public abstract class MailParser
    {
        public virtual void FindServer()
        {
            WriteLine("Finding server...");
        }

        public abstract void AuthenticateToServer();


        public virtual string ParseHtmlMailBody(string identifier)
        {
            WriteLine("Parsing HTML mail body...");
            return $"This is the body of mail with id {identifier}";
        }

        /// <summary>
        /// Template method
        /// </summary> 
        public string ParseMailBody(string identifier)
        {
            WriteLine("Parsing mail body (in template method)...");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }

}
