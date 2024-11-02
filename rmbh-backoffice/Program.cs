using rmbh_backoffice.MVC;
using rmbh_backoffice.MVC.Controllers.Home;
using rmbh_backoffice.MVC.Controllers.Login;

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

            var controllerFactory = ServiceConfigurator.ConfigureServices();

            AppManager.Start<LoginController>(controllerFactory);    
        }
    }
}