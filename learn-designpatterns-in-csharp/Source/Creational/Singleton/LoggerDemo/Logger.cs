using static System.Console;

namespace LoggerDemo
{

    public sealed class Logger
    {

        private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }

        public void Log(string message)
        {
            WriteLine($"Message to log: {message}");
        }

    }

}
