namespace DemoLibrary.Utilities
{
    using System;

    /// <summary>
    ///     DataAccess Class
    /// </summary>
    public class DataAccess : IDataAccess
    {
        ILogger _logger;

        /// <summary>
        ///     Parametrized constructor of DataAccess Class
        /// </summary>
        /// <param name="logger"></param>
        public DataAccess(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     LogData method
        /// </summary>
        public void LoadData()
        {
            Console.WriteLine(GlobalText.LoadingDataText);
            _logger.Log(GlobalText.LoadingDataText);
        }

        /// <summary>
        ///     SaveData method
        /// </summary>
        /// <param name="name"></param>
        public void SaveData(string name)
        {
            Console.WriteLine(string.Format(GlobalText.SavingText, name));
            _logger.Log(GlobalText.SavingDataText);
        }
    }
}
