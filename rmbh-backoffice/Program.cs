using rmbh_backoffice.MVC;
using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Views;

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

            AppManager.Start<LoginController>();
        }
    }
}