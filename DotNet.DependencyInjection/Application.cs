using DemoLibrary;

namespace DotNet.DependencyInjection
{
    /// <summary>
    ///     Application class
    /// </summary>
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        /// <summary>
        ///     Parametrized constructor of Application class
        /// </summary>
        /// <param name="businessLogic"></param>
        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        /// <summary>
        ///     Run method
        /// </summary>
        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
