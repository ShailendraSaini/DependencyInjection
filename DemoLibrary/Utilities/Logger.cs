namespace DemoLibrary.Utilities
{
    using System;

    /// <summary>
    ///     Logger Class
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        ///     Log method
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine(string.Format(GlobalText.LoggingText, message));
        }
    }
}
