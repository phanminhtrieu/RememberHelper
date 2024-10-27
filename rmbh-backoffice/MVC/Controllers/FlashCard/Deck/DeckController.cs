using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.VC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rmbh_backoffice.MVC.Controllers.FlashCard.Deck
{
    public class DeckController : Controller
    {
        private IView _view;

        public override IView View
        {
            get
            {
                return _view ?? new DeckManagementIview();
            }
        }

        public override bool Loadable()
        {
            return true;
        }
    }
}

