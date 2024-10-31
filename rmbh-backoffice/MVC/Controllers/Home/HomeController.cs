using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC.Controllers.Home
{
    public class HomeController : BaseController
    {
        private IView? _view;

        public override IView View
        {
            get
            {
                return _view ?? new HomeView();
            }
        }

        public override bool Loadable()
        {
            return true;
        }
    }
}
