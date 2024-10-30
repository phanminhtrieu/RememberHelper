using rmbh_backoffice.MVC.Controllers.Home;
using rmbh_backoffice.MVC.Models.Dtos.Authentications;
using rmbh_backoffice.MVC.Models.Services.Authentications;
using rmbh_backoffice.MVC.Views;

namespace rmbh_backoffice.MVC.Controllers.Login
{
    public class LoginController : BaseController
    {
        private readonly IAuthenticationService _authenticationService;
        private IView? _view;
        private LoginView? _loginView;

        public LoginController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

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

        public override bool Loadable()
        {
            return true;
        }

        public void OnLoginAttempt(object sender, EventArgs e)
        {
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
                    showLoginError("Username or password is incorrect.");

                    highlightInputFields();
                }
            }
        }

        private void showLoginError(string message)
        {
            MessageBox.Show(message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void highlightInputFields()
        {
            if (_loginView != null)
            {
                _loginView.PanelUserName.BackColor = Color.Red; // Làm đỏ ô nhập username
                _loginView.PanelPassword.BackColor = Color.Red; // Làm đỏ ô nhập password
            }
        }
    }
}
