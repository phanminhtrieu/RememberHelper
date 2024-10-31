using rmbh_backoffice.MVC.Controllers;
using rmbh_backoffice.MVC.Controllers.Learning.Class;
using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Controllers.User;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Models.Services.Classes;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh_backoffice.MVC
{
    /// <summary>
    /// A place where Controllers are created with their services.
    /// </summary>
    public class ControllerFactory
    {
        // Authentications
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        private readonly IClassService _classService;

        public ControllerFactory(
            IAuthenticationService authenticationService, 
            IUserService userService,
            IClassService classService)
        {
            _authenticationService = authenticationService;
            _userService = userService;
            _classService = classService;
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

                case Type t when t == typeof(ClassController):
                    controller = new ClassController(_classService);
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
