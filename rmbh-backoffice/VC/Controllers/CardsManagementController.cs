using rmbh_backoffice.VC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.VC.Controllers
{
    public class CardsManagementController : Controller
    {
        private IView _view;

        public override IView View
        {
            get
            {
                return _view ?? new CardsManagementIView ();
            }
        }

        public override bool Loadable()
        {
            return true;
        }
    }
}
