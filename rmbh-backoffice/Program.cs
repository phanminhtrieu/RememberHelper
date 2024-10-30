using rmbh_backoffice.MVC;
using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Models.Services;

namespace rmbh_backoffice
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Add services
            var controllerFactory = ServiceConfigurator.ConfigureServices();

            AppManager.Start<LoginController>(controllerFactory);
        }
    }
}