using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.MVC.Views.Learning.Class;

namespace rmbh_backoffice.MVC.Controllers.Learning.Class
{
    public class ClassController : BaseController
    {
        private readonly IClassService _classService;
        private IView? _view;
        private ClassView? _classView;

        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new ClassView();
                }

                if (_view is ClassView classView)
                {
                    _classView = classView;
                }

                return _view;
            }
        }

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        public override bool Loadable()
        {
            return true;
        }
    }
}
