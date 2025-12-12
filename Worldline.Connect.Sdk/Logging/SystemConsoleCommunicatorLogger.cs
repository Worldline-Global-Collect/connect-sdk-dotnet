using System;

namespace Worldline.Connect.Sdk.Logging
{
    /// <summary>
    /// A communicator logger that prints its message to the <see cref="Console"/>.
    /// It includes a timestamp in yyyy-MM-ddTHH:mm:ss format in the system time zone.
    /// </summary>
    public sealed class SystemConsoleCommunicatorLogger : ICommunicatorLogger
    {
        public static readonly SystemConsoleCommunicatorLogger Instance = new SystemConsoleCommunicatorLogger();

        public void Log(string message)
        {
            // Console.WriteLine is thread safe
            Console.WriteLine(DatePrefix + message);
        }

        public void Log(string message, Exception thrown)
        {
            // Console.WriteLine is thread safe
            Console.WriteLine(DatePrefix + message);
            if (thrown != null)
            {
                var e = thrown;
                do
                {
                    Console.WriteLine(e.ToString());
                    e = e.InnerException;
                }
                while (e != null);
            }
        }

        private SystemConsoleCommunicatorLogger()
        {

        }

        private static string DatePrefix => DateTime.Now.ToString("s") + " ";
    }
}
