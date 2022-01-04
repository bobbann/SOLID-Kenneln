using Autofac;
using Data;
using System.Linq;
using System.Reflection;

namespace SOLID_Kenneln
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register Main Application
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<MockData>().As<IMockData>();

            

            // Menu
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Menu"))
                .As(i => i.GetInterfaces()
                .FirstOrDefault(n => n.Name == "I" + i.Name));

            // Customers
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Customers"))
                .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Animals"))
                .AsImplementedInterfaces();
            // KennelPlaces
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(i => i.Namespace.Contains("Kennel"))
                .AsImplementedInterfaces();
            // Data
            builder.RegisterType<DatabaseUsingLists>().As<IDatabaseUsingLists>().SingleInstance();

            // Repository
            builder.RegisterType<DataRepository>().As<IDataRepository>();

            return builder.Build();
        }
    }
}