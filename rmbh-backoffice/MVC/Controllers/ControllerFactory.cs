using rmbh_backoffice.MVC.Controllers.Login;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Controllers
{
    public class ControllerFactory
    {
        // Authentications
        private readonly IAuthenticationService _authenticationService;

        public ControllerFactory(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public T CreateController<T>() where T : BaseController
        {
            object controller;

            // Kiểm tra xem loại controller có phải là LoginController không
            //if (typeof(T) == typeof(LoginController))
            //{
            //    return (T)(object)new LoginController(_authenticationService);
            //}

            switch (typeof(T))
            {
                case Type t when t == typeof(LoginController):
                    controller = new LoginController(_authenticationService);
                    break;
                //case Type t when t == typeof(LoginController):
                //    controller = new LoginController(_authenticationService);
                //    break;

                // Tạo một Controller không có inject các service vào (hay Controller đó chỉ sử dụng constructor không có tham số)
                default:
                    controller = Activator.CreateInstance<T>();
                    break;
            }

            return (T)controller;
        }
    }
}
