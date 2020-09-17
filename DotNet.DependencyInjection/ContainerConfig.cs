namespace DotNet.DependencyInjection
{
    using Autofac;
    using DemoLibrary;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    ///     ContainerConfig class
    /// </summary>
    public static class ContainerConfig
    {
        /// <summary>
        ///     Configure method
        /// </summary>
        /// <returns></returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BetterBusinessLogic>().As<IBusinessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
