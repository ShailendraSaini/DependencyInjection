namespace DemoLibrary.Utilities
{
    /// <summary>
    ///     Interface IDataAccess
    /// </summary>
    public interface IDataAccess
    {
        /// <summary>
        ///     Interface method LoadData
        /// </summary>
        void LoadData();

        /// <summary>
        ///     Interface method SaveDatas
        /// </summary>
        /// <param name="name"></param>
        void SaveData(string name);
    }
}