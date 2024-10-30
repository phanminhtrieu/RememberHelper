using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Controllers.User;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh_backoffice.MVC.Controllers
{
    public class ControllerFactory
    {
        // Authentications
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public ControllerFactory(IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
        }

        public T CreateController<T>() where T : BaseController
        {
            object controller;

            switch (typeof(T))
            {
                case Type t when t == typeof(LoginController):
                    controller = new LoginController(_authenticationService);
                    break;
                case Type t when t == typeof(UserController):
                    controller = new UserController(_userService);
                    break;

                // Tạo một Controller không có inject các service vào (hay Controller đó chỉ sử dụng constructor không có tham số)
                default:
                    controller = Activator.CreateInstance<T>();
                    break;
            }

            return (T)controller;
        }
    }
}
