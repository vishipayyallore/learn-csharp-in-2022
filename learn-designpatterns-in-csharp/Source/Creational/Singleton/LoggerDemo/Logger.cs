using static System.Console;

namespace LoggerDemo
{

    public sealed class Logger
    {

        private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());
        DateTime dateTime = new();

        private Logger()
        {
        }

        public static Logger Instance => _lazyLogger.Value;

        public void Log(string message)
        {
            dateTime = DateTime.Now;
            WriteLine($"{dateTime} Message to log: {message}");
        }

    }

}
