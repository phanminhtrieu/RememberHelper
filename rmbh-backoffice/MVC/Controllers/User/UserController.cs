using rmbh_backoffice.MVC.Models.Services.Users;
using rmbh_backoffice.MVC.Views;
using rmbh_backoffice.MVC.Views.User;

namespace rmbh_backoffice.MVC.Controllers.User
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private IView? _view;
        private UserView? _userView;

        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new UserView();
                }

                if (_view is UserView userView)
                {
                    _userView = userView;
                    _userView.Form.Load += GetAll;
                }

                return _view;
            }
        }

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public override bool Loadable()
        {
            return true;
        }

        private void GetAll(object? sender, EventArgs e)
        {
            if (_userView != null)
            {
                var users = _userService.GetAll();

                _userView.DataGridView.DataSource = users;
            }
        }

        

        

        

    }
}
