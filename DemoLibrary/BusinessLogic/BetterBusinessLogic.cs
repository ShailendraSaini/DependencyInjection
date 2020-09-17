namespace DemoLibrary
{
    using System;
    using Utilities;

    /// <summary>
    ///     BetterBusinessLogic class
    /// </summary>
    public class BetterBusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        /// <summary>
        ///     Parameterized constructor of BetterBusinessLogic class
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="dataAccess"></param>
        public BetterBusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        /// <summary>
        ///     ProcessData method
        /// </summary>
        public void ProcessData()
        {
            _logger.Log(GlobalText.StartProcessingDataText);
            Console.WriteLine();
            Console.WriteLine(GlobalText.ProcessingDataText);
            _dataAccess.LoadData();
            _dataAccess.SaveData(GlobalText.ProcessedInfoText);
            Console.WriteLine();
            _logger.Log(GlobalText.FinishedProcessingDataText);
            Console.WriteLine();
        }
    }
}
