namespace DotNet.DependencyInjection
{
    using Autofac;
    using System;

    /// <summary>
    ///     Main class - Program
    /// </summary>
    class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
