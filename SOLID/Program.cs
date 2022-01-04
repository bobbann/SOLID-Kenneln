using Autofac;

namespace SOLID_Kenneln
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Run Autofac configure
            var container = AFConfig.Configure();

            //Create an instance of IApplication since we are not using a constructor here
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}