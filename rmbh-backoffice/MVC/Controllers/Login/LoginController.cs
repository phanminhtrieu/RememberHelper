using rmbh_backoffice.MVC.Controllers.Home;
using rmbh_backoffice.MVC.Models.Dtos.Authentications;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace rmbh_backoffice.MVC.Controllers.Login
{
    public class LoginController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;
        private IView? _view;
        private LoginView? _loginView;

        public override IView View
        {
            get
            {
                if (_view == null)
                {
                    _view = new LoginView();
                }

                if (_view is LoginView loginView)
                {
                    _loginView = loginView;
                    _loginView.ButtonLogin.Click += OnLoginAttempt;
                }

                return _view;
            }
        }
        
        public LoginController () { }

        public LoginController (IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public override bool Loadable()
        {
            return true;
        }

        private void OnLoginAttempt(object sender, EventArgs e)
        {
            // Kiểm tra _loginView có null hay không trước khi sử dụng
            if (_loginView != null)
            {
                var authenticationRequest = new AuthenticationRequest() 
                { 
                    Email = _loginView.TextBoxUserName.Text,
                    Password = _loginView.TextBoxPassword.Text,
                };

                if (_authenticationService.IsLoginSuccessful(authenticationRequest))
                {
                    AppManager.Instance.Load<HomeController>();
                }
                else
                {
                    // Thông báo lỗi đăng nhập
                    showLoginError("Username or password is incorrect.");

                    // Làm nổi bật các ô nhập liệu
                    sighlightInputFields();
                }
            }
        }

        private bool isLoginValid(string username, string password)
        {
            // Check username + pass + role trong Database
            // Và sẽ chuyển xuống phần 
            return username == "admin" && password == "1";
        }

        private void showLoginError(string message)
        {
            MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void sighlightInputFields()
        {
            if (_loginView != null)
            {
                _loginView.PanelUserName.BackColor = Color.Red; // Làm đỏ ô nhập username
                _loginView.PanelPassword.BackColor = Color.Red; // Làm đỏ ô nhập password
            }
        }
    }
}
