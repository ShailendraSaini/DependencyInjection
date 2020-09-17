namespace DemoLibrary
{
    using System;
    using Utilities;

    /// <summary>
    ///     Business Logic Class
    /// </summary>
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        /// <summary>
        ///     Paramerized constructor of BusinessLogic class
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="dataAccess"></param>
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
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
            Console.WriteLine(GlobalText.ProcessingDataText);
            _dataAccess.LoadData();
            _dataAccess.SaveData(GlobalText.ProcessedInfoText);
            _logger.Log(GlobalText.FinishedProcessingDataText);
        }
    }
}
